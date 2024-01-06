namespace FeInfo.Common.Requests
{
    public record CreateGuide(
        string Title,
        string Description,
        string Tags,
        string Url,
        string LinkType
    )
    { }
}
