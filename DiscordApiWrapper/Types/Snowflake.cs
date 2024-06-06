namespace DiscordNetKit.Types;

public class Snowflake
{
    public ulong Value { get; set; }

    #region Constructors
    public Snowflake(ulong value)
    {
        Value = value;
    }

    public Snowflake(string value)
    {
        Value = ulong.Parse(value);
    }

    public Snowflake()
    {
        Value = 0;
    }

    #endregion

    #region Operators

    /// <summary>
    /// Implicitly converts a Snowflake to a ulong
    /// </summary>
    /// <param name="snowflake"></param>
    public static implicit operator ulong(Snowflake snowflake)
    {
        return snowflake.Value;
    }


    /// <summary>
    /// Implicitly converts a ulong to a Snowflake
    /// </summary>
    /// <param name="value"></param>
    public static implicit operator Snowflake(ulong value)
    {
        return new Snowflake(value);
    }


    /// <summary>
    /// Implicitly converts a Snowflake to a string
    /// </summary>
    /// <param name="snowflake"></param>
    public static implicit operator string(Snowflake snowflake)
    {
        return snowflake.Value.ToString();
    }


    /// <summary>
    /// Implicitly converts a string to a Snowflake
    /// </summary>
    /// <param name="value"></param>
    public static implicit operator Snowflake(string value)
    {
        return new Snowflake(value);
    }


    /// <summary>
    /// Compares two Snowflakes
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static bool operator ==(Snowflake a, Snowflake b)
    {
        return a.Value == b.Value;
    }

    /// <summary>
    /// Compares two Snowflakes
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static bool operator !=(Snowflake a, Snowflake b)
    {
        return a.Value != b.Value;
    }

    /// <summary>
    /// Compares an object to a Snowflake
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object obj)
    {
        if (obj is Snowflake snowflake)
        {
            return Value == snowflake.Value;
        }

        return false;
    }

    /// <summary>
    /// Gets the hash code of the Snowflake
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(Value);
    }

    /// <summary>
    /// Returns the string representation of the Snowflake
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return Value.ToString();
    }

    #endregion

    #region Methods

    /// <summary>
    /// Gets the timestamp of the Snowflake
    /// </summary>
    /// <returns></returns>
    public ulong GetTimestamp()
    {
        return (Value >> 22) + 1420070400000;
    }

    #endregion

    #region Static Methods

    public static Snowflake Zero { get => new Snowflake(0); }

    #endregion
}