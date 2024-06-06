using DiscordNetKit.Enums;
using DiscordNetKit.Types;
using Newtonsoft.Json;

namespace DiscordNetKit.Interfaces.Types;

public interface IChannel
{
    public Snowflake Id { get; set; }

    public ChannelType Type { get; set; }

    [JsonProperty("guild_id")]
    public Snowflake GuildId { get; set; }

    public ulong? Position { get; set; }

    [JsonProperty("permission_overwrites")]
    public IList<Overwrite> PermissionOverwrites { get; set; }

    public string Name { get; set; }

    public string Topic { get; set; }

    public bool? Nsfw { get; set; }

    [JsonProperty("last_message_id")]
    public Snowflake? LastMessageId { get; set; }

    public ulong? Bitrate { get; set; }

    [JsonProperty("user_limit")]
    public ulong? UserLimit { get; set; }

    [JsonProperty("rate_lmit_per_user")]
    public ulong? RateLimitPerUser { get; set; }

    public IList<IUser>? Recipients { get; set; }

    public string Icon { get; set; }

    [JsonProperty("owner_id")]
    public Snowflake OwnerId { get; set; }

    [JsonProperty("application_id")]
    public Snowflake ApplicationId { get; set; }

    public bool? Managed { get; set; }

    [JsonProperty("parent_id")]
    public Snowflake? ParentId { get; set; }

    [JsonProperty("last_pin_timestamp")]
    public DateTime? LastPinTimestamp { get; set; }

    [JsonProperty("rtc_region")]
    public string? RtcRegion { get; set; }

    [JsonProperty("video_quality_mode")]
    public ulong? VideoQualityMode { get; set; }

    [JsonProperty("message_count")]
    public ulong? MessageCount { get; set; }

    [JsonProperty("member_count")]
    public ulong? MemberCount { get; set; }

    [JsonProperty("thread_metadata")]
    public ThreadMetadata? ThreadMetadata { get; set; }

    public ThreadMemeber? Member { get; set; }

    [JsonProperty("default_auto_archive_duration")]
    public ulong? DefaultAutoArchiveDuration { get; set; }

    public Permissions? Permissions { get; set; }

    public ulong? Flags { get; set; }

    [JsonProperty("total_messages_sent")]
    public ulong? TotalMessagesSent { get; set; }

    [JsonProperty("available_tags")]
    public IList<ChannelTag>? AvailableTags { get; set; }

    [JsonProperty("applied_tags")]
    public IList<ChannelTag>? AppliedTags { get; set; }

    [JsonProperty("default_reaction_emoji")]
    public DefaultReaction? DefaultReactionEmoji { get; set; }

    [JsonProperty("default_thread_rate_limit_per_user")]
    public ulong? DefaultThreadRateLimitPerUser { get; set; }

    [JsonProperty("default_sort_order")]
    public ulong? DefaultSortOrder { get; set; }

    [JsonProperty("default_forum_layout")]
    public ulong? DefaultForumLayout { get; set; }
}