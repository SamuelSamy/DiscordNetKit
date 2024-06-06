using DiscordNetKit.Types;
using Newtonsoft.Json;

namespace DiscordNetKit.Interfaces.Types;

public interface IUser
{
    #region Properties

    public Snowflake Id { get; set; }
    
    public string Username { get; set; }
    
    public string Discriminator { get; set; }

    [JsonProperty("global_name")]
    public string GlobalName { get; set; }
    
    public string Avatar { get; set; }
    
    public bool? Bot { get; set; }
    
    public bool? System { get; set; }

    [JsonProperty("mfa_enabled")]
    public bool? MfaEnabled { get; set; }
    
    public string Banner { get; set; }

    [JsonProperty("accent_color")]    
    public ulong? AccentColor { get; set; }
    
    public string Locale { get; set; }
    
    public bool? Verified { get; set; }
    
    public string Email { get; set; }
    
    public ulong? Flags { get; set; }

    [JsonProperty("premium_type")]
    public ulong? PremiumType { get; set; }

    [JsonProperty("public_flags")]
    public ulong? PublicFlags { get; set; } // TODO: Replace with a Flags class

    [JsonProperty("avatar_decoration")]
    public string AvatarDecoration { get; set; }

    #endregion
}