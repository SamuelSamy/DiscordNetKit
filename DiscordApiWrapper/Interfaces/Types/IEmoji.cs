using DiscordNetKit.Types;
using DiscordNetKit.Types.DiscordObjects;
using Newtonsoft.Json;

namespace DiscordNetKit.Interfaces.Types;

public interface IEmoji
{
    public Snowflake Id { get; set; }

    public string Name { get; set; }

    public IList<Role> Roles { get; set; }
    
    public User User { get; set; }

    [JsonProperty("require_colons")]
    public bool? RequireColons { get; set; }

    public bool? Managed { get; set; }

    public bool? Animated { get; set; }

    public bool? Available { get; set; }
}