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
    public string UserAgent { get; set; }
    public Token Token { get; set; }

    private readonly RegularHttpClient _httpClient;


    public DiscordHttpClient(
        Token token,
        string userAgent = "")
    {
        Token = token;
        UserAgent = userAgent;
        _httpClient = new RegularHttpClient();


        if (UserAgent is not null && UserAgent != string.Empty)
        {
            _httpClient.DefaultRequestHeaders.Add("User-Agent", UserAgent);
        }

        _httpClient.DefaultRequestHeaders.Add("Host", "discord.com");

        if (Token.AccessToken is not null && Token.AccessToken != string.Empty)
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"{Token.TokenType} {Token.AccessToken}");
        }
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
        HttpResponseMessage result;

        try
        {
            result = await _httpClient.GetAsync(route.Url);
        }
        catch (Exception ex)
        {
            throw new DiscordException("Failed to execute GET request", ex);
        }

        if (result == null)
        {
            throw new DiscordException("HTTP request returned null response.");
        }

        if (!result.IsSuccessStatusCode)
        {
            var errorContent = await result.Content.ReadAsStringAsync();
            Console.WriteLine($"HTTP Error: {errorContent}");
            throw new DiscordException(errorContent ?? "API call failed", (int)result.StatusCode);
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
        foreach (var header in headers)
        {
            if (_httpClient.DefaultRequestHeaders.Contains(header.Key))
            {
                _httpClient.DefaultRequestHeaders.Remove(header.Key);
            }

            _httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
        }
    }
}