namespace StockCredit.OAuth.Models;

public class Auth
{
    public string? ClientId { get; set; }
    public string? CodeChallenge { get; set; }
    public string? CodeChallengeMethod { get; set; }
    public string? RedirectUri { get; set; }
    public DateTime Expiry { get; set; }
}