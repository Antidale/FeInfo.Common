namespace FeInfo.Common.DTOs
{
    public class Registration
    {
        public required string PlayerName { get; init; }
        public required string TournamentName { get; init; }
        public string? PlayerAlias { get; init; }
        public string Pronouns { get; init; } = string.Empty;
        public DateTime RegisteredOnUtc { get; init; }
    }
}
