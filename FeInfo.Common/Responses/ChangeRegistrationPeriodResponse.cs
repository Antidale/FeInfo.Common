using FeInfo.Common.Enums;

namespace FeInfo.Common.Responses
{
    /// <summary>
    /// Used in the reponse to a caller making a <see cref="Requests.ChangeRegistrationPeriod"/> and provides details to update the tracking message
    /// </summary>
    /// <param name="TrackingChannelId"></param>
    /// <param name="TrackingMessageId"></param>
    /// <param name="RegistrationPeriodStatus"></param>
    public record ChangeRegistrationPeriodResponse(
        ulong TrackingChannelId, 
        ulong TrackingMessageId, 
        RegistrationPeriodStatus RegistrationPeriodStatus
    ) 
    { 
        /// <summary>
        /// Helper method to create a default instance, mostly useful for returning something with an error
        /// </summary>
        /// <returns></returns>
        public static ChangeRegistrationPeriodResponse GetDefault()
        {
            return new ChangeRegistrationPeriodResponse(0, 0, RegistrationPeriodStatus.Announced);
        }
    }
}
