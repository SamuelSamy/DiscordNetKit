using DiscordNetKit.Enums;
using DiscordNetKit.Interfaces.Types;
using DiscordNetKit.Interfaces.Types.Guilds;

namespace DiscordNetKit.Types.DiscordObjects.Guilds;

public class Guild : IGuild
{
    public Snowflake Id { get; set; }
    public string Name { get; set; }
    public string? Icon { get; set; }
    public string? IcopnHash { get; set; }
    public string? Splash { get; set; }
    public string? DiscoverySplash { get; set; }
    public bool? Owner { get; set; }
    public Snowflake OwnerId { get; set; }
    public Permissions? Permissions { get; set; }
    public string? Region { get; set; }
    public Snowflake? AfkChannelId { get; set; }
    public ulong AfkTimeout { get; set; }
    public bool? WidgetEnabled { get; set; }
    public Snowflake? WidgetChannelId { get; set; }
    public VerificationLevel VerificationLevel { get; set; }
    public MessageNotificationLevel DefaultMessageNotifications { get; set; }
    public ExplicitContentFilterLevel ExplicitContentFilter { get; set; }
    public IList<Role> Roles { get; set; }
    public IList<Emoji> Emojis { get; set; }
    public IList<string> Features { get; set; }
    public MFALevel MfaLevel { get; set; }
    public Snowflake? ApplicationId { get; set; }
    public Snowflake? SystemChannelId { get; set; }
    public SystemChannelFlags SystemChannelFlags { get; set; }
    public Snowflake? RulesChannelId { get; set; }
    public ulong? MaxPresences { get; set; }
    public ulong? MaxMembers { get; set; }
    public string? VanityUrlCode { get; set; }
    public string? Description { get; set; }
    public string? Banner { get; set; }
    public PremiumTier PremiumTier { get; set; }
    public ulong? PremiumSubscriptionCount { get; set; }
    public string PreferredLocale { get; set; }
    public Snowflake? PublicUpdatesChannelId { get; set; }
    public ulong? MaxVideoChannelUsers { get; set; }
    public ulong? MaxStageVideoChannelUsers { get; set; }
    public ulong? ApproximateMemberCount { get; set; }
    public ulong? ApproximatePresenceCount { get; set; }
    public GuildNSFWLevel NsfwLevel { get; set; }
    public bool PremiumProgressBarEnabled { get; set; }
    public Snowflake? SafetyAlertsChannelId { get; set; }
}