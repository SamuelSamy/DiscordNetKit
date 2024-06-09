using DiscordNetKit.Constants;
using DiscordNetKit.Enums;
using DiscordNetKit.Types;
using DiscordNetKit.Types.DiscordObjects;
using DiscordNetKit.Types.DiscordObjects.Guilds;

namespace DiscordNetKit.Interfaces.HttpClients;

public interface IGuildHttpClient : IBaseHttpClient
{
    private const string Url = $"{ApiConstants.BaseUrl}/guilds";

    /// <summary>
    /// Get a guild by its id.
    /// </summary>
    /// <param name="snowflake"></param>
    /// <returns></returns>
    public async Task<Guild> GetGuildByIdAsync(Snowflake snowflake)
    {
        var url = $"{Url}/{snowflake}?with_counts=true";

        var route = new Route<IgnoredRouteType>(url, MethodType.GET);

        return await SendRequest<IgnoredRouteType, Guild>(route);
    }

    
    /// <summary>
    /// Get a guild preview by its id.
    /// </summary>
    /// <param name="snowflake"></param>
    /// <returns></returns>
    public async Task<GuildPreview> GetGuildPreviewByIdAsync(Snowflake snowflake)
    {
        var url = $"{Url}/{snowflake}/preview";

        var route = new Route<IgnoredRouteType>(url, MethodType.GET);

        return await SendRequest<IgnoredRouteType, GuildPreview>(route);
    }

    /// <summary>
    /// Get a list of channels in a guild.
    /// </summary>
    /// <param name="guildId"></param>
    /// <returns></returns>
    public async Task<List<Channel>> GetGuildChannelsAsync(Snowflake guildId)
    {
        var url = $"{Url}/{guildId}/channels";

        var route = new Route<IgnoredRouteType>(url, MethodType.GET);

        return await SendRequest<IgnoredRouteType, List<Channel>>(route);
    }


    /// <summary>
    /// Get a member in a guild.
    /// </summary>
    /// <param name="guildId"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    public async Task<Member> GetGuildMemberAsync(
        Snowflake guildId,
        Snowflake userId)
    {
        var url = $"{Url}/{guildId}/members/{userId}";

        var route = new Route<IgnoredRouteType>(url, MethodType.GET);

        return await SendRequest<IgnoredRouteType, Member>(route);
    }


    /// <summary>
    /// Get a list of members in a guild.
    /// </summary>
    /// <returns></returns>
    public async Task<List<Member>> GetGuildMembersAsync(
        Snowflake guildId,
        int limit = 1,
        Snowflake? after = null)
    {
        after ??= Snowflake.Zero;

        var url = $"{Url}/{guildId}/members?limit={limit}&after={after}";

        var route = new Route<IgnoredRouteType>(url, MethodType.GET);

        return await SendRequest<IgnoredRouteType, List<Member>>(route);
    }


    /// <summary>
    /// Gets a list of members whose usernames or nicknames start with the provided query
    /// </summary>
    /// <param name="query"></param>
    /// <param name="limit"></param>
    /// <returns></returns>
    public async Task<List<Member>> SearchGuildMemberAsync(
        Snowflake guildId,
        string query,
        int limit = 1)
    {
        var url = $"{Url}/{guildId}/members/search?query={query}&limit={limit}";

        var route = new Route<IgnoredRouteType>(url, MethodType.GET);

        return await SendRequest<IgnoredRouteType, List<Member>>(route);
    }


    /// <summary>
    /// Get a list of roles for a guild
    /// </summary>
    /// <param name="guildId"></param>
    /// <returns></returns>
    public async Task<List<Role>> GetGuildRolesAsync(Snowflake guildId)
    {
        var url = $"{Url}/{guildId}/roles";

        var route = new Route<IgnoredRouteType>(url, MethodType.GET);

        return await SendRequest<IgnoredRouteType, List<Role>>(route);
    }
}