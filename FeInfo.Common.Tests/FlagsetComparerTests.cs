namespace FeInfo.Common.Tests;

using FeInfo.Common.Utilities;

public class UnitTest1
{
    [Theory]
    //binary example
    [InlineData("bBAYDAADwqwEAAAAAUBIBAAAAAAA3AACwAEFOygFAAAAAAAQAkAEADBCAAAgAAAKQAAQAAACeUBik", "bBAYDAADwqwEAAAAAUBIBAAAAAAA3AACwAEFOygFAAAAAAAQAkAEADBCAAAgAAAKQAAQAAACeUBik")]
    //full flagset example
    [InlineData("OA1:collect_ki10/2:quest_forge/do_all:crystal Kmain/miab:above/char Pkey Cstandard/nofree/start:edge/j:abilities Twildish Sstandard Bstandard/alt:gauntlet/whyburn Etoggle Glife/sylph/backrow Qmsgspeedfix -kit:better -spoon -smith:super", "OA1:collect_ki10/2:quest_forge/do_all:crystal Kmain/miab:above/char Pkey Cstandard/nofree/start:edge/j:abilities Twildish Sstandard Bstandard/alt:gauntlet/whyburn Etoggle Glife/sylph/backrow Qmsgspeedfix -kit:better -spoon -smith:super")]
    public void StrictlyEqualFlagstrings_Return_EmptyArray(string flagsetOne, string flagsetTwo)
    {
        var result = FlagsetComparer.Compare(flagsetOne, flagsetTwo, out var discrepancies);

        Assert.True(result);
        Assert.Empty(discrepancies);
    }

    [Fact]
    public void MixingFlagstringTypes_Returns_FalseAndSingleDiscrepancy()
    {
        //These are actually the same flagset for 4.6, but it is beyond the scope of this to decode the encoded flagset and compare with the flag string
        var encodedFlagstring = "bBAYA";
        var flagString = "Onone Kvanilla Pnone Cvanilla Tvanilla Svanilla Bvanilla Evanilla Gnone";
        var result = FlagsetComparer.Compare(encodedFlagstring, flagString, out var discrepancies);

        Assert.False(result);
        Assert.Single(discrepancies);
    }

    [Theory]
    [InlineData(
        "bBAYDAADwqwEAAAAAUBIBAAAAAAA3AACwAEFOygFAAAAAAAQAkAEADBCAAAgAAAKQAAQAAACeUBik", "bBAYDAADwqwEAAAAAUBIBAAAAAAA3AACwAEFOygFAAAAAAAQAkAEADBCAAAgAAAKQAAQAAACeUBiK",
        "                                                                            K")]
    [InlineData("12345", "1", " 2345")]
    [InlineData("1", "12345", " 2345")]
    [InlineData("111A111", "111a111", "   a   ")]
    public void EncodedFlags_List_DifferentValues(string flagsetOne, string flagsetTwo, string expectedDiff)
    {
        var result = FlagsetComparer.Compare(flagsetOne, flagsetTwo, out var discrepancies);

        Assert.False(result);
        Assert.Single(discrepancies);
        Assert.Equal(expectedDiff, discrepancies.First());
    }

    [Theory]
    //full flagset slight rearrange example
    [InlineData(
        "OA1:collect_ki10/2:quest_forge/do_all:crystal Kmain/miab:above/char Pkey Cstandard/nofree/start:edge/j:abilities Twildish Sstandard Bstandard/alt:gauntlet/whyburn Etoggle Glife/sylph/backrow Qmsgspeedfix -kit:better -spoon -smith:super",
        "OA1:collect_ki10/2:quest_forge/do_all:crystal Kmain/miab:above/char Pkey Cstandard/nofree/start:edge/j:abilities Twildish Sstandard Bstandard/alt:gauntlet/whyburn Etoggle Glife/sylph/backrow Qmsgspeedfix -kit:better -smith:super -spoon"
    )]
    public void RearrangedButEquivalentFlags_ReturnTrue(string flagsetOne, string flagsetTwo)
    {
        var result = FlagsetComparer.Compare(flagsetOne, flagsetTwo, out var discrepancies);

        Assert.True(result);
        Assert.Empty(discrepancies);
    }

}
