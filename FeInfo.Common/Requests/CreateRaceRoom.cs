namespace FeInfo.Common.Requests;

public record CreateRaceRoom(string UserId, string RoomName, string RaceType, string RaceHost, Dictionary<string, string> Metadata)
{

}
