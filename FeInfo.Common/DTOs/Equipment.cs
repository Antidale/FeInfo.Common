namespace FeInfo.Common.DTOs
{
    /// <summary>
    /// Base class for both <see cref="Armor"/> and <see cref="Equipment"/>
    /// </summary>
    public class Equipment
    {
        public int Id { get; init; }
        public required string Name { get; init; }
        public required string EquipmentType { get; init; }
        public required string Category { get; init; } = string.Empty;
        public IEnumerable<string> CanEquip { get; init; } = Enumerable.Empty<string>();
        public bool Magnetic { get; init; }
        /// <summary>
        /// Refers to hitting a racial weakness or getting proction from a race. Entries are comma separated
        /// </summary>
        public string StrongAgainst { get; init; } = string.Empty;
        public int Str { get; init; }
        public int Agi { get; init; }
        public int Vit { get; init; }
        public int Wis { get; init; }
        public int Wil { get; init; }
        public string Icon { get; init; } = string.Empty;
        public string Notes { get; init; } = string.Empty;
        public string Tier { get; init; } = string.Empty;
        public int Price { get; init; }
    }
}
