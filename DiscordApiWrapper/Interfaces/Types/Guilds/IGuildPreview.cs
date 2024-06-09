using DiscordNetKit.Enums;
using DiscordNetKit.Types;
using DiscordNetKit.Types.DiscordObjects;
using Newtonsoft.Json;

namespace DiscordNetKit.Interfaces.Types.Guilds;

public interface IGuildPreview
{
    public Snowflake Id { get; set; }

    public string Name { get; set; }

    public string? Icon { get; set; }

    public string? Splash { get; set; }

    [JsonProperty("discovery_splash")]
    public string? DiscoverySplash { get; set; }

    public List<Emoji> Emojis { get; set; }

    public List<string> Features { get; set; }


    [JsonProperty("approximate_member_count")]
    public ulong? ApproximateMemberCount { get; set; }

    [JsonProperty("approximate_presence_count")]
    public ulong? ApproximatePresenceCount { get; set; }

    // Stickers

    public string Description { get; set; }
}