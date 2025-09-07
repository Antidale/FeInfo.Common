namespace FeInfo.Common.DTOs;

public record class BossStrategy(string Name, string Thumbnail, string WikiUrl, string FightFlow, string Strats, string AdditionalInfo, Dictionary<string, string> Fields)
{

}
