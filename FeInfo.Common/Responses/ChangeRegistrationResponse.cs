namespace FeInfo.Common.Responses
{
    /// <summary>
    ///     <para>The response to either a <see cref="Requests.ChangeRegistration"/> or a <see cref="Requests.DropPlayer" request/>.</para>
    ///     <para>Proivdes the data required perform follow-on actions in the calling application</para>
    /// </summary>
    /// <param name="RegistrantCount">The nummber of registered players after processing the request</param>
    /// <param name="TrackingChannelId">The Id of the channel the tracking/announcement message is posted</param>
    /// <param name="TrackingMessageId">The Id of the tracking/announcement message</param>
    /// <param name="TournamentRoleId">The role that should be applied to/removed from the user</param>
    /// <param name="UserId">The ID of the user who has a changed registration status</param>
    /// <param name="TournamentName">The name of the tournament</param>
    public record ChangeRegistrationResponse(
        int RegistrantCount,
        ulong TrackingChannelId,
        ulong TrackingMessageId,
        ulong TournamentRoleId,
        ulong UserId,
        string TournamentName
    )
    { }
}
