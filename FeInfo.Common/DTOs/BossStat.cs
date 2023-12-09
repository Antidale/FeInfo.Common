namespace FeInfo.Common.DTOs
{
    public class BossStat
    {
        public int Id { get; init; }
        public string Location { get; init; } = string.Empty;
        public string Battle { get; init; } = string.Empty;
        public string Enemy { get; init; } = string.Empty;
        public int Level { get; init; }
        public int HitPoints { get; init; }
        public int ExperiencePoints { get; init; }
        public int Gil { get; init; }
        public int AttackMultiplier { get; init; }
        public int AttackPercent { get; init; }
        public int AttackPower { get; init; }
        public int DefenseMultiplier { get; init; }
        public int Evade { get; init; }
        public int Defense { get; init; }
        public int MagicDefenseMultiplier { get; init; }
        public int MagicDefense { get; init; }
        public int MagicEvade { get; init; }
        public int MinSpeed { get; init; }
        public int MaxSpeed { get; init; }
        public int SpellPower { get; init; }
        public List<string> Notes { get; init; } = [];
    }
}
