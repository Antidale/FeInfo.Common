namespace FeInfo.Common.DTOs;

public record RaceDetail
{
    public int RaceId { get; init; }
    public string RoomName { get; init; } = string.Empty;
    public string RaceType { get; init; } = string.Empty;
    public string RaceHost { get; init; } = string.Empty;
    public string Flagset { get; init; } = string.Empty;
    public DateTimeOffset? EndedAt { get; init; }
    public int? SeedId { get; init; }
    public List<RaceEntrant> Entrants { get; set; } = [];
    public Dictionary<string, string> Metadata { get; init; } = [];
}
