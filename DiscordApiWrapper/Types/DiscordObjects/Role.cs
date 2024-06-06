using DiscordNetKit.Interfaces.Types;

namespace DiscordNetKit.Types.DiscordObjects;

public class Role : IRole
{
    public Snowflake Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ulong Color { get; set; }
    public bool Hoist { get; set; }
    public string? Icon { get; set; }
    public string? UnicodeEmoji { get; set; }
    public ulong Position { get; set; }
    public Permissions Permissions { get; set; }
    public bool Managed { get; set; }
    public bool Mentionable { get; set; }
}