namespace LabbUppgifter.Tests;

public class RocketEquationTest
{
    [Theory]
    [InlineData(12, 2)]
    [InlineData(14, 2)]
    [InlineData(1969, 654)]
    [InlineData(100756, 33583)]
    public void Calculate_MassDividedByThree_MinusTwo_RoundedDown_ReturnsExpected(int mass, int expectedResult)
    {
        var result = RocketEquation.CalculateFuelByMass(mass);
        
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(14, 2)]
    [InlineData(1969, 966)]
    [InlineData(100756, 50346)]
    public void Calculate_FuelNeededForExtraFuel_ReturnsExpected(int mass, int expectedResult)
    {
        Assert.Equal(expectedResult, RocketEquation.CalculateFuelNeededForExtraFuel(mass));
    }
    //Arrange
    
    //Act
    //Assert
    
}