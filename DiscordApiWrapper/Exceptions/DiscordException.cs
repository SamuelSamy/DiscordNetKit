namespace DiscordNetKit.Errors;

public class DiscordException : Exception
{
    public int Code { get; set; }

    public DiscordException()
    {
    }

    public DiscordException(string message) : base(message)
    {
    }

    public DiscordException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public DiscordException(string message, int code) : base(message)
    {
        Code = code;
    }
}