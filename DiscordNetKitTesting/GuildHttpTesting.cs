using DiscordNetKit.HttpClients;
using DiscordNetKit.Interfaces.HttpClients;
using DiscordNetKit.Types;

namespace DiscordNetKitTesting;

public class GuildHttpTesting
{
    private readonly IHttpClient _httpClient;
    private readonly Token _token;

    private const ulong _guildId = 1235148975225438219UL;
    private const ulong _botId = 1235144454797529130UL;

    public GuildHttpTesting()
    {
        _token = new Token
        {
            AccessToken = TokenConstants.BotToken,
            TokenType = "Bot"
        };

        _httpClient = new DiscordHttpClient(_token);
    }

    [Fact]
    public async Task GetRoles()
    {
        var roles = await _httpClient.GetGuildRolesAsync(_guildId);

        Assert.NotNull(roles);
        Assert.Equal(2, roles.Count);
    }

    [Fact]
    public async Task GetChannels()
    {
        var channels = await _httpClient.GetGuildChannelsAsync(_guildId);

        Assert.NotNull(channels);
        Assert.Equal(1, channels.Count);
    }


    [Fact]
    public async Task GetGuildPreviewTest()
    {
        var guildPreview = await _httpClient.GetGuildPreviewByIdAsync(_guildId);

        Assert.NotNull(guildPreview);
        Assert.Equal(guildPreview.ApproximateMemberCount, 2UL);
        Assert.Null(guildPreview.Description);
        Assert.Equal(guildPreview.Emojis.Count, 0);
        Assert.Equal(guildPreview.Features.Count, 0);
        Assert.Null(guildPreview.Icon);
    }

    [Fact]
    public async Task GetGuildMemberTest()
    {
        var member = await _httpClient.GetGuildMemberAsync(_guildId, _botId);

        Assert.NotNull(member);
        Assert.Equal(member.User.Id, new Snowflake(_botId));
        Assert.Equal(member.User.Username, "CSharp-Nuggest-Testing");
        Assert.Equal(member.User.Discriminator, "1369");
        Assert.Equal(member.User.Bot, true);
    }

    [Fact]
    public async Task GetGuildMembersTest()
    {
        var members = await _httpClient.GetGuildMembersAsync(_guildId, 2);

        Assert.NotNull(members);
        Assert.Equal(members.Count, 2);
    }

    [Fact]
    public async Task SearchGuildMemberTest()
    {
        var members = await _httpClient.SearchGuildMemberAsync(_guildId, "CSharp-Nuggest-Testing");

        Assert.NotNull(members);
        Assert.Equal(members.Count, 1);

        var member = members[0];

        Assert.Equal(member.User.Id, new Snowflake(_botId));
        Assert.Equal(member.User.Username, "CSharp-Nuggest-Testing");
    }


    [Fact]
    public async Task GetGuildTest()
    {
        var guild = await _httpClient.GetGuildByIdAsync(_guildId);

        Assert.NotNull(guild);
        Assert.Equal(guild.Id, new Snowflake(_guildId));
        Assert.Equal(guild.Name, "CSharp-Nugget-Testing");
    }
}
