using System;

namespace FeInfo.Common.Requests;

public record UpdatePronouns(ulong UserId, string Pronouns)
{
}
