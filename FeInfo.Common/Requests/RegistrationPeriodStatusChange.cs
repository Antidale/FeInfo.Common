using FeInfo.Common.Emums;

namespace FeInfo.Common.Requests
{
    /// <summary>
    /// <para>Record containing required information for Opening or Closing the registration period of a tournament manually</para>
    /// <para>Resistration cannot be re-opened once it is closed</para>
    /// </summary>
    /// <param name="GuildId">The guild (discord server) hosting the tourament</param>
    /// <param name="TournamentName">The name of the tournament</param>
    /// <param name="NewStatus">The new status for the registration period. Can change from Announced => Open => Closed.</param>
    public record RegistrationPeriodStatusChange(
        ulong GuildId, 
        string TournamentName, 
        RegistrationPeriodStatus NewStatus
    ) {}
}
