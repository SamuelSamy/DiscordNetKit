using Newtonsoft.Json;

namespace DiscordNetKit.Types;

public class ThreadMetadata
{
    public bool Archived { get; set; }

    [JsonProperty("auto_archive_duration")]
    public ulong? AutoArchiveDuration { get; set; }

    [JsonProperty("archive_timestamp")]
    public ulong? ArchiveTimestamp { get; set; }

    public bool Locked { get; set; }

    public bool? Invitable { get; set; }

    [JsonProperty("create_timestamp")]
    public ulong? CreateTimestamp { get; set; }
}