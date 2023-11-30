using FeInfo.Common.Emums;

namespace FeInfo.Common.Responses
{
    public record RegistrationPeriodChangeResponse(
        ulong TrackingChannelId, 
        ulong TrackingMessageId, 
        RegistrationPeriodStatus RegistrationPeriodStatus
    ) 
    { 
        public static RegistrationPeriodChangeResponse GetDefault()
        {
            return new RegistrationPeriodChangeResponse(0, 0, RegistrationPeriodStatus.Announced);
        }
    }
}
