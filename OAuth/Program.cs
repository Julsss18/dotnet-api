
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using System.Web;
using System.Text.Json;

using StockCredit.OAuth.Models;
using StockCredit.OAuth;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.IdentityModel.JsonWebTokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddAuthentication("cookie")
    .AddCookie("cookie", config =>
    {
        config.LoginPath = "/login";
    });

builder.Services.AddAuthorization();
builder.Services.AddSingleton<TokenMocks>();

var app = builder.Build();

app.MapGet("/login", async (
    string returnUrl,
    HttpResponse response
) =>
{
    response.Headers.ContentType = new string[] { "text/html" };

    await response.WriteAsync(
    $"""
    <html>
        <head>
            <title>Login</title>
        </head>
        <body>
            <form action = "/login?returnUrl={HttpUtility.UrlEncode(returnUrl)}" method = "post">
                <input value = "Login" type = "submit" />
            </form>
        </body>
    </html>
    """
    );
});

app.MapPost("/login", async (HttpContext ctx, string returnUrl) =>
{
    await ctx.SignInAsync(
        "cookie",
        new ClaimsPrincipal(
            new ClaimsIdentity(
                new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString())
                },
                "cookie"
            )
        )
    );
    return Results.Redirect(returnUrl);
});

app.MapGet("/oauth/authorize", (
    IDataProtectionProvider dataProtecterProvider,
    string? response_type,
    string? client_id,
    string? redirect_uri,
    string? code_challenge,
    string? code_challenge_method,
    string? scope,
    string? state
) =>
{

    var protector = dataProtecterProvider.CreateProtector("oauth");
    var code = new Auth()
    {
        ClientId = client_id,
        CodeChallenge = code_challenge,
        CodeChallengeMethod = code_challenge_method,
        RedirectUri = redirect_uri,
        Expiry = DateTime.Now.AddMinutes(5),
    };


    var codeString = protector.Protect(JsonSerializer.Serialize(code));

    return Results.Redirect($"{redirect_uri}?code={codeString}&state={state}&iss={HttpUtility.UrlEncode("http://host.docker.internal:8081")}");
}).RequireAuthorization();

app.MapPost("/oauth/token", async (HttpRequest request, TokenMocks tokenMocks) =>
{
    var bodyBytes = await request.BodyReader.ReadAsync();
    var bodyContent = Encoding.UTF8.GetString(bodyBytes.Buffer);

    string grantType = "";
    string code = "";
    string redirectUri = "";
    string codeVerifier = "";

    foreach (var part in bodyContent.Split('&'))
    {
        var subParts = part.Split('=');
        var key = subParts[0];
        var value = subParts[1];

        if (key == "grant_type")
        {
            grantType = value;
        }
        else if (key == "code")
        {
            code = value;
        }
        else if (key == "redirect_uri")
        {
            redirectUri = value;
        }
        else if (key == "code_verifier")
        {
            codeVerifier = value;
        }
    }

    var handler = new JsonWebTokenHandler();

    var claims = new Dictionary<string, object>()
    {
        [JwtRegisteredClaimNames.Sub] = Guid.NewGuid().ToString(),
        ["custom"] = "token"
    };

    var descriptors = new SecurityTokenDescriptor()
    {
        Claims = claims,
        Expires = DateTime.Now.AddMinutes(60),
        TokenType = "Bearer",
        SigningCredentials = new SigningCredentials(tokenMocks.RsaSecurityKey, SecurityAlgorithms.RsaSha256)
    };

    try
    {
        var tok = handler.CreateToken(descriptors);

        return Results.Ok(new
        {
            access_token = tok
        });
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return Results.BadRequest(ex);
    }

});



app.Run();
