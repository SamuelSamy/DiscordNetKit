using DiscordNetKit.Types;

namespace DiscordNetKit.Interfaces.HttpClients;

public interface IBaseHttpClient
{
    Task<T2> SendRequest<T1, T2>(Route<T1> route, StringDictionary? parameters = null)
        where T1 : class
        where T2 : class;
}