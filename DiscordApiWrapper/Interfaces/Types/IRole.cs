using DiscordNetKit.Types;
using Newtonsoft.Json;

namespace DiscordNetKit.Interfaces.Types;

public interface IRole
{
    public Snowflake Id { get; set; }

    public string Description { get; set; }

    public string Name { get; set; }

    public ulong Color { get; set; }

    public bool Hoist { get; set; }

    public string? Icon { get; set; }

    [JsonProperty("unicode_emoji")]
    public string? UnicodeEmoji { get; set; }

    public ulong Position { get; set; }

    public Permissions Permissions { get; set; }

    public bool Managed { get; set; }

    public bool Mentionable { get; set; }

    // Tags
    // Flags
}