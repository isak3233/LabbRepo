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
        
        Assert.Equal(actual, expectedText);
    }
}