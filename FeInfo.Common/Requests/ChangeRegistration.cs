using FeInfo.Common.Emums;

namespace FeInfo.Common.Requests
{
    /// <summary>
    /// Record for changing the registration status of a player.
    /// </summary>
    /// <param name="UserId"></param>
    /// <param name="UserName"></param>
    /// <param name="GuildId">The id of the guild (server) where the tournament is being hosted</param>
    /// <param name="TournamentName">Used to disambiguate when there are multiple tournaments you could be registering for</param>
    /// <param name="Alias">Used to allow players to specify a name on any restreams. Not used when dropping from a tournament</param>
    /// <param name="Pronouns">
    ///     <para>Used to allow players to indicate their preferred pronouns for restreams.</para>
    ///     <para>If left blank, Tournament Organizes might also refer to any pronouns added to a users discord profile</para>
    ///     <para>Not used when dropping from a tournament</para>
    /// </param>
    public record ChangeRegistration(
        ulong UserId,  
        string UserName, 
        ulong GuildId, 
        string TournamentName = "",
        string Alias = "",
        string Pronouns = "",
        RegistrationStatus DesiredStatus = RegistrationStatus.Registered)
    { }
}
