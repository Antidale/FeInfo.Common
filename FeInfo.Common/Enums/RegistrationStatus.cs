namespace FeInfo.Common.Enums
{
    public enum RegistrationStatus
    {
        None = 0,
        /// <summary>
        /// used in <see cref="Requests.ChangeRegistration"/> to indicated that the user wishes to register for a tournament
        /// </summary>
        Registered,
        /// <summary>
        /// used in <see cref="Requests.ChangeRegistration"/> to indicated that the user wishes to drop from the tournament
        /// </summary>
        Dropped
    }
}
