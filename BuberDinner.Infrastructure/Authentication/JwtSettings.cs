namespace BuberDinner.Infrastructure.Authentication;

public class JwtSettings
{
    public const string SectionName = "JwtSettings";
    public string Issuer { get; init; } = null!;
    public string Secret { get; init; } = null!;
    public int TokenLifetimeMinutes { get; init; }
    public string Audience { get; init; } = null!;
}