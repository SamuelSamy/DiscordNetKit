using DiscordNetKit.Interfaces.Types;
using DiscordNetKit.Interfaces.Types.Guilds;

namespace DiscordNetKit.Types.DiscordObjects.Guilds;

public class GuildPreview : IGuildPreview
{
    public Snowflake Id { get; set; }
    public string Name { get; set; }
    public string? Icon { get; set; }
    public string? Splash { get; set; }
    public string? DiscoverySplash { get; set; }
    public List<Emoji> Emojis { get; set; }
    public List<string> Features { get; set; }
    public ulong? ApproximateMemberCount { get; set; }
    public ulong? ApproximatePresenceCount { get; set; }
    public string Description { get; set; }
}