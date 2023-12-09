namespace FeInfo.Common.DTOs
{
    /// <summary>
    /// a Record containing a simple Id and Name pairing. Generally used for populating dropdowns
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="Name"></param>
    public record NameWithId(int Id, string Name) { }
}
