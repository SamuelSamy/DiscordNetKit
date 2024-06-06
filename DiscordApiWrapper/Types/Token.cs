namespace DiscordNetKit.Types;

public class Token
{
    public string AccessToken { get; set; }
    public string TokenType { get; set; }
    public string RefreshToken { get; set; }
    public string Scope { get; set; }
    public ulong ExpiresIn { get; set; }
}