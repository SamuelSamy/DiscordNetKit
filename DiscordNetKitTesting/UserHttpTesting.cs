using DiscordNetKit.HttpClients;
using DiscordNetKit.Interfaces.HttpClients;
using DiscordNetKit.Types;

namespace DiscordNetKitTesting;

public class UserHttpTesting
{
    private readonly IHttpClient _httpClient;
    private readonly IHttpClient _userHttpClient;

    private const ulong _guildId = 1235148975225438219UL;
    private const ulong _botId = 1235144454797529130UL;
    private const ulong _userId = 225629057172111362UL;

    public UserHttpTesting()
    {
        _httpClient = new DiscordHttpClient(new Token
        {
            AccessToken = TokenConstants.BotToken,
            TokenType = "Bot"
        });

        _userHttpClient = new DiscordHttpClient(new Token
        {
            AccessToken = TokenConstants.UserToken,
            TokenType = "Bearer"
        });
    }

    [Fact]
    public async Task GetCurrentUserAsync()
    {
        // Act
        var user = await _httpClient.GetCurrentUserAsync();

        // Assert
        Assert.NotNull(user);
        Assert.Equal(_botId, (ulong)user.Id);
        Assert.Equal("CSharp-Nuggest-Testing", user.Username);
        Assert.Equal("1369", user.Discriminator);
        Assert.Equal(true, user.Bot);
        Assert.Null(user.System);
        Assert.Equal(true, user.MfaEnabled);
    }


    [Fact]
    public async Task GetCurrentUserGuildsAsync()
    {
        // Act
        var guilds = await _httpClient.GetCurrentUserGuildsAsync();

        // Assert
        Assert.NotNull(guilds);
        Assert.Equal(1, guilds.Count);

        var guild = guilds[0];

        Assert.Equal(_guildId, (ulong)guild.Id);
        Assert.Equal("CSharp-Nugget-Testing", guild.Name);
    }


    [Fact]
    public async Task GetCurrentUserGuildMemberAsync()
    {
    }


    [Fact]
    public async Task GetUserAsync()
    {
        // Act
        var user = await _httpClient.GetUserAsync(_botId);

        // Assert
        Assert.NotNull(user);
        Assert.Equal(_botId, (ulong)user.Id);
        Assert.Equal("CSharp-Nuggest-Testing", user.Username);
        Assert.Equal("1369", user.Discriminator);
        Assert.Equal(true, user.Bot);
        Assert.Null(user.System);
    }

    [Fact]
    public async Task GetGuildMemberAsync()
    {
        // Act
        var member = await _userHttpClient.GetCurrentUserGuildMemberAsync(_guildId);

        // Assert
        Assert.NotNull(member);
        Assert.Equal("greaterTEST", member.Nick);
        Assert.Null(member.Banner);
        Assert.Equal(member.User.Username, "greater");
        Assert.Equal((ulong)member.User.Id, _userId);
    }
}