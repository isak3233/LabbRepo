namespace LabbUppgifter.Tests;

public class LookSayTest
{
    [Fact]
    public void LookSay_One_ReturnsEleven()
    {
        string inputText = "1";
        string expectedText = "11";

        
        Assert.Equal(expectedText, LookSay.GetLookSay(inputText));
    }

    [Theory]
    [InlineData("1", "11")]
    [InlineData("2", "12")]
    [InlineData("56", "15161")]
    public void LookSay_KnownNumber_ReturnsLookSayResult(string inputText, string expectedResult)
    {
        
        Assert.Equal(expectedResult, LookSay.GetLookSay(inputText));
    }

    [Theory]
    [InlineData("1", "312211", 5)]
    [InlineData("2", "3112", 3)]
    [InlineData("2","2",0)]
    [InlineData("12","1112", 1)]
    [InlineData("", "", 2)]
    public void LookSay_KnownNumber_RepeatedFiveTimes_ReturnsLookSayResult(string inputText, string expectedResult, int timesToRepeat)
    {
        Assert.Equal(expectedResult, LookSay.GetLookSayRepeatedTimes(inputText, timesToRepeat));
    }
}

