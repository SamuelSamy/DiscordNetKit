using DiscordNetKit.Interfaces.Types;
using Newtonsoft.Json;

namespace DiscordNetKit.Types;

public class ThreadMemeber
{
    public Snowflake? Id { get; set; }

    [JsonProperty("user_id")]
    public Snowflake? UserId { get; set; }

    [JsonProperty("join_timestamp")]
    public ulong JoinTimestamp { get; set; }

    public ulong? Flags { get; set; }

    public IMember? Member { get; set; }
}