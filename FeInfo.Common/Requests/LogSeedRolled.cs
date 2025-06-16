using FeInfo.Common.DTOs;

namespace FeInfo.Common.Requests;

/// <summary>
/// DTO for logging seeds that are rolled via bots.
/// </summary>
/// <param name="UserId">The discord userId of the person creating the race. If the Racingway bot is the intermediary, use that bot's id</param>
/// <param name="Info">The SeedInformation that comes back with a get call to a seed generation site</param>
/// <param name="RaceId">The Id of a race from this database</param>
/// <param name="RaceName">If the bot doesn't have an Id, it can try to substitute a race name (rt.gg room or discord channel name) to look up the Id</param>
public record LogSeedRoled(ulong UserId, SeedInformation Info, int? RaceId = null, string? RaceName = null)
{

}
