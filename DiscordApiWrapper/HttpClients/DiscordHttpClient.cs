using DiscordNetKit.Enums;
using DiscordNetKit.Errors;
using DiscordNetKit.Interfaces.HttpClients;
using DiscordNetKit.Types;
using Newtonsoft.Json;
using RegularHttpClient = System.Net.Http.HttpClient;

namespace DiscordNetKit.HttpClients;

// Create a function "SetToken" or something and do not give the token in the constructor

public class DiscordHttpClient : IHttpClient
{
    public Token Token { get; set; }

    private readonly RegularHttpClient _httpClient;


    public DiscordHttpClient(Token token)
    {
        Token = token;
        _httpClient = new RegularHttpClient();
    }


    /// <summary>
    /// Send a request to the Discord API.
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <param name="route"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<T2> SendRequest<T1, T2>(Route<T1> route, StringDictionary? parameters = null) 
        where T1 : class
        where T2 : class
    {
        route.Headers ??= new StringDictionary();

        route.Headers.Add("Authorization", $"{Token.TokenType} {Token.AccessToken}");

        ClearAndAppendHeaders(route.Headers);

        return route.Method switch
        {
            MethodType.GET => await GetRequest<T1, T2>(route, parameters),
            MethodType.POST => await PostRequest<T1, T2>(route, parameters),
            MethodType.PUT => await PutRequest<T1, T2>(route, parameters),
            MethodType.DELETE => await DeleteRequest<T1, T2>(route, parameters),
            _ => throw new NotImplementedException(),
        };
    }

    /// <summary>
    /// Send a GET request to the Discord API.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="route"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    /// <exception cref="DiscordException"></exception>
    private async Task<T2> GetRequest<T1, T2>(Route<T1> route, StringDictionary? parameters = null)
        where T1 : class
        where T2 : class
    {
        var result  = await _httpClient.GetAsync(route.Url);

        if (!result.IsSuccessStatusCode)
        {
            throw new DiscordException(await result.Content.ReadAsStringAsync() ?? "API call failed", (int)result.StatusCode);
        }

        var content = await result.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<T2>(content) ?? throw new DiscordException("Failed to deserialize response");
    }


    /// <summary>
    /// Send a POST request to the Discord API.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="route"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    /// <exception cref="DiscordException"></exception>
    private async Task<T2> PostRequest<T1, T2>(Route<T1> route, StringDictionary? parameters = null)
        where T1 : class
        where T2 : class
    {
        var result = await _httpClient.PostAsync(route.Url, new StringContent(JsonConvert.SerializeObject(route.Data)));

        if (!result.IsSuccessStatusCode)
        {
            throw new DiscordException(result.ReasonPhrase ?? "API call failed", (int)result.StatusCode);
        }

        var content = await result.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<T2>(content) ?? throw new DiscordException("Failed to deserialize response");
    }

    /// <summary>
    /// Send a PUT request to the Discord API.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="route"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    /// <exception cref="DiscordException"></exception>
    private async Task<T2> PutRequest<T1, T2>(Route<T1> route, StringDictionary? parameters = null)
        where T1 : class
        where T2 : class
    {
        var result = await _httpClient.PutAsync(route.Url, new StringContent(JsonConvert.SerializeObject(route.Data)));

        if (!result.IsSuccessStatusCode)
        {
            throw new DiscordException(result.ReasonPhrase ?? "API call failed", (int)result.StatusCode);
        }

        var content = await result.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<T2>(content) ?? throw new DiscordException("Failed to deserialize response");
    }


    /// <summary>
    /// Send a DELETE request to the Discord API.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="route"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    /// <exception cref="DiscordException"></exception>
    private async Task<T2> DeleteRequest<T1, T2>(Route<T1> route, StringDictionary? parameters = null)
        where T1 : class
        where T2 : class
    {
        var result = await _httpClient.DeleteAsync(route.Url);

        if (!result.IsSuccessStatusCode)
        {
            throw new DiscordException(result.ReasonPhrase ?? "API call failed", (int)result.StatusCode);
        }

        var content = await result.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<T2>(content) ?? throw new DiscordException("Failed to deserialize response");
    }


    /// <summary>
    /// Clear the headers and append the given headers.
    /// </summary>
    /// <param name="headers"></param>
    private void ClearAndAppendHeaders(StringDictionary headers)
    {
        _httpClient.DefaultRequestHeaders.Clear();

        foreach (var header in headers)
        {
            Console.WriteLine(header);
            _httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
        }
    }
}