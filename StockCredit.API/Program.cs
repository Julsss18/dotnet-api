using System.Text.Json;
using Microsoft.AspNetCore.Authentication;
using StockCredit.API.Models;
using StockCredit.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication("cookie")
    .AddCookie("cookie")
    .AddOAuth("custom", config =>
    {

        config.SignInScheme = "cookie";

        config.ClientId = "client_id";
        config.ClientSecret = "client_secret";

        config.AuthorizationEndpoint = "http://host.docker.internal:8081/oauth/authorize";
        config.TokenEndpoint = "http://host.docker.internal:8081/oauth/token";

        config.CallbackPath = "/oauth/callback";

        config.UsePkce = true;
        config.ClaimActions.MapJsonKey("sub", "sub");

        config.Events.OnCreatingTicket = ctx =>
        {
            if (ctx.AccessToken != null)
            {
                var base64 = ctx.AccessToken.Split('.')[1];
                var json = Base64UrlTextEncoder.Decode(base64);
                var payload = JsonDocument.Parse(json);

                ctx.RunClaimActions(payload.RootElement);
            }
            return Task.CompletedTask;
        };
    });

builder.Services.AddAuthorization();

builder.Services.AddHttpClient();

builder.Services.AddSingleton<IStockCreditService, StockCreditService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/", (HttpContext ctx) =>
{
    return ctx.User.Claims.Select(x => new { x.Type, x.Value }).ToList();
});

app.MapGet("/login", () =>
{
    return Results.Challenge(
        new AuthenticationProperties()
        {
            RedirectUri = "http://localhost:8080"
        },
        authenticationSchemes: ["custom"]
    );
});

app.MapGet("/api/stocks", (string? duration) =>
{
    try
    {
        var stockCreditService = new StockCreditService();
        List<Stocks> stocks = new List<Stocks>();

        if (duration != null) stocks = stockCreditService.GetStocks(duration);
        else stocks = stockCreditService.GetStocks();

        if (stocks.Count == 0) return Results.NotFound();

        return Results.Ok(stocks);
    }
    catch (Exception)
    {
        return Results.BadRequest();
    }
})
.WithName("GetStocks")
.WithOpenApi()
.Produces<List<Stocks>>()
.Produces(statusCode: 400);

app.MapGet("/api/credits", (string? duration) =>
{
    try
    {
        var stockCreditService = new StockCreditService();
        List<Credits> credits = new List<Credits>();

        if (duration != null) credits = stockCreditService.GetCredits(duration);
        else credits = stockCreditService.GetCredits();

        if (credits.Count == 0) return Results.NotFound();

        return Results.Ok(credits);
    }
    catch (Exception)
    {
        return Results.BadRequest();
    }

})
.WithName("GetCredits")
.WithOpenApi()
.Produces<List<Credits>>()
.Produces(statusCode: 400);


app.MapGet("/api/auth/stocks", (IHttpClientFactory clientFactory, HttpContext context, string? duration) =>
{
    var user = context.User.Claims.Select(x => new { x.Type, x.Value }).ToList();
    try
    {
        if (user[0] == null) throw new ArgumentOutOfRangeException();

        var stockCreditService = new StockCreditService();
        List<Stocks> stocks = new List<Stocks>();

        if (duration != null) stocks = stockCreditService.GetStocks(duration);
        else stocks = stockCreditService.GetStocks();

        if (stocks.Count == 0) return Results.NotFound();

        return Results.Ok(stocks);
    }
    catch (ArgumentOutOfRangeException)
    {
        return Results.Challenge(
            new AuthenticationProperties()
            {
                RedirectUri = "http://localhost:8080"
            },
            authenticationSchemes: ["custom"]
        );
    }
    catch (Exception)
    {
        return Results.BadRequest();
    }
});

app.MapGet("/api/auth/credits", (IHttpClientFactory clientFactory, HttpContext context, string? duration) =>
{
    var user = context.User.Claims.Select(x => new { x.Type, x.Value }).ToList();
    try
    {
        if (user[0] == null) throw new ArgumentOutOfRangeException();

        var stockCreditService = new StockCreditService();
        List<Credits> credits = new List<Credits>();

        if (duration != null) credits = stockCreditService.GetCredits(duration);
        else credits = stockCreditService.GetCredits();

        if (credits.Count == 0) return Results.NotFound();

        return Results.Ok(credits);
    }
    catch (ArgumentOutOfRangeException)
    {
        return Results.Challenge(
            new AuthenticationProperties()
            {
                RedirectUri = "http://localhost:8080"
            },
            authenticationSchemes: ["custom"]
        );
    }
    catch (Exception)
    {
        return Results.BadRequest();
    }
});

app.Run();
