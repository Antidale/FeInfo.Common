namespace FeInfo.Common.DTOs;

public record RaceEntrant
{
    public string Name { get; set; } = string.Empty;
    public string TwitchName { get; set; } = string.Empty;
    public string RacetimeId { get; set; } = string.Empty;
    public TimeSpan? FinishTime { get; set; }
    public int? Placement { get; set; }
    /// <summary>
    /// A colleciton of key/value pairs, both stored as strings. Always should contain the following keys: comment, score, scoreChange. Other keys, like status, may be present depending on other factors
    /// </summary>
    public Dictionary<string, string> EntrantMetadata { get; set; } = [];
}
