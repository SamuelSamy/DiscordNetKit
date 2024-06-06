using DiscordNetKit.Enums;
using DiscordNetKit.Types;
using DiscordNetKit.Types.DiscordObjects;
using Newtonsoft.Json;

namespace DiscordNetKit.Interfaces.Types.Guilds;

public interface IGuild
{
    public Snowflake Id { get; set; }

    public string Name { get; set; }

    public string? Icon { get; set; }

    [JsonProperty("icon_hash")]
    public string? IcopnHash { get; set; }

    public string? Splash { get; set; }

    [JsonProperty("discovery_splash")]
    public string? DiscoverySplash { get; set; }

    public bool? Owner { get; set; }

    [JsonProperty("owner_id")]
    public Snowflake OwnerId { get; set; }

    public Permissions? Permissions { get; set; }

    public string? Region { get; set; }

    [JsonProperty("afk_channel_id")]
    public Snowflake? AfkChannelId { get; set; }

    [JsonProperty("afk_timeout")]
    public ulong AfkTimeout { get; set; }

    [JsonProperty("widget_enabled")]
    public bool? WidgetEnabled { get; set; }

    [JsonProperty("widget_channel_id")]
    public Snowflake? WidgetChannelId { get; set; }

    [JsonProperty("verification_level")]
    public VerificationLevel VerificationLevel { get; set; }

    [JsonProperty("default_message_notifications")]
    public MessageNotificationLevel DefaultMessageNotifications { get; set; }

    [JsonProperty("explicit_content_filter")]
    public ExplicitContentFilterLevel ExplicitContentFilter { get; set; }

    public IList<Role> Roles { get; set; }

    public IList<Emoji> Emojis { get; set; }

    public IList<string> Features { get; set; }

    [JsonProperty("mfa_level")]
    public MFALevel MfaLevel { get; set; }

    [JsonProperty("application_id")]
    public Snowflake? ApplicationId { get; set; }

    [JsonProperty("system_channel_id")]
    public Snowflake? SystemChannelId { get; set; }

    [JsonProperty("system_channel_flags")]
    public SystemChannelFlags SystemChannelFlags { get; set; }

    [JsonProperty("rules_channel_id")]
    public Snowflake? RulesChannelId { get; set; }

    [JsonProperty("max_presences")]
    public ulong? MaxPresences { get; set; }

    [JsonProperty("max_members")]
    public ulong? MaxMembers { get; set; }

    [JsonProperty("vanity_url_code")]
    public string? VanityUrlCode { get; set; }

    public string? Description { get; set; }

    public string? Banner { get; set; }

    [JsonProperty("premium_tier")]
    public PremiumTier PremiumTier { get; set; }

    [JsonProperty("premium_subscription_count")]
    public ulong? PremiumSubscriptionCount { get; set; }

    [JsonProperty("preferred_locale")]
    public string PreferredLocale { get; set; }

    [JsonProperty("public_updates_channel_id")]
    public Snowflake? PublicUpdatesChannelId { get; set; }

    [JsonProperty("max_video_channel_users")]
    public ulong? MaxVideoChannelUsers { get; set; }

    [JsonProperty("max_stage_video_channel_users")]
    public ulong? MaxStageVideoChannelUsers { get; set; }

    [JsonProperty("approximate_member_count")]
    public ulong? ApproximateMemberCount { get; set; }

    [JsonProperty("approximate_presence_count")]
    public ulong? ApproximatePresenceCount { get; set; }

    // Welcome Screen

    [JsonProperty("nsfw_level")]
    public GuildNSFWLevel NsfwLevel { get; set; }

    // Stickers

    [JsonProperty("premium_progress_bar_enabled")]
    public bool PremiumProgressBarEnabled { get; set; }

    [JsonProperty("safety_alerts_channel_id")]
    public Snowflake? SafetyAlertsChannelId { get; set; }
}