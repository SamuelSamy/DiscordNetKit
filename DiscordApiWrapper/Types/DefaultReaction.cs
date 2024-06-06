using Newtonsoft.Json;

namespace DiscordNetKit.Types;

public class DefaultReaction
{
    [JsonProperty("emoji_id")]
    public Snowflake EmojiId { get; set; }

    [JsonProperty("emoji_name")]
    public string EmojiName { get; set; }
}