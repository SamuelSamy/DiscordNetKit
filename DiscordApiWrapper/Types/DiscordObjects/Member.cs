using DiscordNetKit.Interfaces.Types;
using DiscordNetKit.Interfaces.Types.Guilds;

namespace DiscordNetKit.Types.DiscordObjects;

public class Member : IMember
{
    public IGuild Guild { get; set; }
    public Snowflake Id { get; set; }
    public string Username { get; set; }
    public string Nick { get; set; }
    public string Discriminator { get; set; }
    public string GlobalName { get; set; }
    public string Avatar { get; set; }
    public bool? Bot { get; set; }
    public bool? System { get; set; }
    public bool? MfaEnabled { get; set; }
    public string Banner { get; set; }
    public ulong? AccentColor { get; set; }
    public string Locale { get; set; }
    public bool? Verified { get; set; }
    public string Email { get; set; }
    public ulong? Flags { get; set; }
    public ulong? PremiumType { get; set; }
    public ulong? PublicFlags { get; set; }
    public string AvatarDecoration { get; set; }
}