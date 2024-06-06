using DiscordNetKit.Types;

namespace DiscordNetKit.Interfaces.HttpClients;

public interface IHttpClient : 
    IBaseHttpClient,
    IUserHtppClient,
    IGuildHttpClient
{
    Token Token { get; }
}