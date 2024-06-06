using DiscordNetKit.Enums;

namespace DiscordNetKit.Types;

public class Overwrite
{
    public Snowflake Id { get; set; }

    public OverwriteType Type { get; set; }

    public Permissions Allow { get; set; }

    public Permissions Deny { get; set; }
}