namespace FeInfo.Common.Requests
{
    /// <summary>
    /// A request record containing the required information for creating a tournament
    /// </summary>
    /// <param name="GuildId">The discord server's Guild.Id</param>
    /// <param name="GuildName">The name of the discord server</param>
    /// <param name="TournamentName">The name of the tournament</param>
    /// <param name="TrackingChannelId">The Channel.Id of the channel to host the tracking message.</param>
    /// <param name="TrackingMessageId">The Message.Id of the message where the tracking information is</param>
    /// <param name="RegistrantRoleId">The Role.Id that registered players should get upon registration. Ignored if not set</param>
    /// <param name="RegistrationStart">The time registrations can start to be accepted. Can be changed later with a RegistrationPeriodChangeStatus request</param>
    /// <param name="RegistrationEnd">The time registration for the tournament closes. Can be changed later with a RegistrationPeriodChangeStatus request</param>
    public record CreateTournament(
        ulong GuildId,
        string GuildName,
        string TournamentName,
        ulong TrackingChannelId,
        ulong TrackingMessageId,
        ulong RegistrantRoleId,
        string? RulesLink,
        DateTimeOffset? RegistrationStart,
        DateTimeOffset? RegistrationEnd
    )
    { }
}
