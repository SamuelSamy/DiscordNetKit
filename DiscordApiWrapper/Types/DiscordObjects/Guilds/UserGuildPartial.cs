using Newtonsoft.Json;

namespace DiscordNetKit.Types.DiscordObjects.Guilds;

public class UserGuildPartial
{
    public Snowflake Id { get; set; }

    public string Name { get; set; }

    public string Icon { get; set; }

    public bool Owner { get; set; }

    public Permissions Permissions { get; set; }

    public IList<string> Features { get; set; }

    [JsonProperty("approximate_member_count")]
    public int ApproximateMemberCount { get; set; }

    [JsonProperty("approximate_presence_count")]
    public int ApproximatePresenceCount { get; set; }
}