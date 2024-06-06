using DiscordNetKit.Interfaces.Types;

namespace DiscordNetKit.Types.DiscordObjects;

public class Emoji : IEmoji
{
    public Snowflake Id { get; set; }
    public string Name { get; set; }
    public IList<Role> Roles { get; set; }
    public User User { get; set; }
    public bool? RequireColons { get; set; }
    public bool? Managed { get; set; }
    public bool? Animated { get; set; }
    public bool? Available { get; set; }
}