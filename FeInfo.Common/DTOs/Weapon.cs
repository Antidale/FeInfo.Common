namespace FeInfo.Common.DTOs
{
    /// <summary>
    /// Weapon specific information. <see cref="Equipment"/> for properties on the base class
    /// </summary>
    public class Weapon : Equipment
    {
        public int Attack { get; init; }
        public int Hit { get; init; }
        public string Casts { get; init; } = string.Empty;
        public string StatusInflicted { get; init; } = string.Empty;
        public bool Throwable { get; init; }
        public bool LongRange { get; init; }
        public bool TwoHanded { get; init; }
    }
}
