
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;

namespace StockCredit.OAuth;

public class TokenMocks
{
    public TokenMocks(IWebHostEnvironment env)
    {

        RsaKey = RSA.Create();
        var path = Path.Combine(env.ContentRootPath, "token_key");

        if (File.Exists(path))
        {
            var rsaKey = RSA.Create();
            rsaKey.ImportRSAPrivateKey(File.ReadAllBytes(path), out _);
        }
        else
        {
            var privateKey = RsaKey.ExportRSAPrivateKey();
            File.WriteAllBytes(path, privateKey);
        }
    }

    public RSA RsaKey { get; }
    public RsaSecurityKey RsaSecurityKey => new RsaSecurityKey(RsaKey);
}