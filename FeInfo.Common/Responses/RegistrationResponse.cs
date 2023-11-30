namespace FeInfo.Common.Responses
{
    public record RegistrationResponse(
        int RegistrantCount, 
        ulong TrackingChannelId, 
        ulong TrackingMessageId, 
        ulong TournamentRoleId
    ) { }
}
