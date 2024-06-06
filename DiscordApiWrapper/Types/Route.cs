using DiscordNetKit.Enums;

namespace DiscordNetKit.Types;

public class Route<T> where T : class
{
    public string Url { get; set; }
    public MethodType Method { get; set; }
    public StringDictionary Headers { get; set; }
    public T? Data { get; set; } = null;

    public Route(
        string url, 
        MethodType method,
        StringDictionary? headers = null,
        T? data = null)
    {
        Url = url;
        Method = method;
        Headers = headers ?? new StringDictionary();
        Data = data;
    }
}

public class IgnoredRouteType
{

}