using DiscordNetKit.Enums;
using DiscordNetKit.Interfaces.Types;

namespace DiscordNetKit.Types.DiscordObjects;

public class Channel : IChannel
{
    public Snowflake Id { get; set; }
    public ChannelType Type { get; set; }
    public Snowflake GuildId { get; set; }
    public ulong? Position { get; set; }
    public IList<Overwrite> PermissionOverwrites { get; set; }
    public string Name { get; set; }
    public string Topic { get; set; }
    public bool? Nsfw { get; set; }
    public Snowflake? LastMessageId { get; set; }
    public ulong? Bitrate { get; set; }
    public ulong? UserLimit { get; set; }
    public ulong? RateLimitPerUser { get; set; }
    public IList<IUser>? Recipients { get; set; }
    public string Icon { get; set; }
    public Snowflake OwnerId { get; set; }
    public Snowflake ApplicationId { get; set; }
    public bool? Managed { get; set; }
    public Snowflake? ParentId { get; set; }
    public DateTime? LastPinTimestamp { get; set; }
    public string? RtcRegion { get; set; }
    public ulong? VideoQualityMode { get; set; }
    public ulong? MessageCount { get; set; }
    public ulong? MemberCount { get; set; }
    public ThreadMetadata? ThreadMetadata { get; set; }
    public ThreadMemeber? Member { get; set; }
    public ulong? DefaultAutoArchiveDuration { get; set; }
    public Permissions? Permissions { get; set; }
    public ulong? Flags { get; set; }
    public ulong? TotalMessagesSent { get; set; }
    public IList<ChannelTag>? AvailableTags { get; set; }
    public IList<ChannelTag>? AppliedTags { get; set; }
    public DefaultReaction? DefaultReactionEmoji { get; set; }
    public ulong? DefaultThreadRateLimitPerUser { get; set; }
    public ulong? DefaultSortOrder { get; set; }
    public ulong? DefaultForumLayout { get; set; }
}