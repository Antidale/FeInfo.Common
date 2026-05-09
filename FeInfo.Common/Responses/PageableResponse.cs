
namespace FeInfo.Common.Responses;

public record PageableResponse<T>(T Data, int TotalRecordCount, int CurrentPage, int PageSize)
{
}
