using FeInfo.Common.Enums;

namespace FeInfo.Common.DTOs
{
    public class Guide
    {
        public int Id { get; init; }
        public string Title { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public string Tags { get; init; } = string.Empty;
        public string Url { get; init; } = string.Empty;
        public LinkType LinkType { get; init; }
        public decimal Rank { get; init;} = decimal.Zero;
    }
}
