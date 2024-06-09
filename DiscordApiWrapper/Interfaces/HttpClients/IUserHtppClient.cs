using DiscordNetKit.Constants;
using DiscordNetKit.Enums;
using DiscordNetKit.Interfaces.Types;
using DiscordNetKit.Types;
using DiscordNetKit.Types.DiscordObjects;
using DiscordNetKit.Types.DiscordObjects.Guilds;

namespace DiscordNetKit.Interfaces.HttpClients;

public interface IUserHtppClient : IBaseHttpClient
{
    private const string Url = $"{ApiConstants.BaseUrl}/users";

    /// <summary>
    /// Get the user object of the requester's account.
    /// </summary>
    /// <returns></returns>
    public async Task<IUser> GetCurrentUserAsync()
    {
        var url = $"{Url}/@me"; 

        var route = new Route<IgnoredRouteType>(url, MethodType.GET);

        return await SendRequest<IgnoredRouteType, User>(route);
    }

    /// <summary>
    /// Gets the guilds the current user is in.
    /// </summary>
    /// <returns></returns>
    public async Task<IList<UserGuildPartial>> GetCurrentUserGuildsAsync()
    {
        var url = $"{Url}/@me/guilds";

        var route = new Route<IgnoredRouteType>(url, MethodType.GET);

        return await SendRequest<IgnoredRouteType, IList<UserGuildPartial>>(route);
    }


    /// <summary>
    /// Gets a member object for the current user in a guild.
    /// </summary>
    /// <returns></returns>
    public async Task<Member> GetCurrentUserGuildMemberAsync(Snowflake guildId)
    {
        var url = $"{Url}/@me/guilds/{guildId}/member";

        var route = new Route<IgnoredRouteType>(url, MethodType.GET);

        return await SendRequest<IgnoredRouteType, Member>(route);
    }


    /// <summary>
    /// Get a user object for a given user ID.
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public async Task<User> GetUserAsync(Snowflake userId)
    {
        var url = $"{Url}/{userId}";

        var route = new Route<IgnoredRouteType>(url, MethodType.GET);

        return await SendRequest<IgnoredRouteType, User>(route);
    }
}