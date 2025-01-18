namespace FeInfo.Common.Requests;

public record DropPlayer
(
    string PlayerName,
    string TournamentName,
    ulong GuildId
)
{ }
