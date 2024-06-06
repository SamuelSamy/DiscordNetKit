using System.Numerics;

namespace DiscordNetKit.Types;

public class Permissions
{
    public BigInteger Value { get; set; }


    #region Constructors

    public Permissions(BigInteger value)
    {
        Value = value;
    }

    public Permissions()
    {
        Value = 0;
    }

    public Permissions(string value)
    {
        Value = BigInteger.Parse(value);
    }

    #endregion


    #region Operators

    public static implicit operator BigInteger(Permissions permission)
    {
        return permission.Value;
    }

    public static implicit operator Permissions(BigInteger value)
    {
        return new Permissions(value);
    }

    public static implicit operator string(Permissions permission)
    {
        return permission.Value.ToString();
    }

    public static implicit operator Permissions(string value)
    {
        return new Permissions(ulong.Parse(value));
    }

    #endregion

    public void Grant(BigInteger permission)
    {
        Value |= permission;
    }


    public void Revoke(BigInteger permission)
    {
        Value &= ~permission;
    }


    public bool Has(BigInteger permission)
    {
        return (Value & permission) == permission;
    }


    public bool HasAny(BigInteger permission)
    {
        return (Value & permission) != 0;
    }


    public bool HasAll(BigInteger permission)
    {
        return (Value & permission) == permission;
    }


    public void GrantAll()
    {
        Value = ~0UL;
    }

    public void RevokeAll()
    {
        Value = 0;
    }
}