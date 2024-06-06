using System.Collections;

namespace DiscordNetKit.Types;

public class StringDictionary : IEnumerable
{
    #region Properties
    private readonly Dictionary<string, string> _headers = new Dictionary<string, string>();

    public string this[string key]
    {
        get => _headers[key];
        set => _headers[key] = value;
    }

    public int Count => _headers.Count;

    public ICollection<string> Keys => _headers.Keys;

    public ICollection<string> Values => _headers.Values;

    #endregion

    #region Constructors

    public StringDictionary()
    {

    }

    public StringDictionary(Dictionary<string, string> headers)
    {
        _headers = headers;
    }

    public StringDictionary(string key, string value)
    {
        _headers.Add(key, value);
    }

    #endregion


    #region Dictionary Methods

    public void Add(string key, string value)
    {
        _headers.Add(key, value);
    }

    public void Remove(string key)
    {
        _headers.Remove(key);
    }

    public bool ContainsKey(string key)
    {
        return _headers.ContainsKey(key);
    }

    public bool ContainsValue(string value)
    {
        return _headers.ContainsValue(value);
    }

    public void Clear()
    {
        _headers.Clear();
    }

    public Dictionary<string, string>.Enumerator GetEnumerator()
    {
        return _headers.GetEnumerator();
    }

    #endregion

    public Dictionary<string, string> ToDictionary()
    {
        return _headers;
    }

    public override string ToString()
    {
        return string.Join("\n", _headers.Select(x => $"{x.Key}: {x.Value}"));
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    #region Operators

    public static implicit operator StringDictionary(Dictionary<string, string> headers)
    {
        return new StringDictionary(headers);
    }

    public static implicit operator Dictionary<string, string>(StringDictionary headers)
    {
        return headers._headers;
    }

    #endregion
}