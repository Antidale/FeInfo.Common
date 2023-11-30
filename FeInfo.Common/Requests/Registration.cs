namespace FeInfo.Common.Requests
{
    public record Registration(
        ulong UserId,  
        string UserName, 
        ulong GuildId, 
        string TournamentName = "",
        string Alias = "",
        string Pronouns = "")
    {
    }
}
