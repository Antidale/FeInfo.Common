namespace FeInfo.Common.DTOs
{
    /// <summary>
    /// Armor specific information. <see cref="Equipment"/> for properties on the base class
    /// </summary>
    public class Armor : Equipment
    {
        public int Defense { get; set; }
        public int MagicDefense { get; set; }
        public int Evade { get; set; }
        public int MagicEvade { get; set; }
        /// <summary>
        /// Includes both elemantal resists and status protection
        /// </summary>
        public IEnumerable<string> StatusProtected { get; set; } = Enumerable.Empty<string>();
    }
}
