namespace LabbUppgifter.Tests;

public class LookSayTest
{
    [Fact]
    public void LookSay_One_ReturnsEleven()
    {
        string inputText = "1";
        string expectedText = "11";
        var sut = new LookSay();
        
        var actual = sut.GetLookSay(inputText);
        
        Assert.Equal(expectedText, actual);
    }

    [Theory]
    [InlineData("1", "11")]
    [InlineData("2", "12")]
    [InlineData("56", "1516")]
    public void LookSay_KnownNumber_ReturnsLookSayResult(string inputText, string expectedResult)
    {
        var sut = new LookSay();
        
        var actual = sut.GetLookSay(inputText);
        
        Assert.Equal(expectedResult, actual);
    }
}

