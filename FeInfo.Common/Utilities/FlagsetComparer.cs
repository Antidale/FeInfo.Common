using System.Text;

namespace FeInfo.Common.Utilities;

public static class FlagsetComparer
{
    public static bool Compare(string flagsetOne, string flagsetTwo, out List<string> discrepancies)
    {
        discrepancies = [];
        if (string.Equals(flagsetOne, flagsetTwo, StringComparison.InvariantCulture))
            return true;

        var oneTokens = flagsetOne.Split(' ');
        var twoTokens = flagsetTwo.Split(' ');
        if (oneTokens != twoTokens && ((oneTokens.Length == 1 && twoTokens.Length != 1) || (oneTokens.Length != 1 && twoTokens.Length == 1)))
        {
            discrepancies.Add("Cannot compare full flagstring and an encoded representation");
            return false;
        }

        if (oneTokens.Length == 1)
        {
            var encodedDiff = flagsetOne.Length <= flagsetTwo.Length
                ? GetEncodedDiff(flagsetOne, flagsetTwo)
                : GetEncodedDiff(flagsetTwo, flagsetOne);

            discrepancies.Add(encodedDiff);
        }

        return false;
    }

    private static string GetEncodedDiff(string shorter, string longer)
    {
        var builder = new StringBuilder();
        //Need to have access to the iterator after the loop concludes to 
        var i = 0;
        for (; i < shorter.Length; i++)
        {
            if (!Equals(shorter[i], longer[i]))
            {
                builder.Append(longer[i]);
            }
            else
            {
                builder.Append(' ');
            }
        }

        longer.Skip(i)?.ToList().ForEach(x => builder.Append(x));


        return builder.ToString();
    }
}
