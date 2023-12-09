namespace FeInfo.Common.Enums
{
    public enum RegistrationPeriodStatus
    {
        /// <summary>
        /// Indicates a tournament has been created, but is not open for any registration yet.
        /// </summary>
        Announced = 0,
        /// <summary>
        /// Players can register for a tournament when it is in this status.
        /// </summary>
        Opened = 1,
        /// <summary>
        /// The tournament is closed to new registrations, and will not re-open.
        /// </summary>
        Closed = 2,
    }
}
