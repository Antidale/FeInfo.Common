namespace FeInfo.Common.Requests;

public record UpdateAlias(ulong UserId, string Alias, string TournamentName = "")
{

}
