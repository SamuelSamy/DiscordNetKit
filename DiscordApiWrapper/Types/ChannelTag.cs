using Newtonsoft.Json;

namespace DiscordNetKit.Types;

public class ChannelTag
{
    public Snowflake Id { get; set; }

    public string Name { get; set; }

    public bool Moderated { get; set; }

    [JsonProperty("emoji_id")]
    public Snowflake EmojiId { get; set; }

    [JsonProperty("emoji_name")]
    public string EmojiName { get; set; }
}