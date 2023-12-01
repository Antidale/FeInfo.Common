namespace FeInfo.Common.Responses
{
    /// <summary>
    ///     <para>The response to a <see cref="Requests.ChangeRegistration"/> request.</para>
    ///     <para>Proivdes the data required perform follow-on actions in the calling application</para>
    /// </summary>
    /// <param name="RegistrantCount">The nummber of currently registered particpants</param>
    /// <param name="TrackingChannelId"></param>
    /// <param name="TrackingMessageId"></param>
    /// <param name="TournamentRoleId">The role that should be</param>
    public record ChangeRegistrationResponse(
        int RegistrantCount, 
        ulong TrackingChannelId, 
        ulong TrackingMessageId, 
        ulong TournamentRoleId
    ) { }
}
