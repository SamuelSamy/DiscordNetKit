using DiscordNetKit.Interfaces.Types.Guilds;

namespace DiscordNetKit.Interfaces.Clients;

// This needs a constructor or something.
// When you create a Client, you should pass a token that will be used to authenticate the client.

public interface IClient
{
    #region Methods

    public IList<IGuild> GetGuilds();

    #endregion
}