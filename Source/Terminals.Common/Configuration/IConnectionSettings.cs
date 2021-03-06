using Terminals.Common.Configuration;

namespace Terminals.Configuration
{
    public interface IConnectionSettings
    {
        bool AskToReconnect { get; set; }

        KeysSection SSHKeys { get; }
    }
}