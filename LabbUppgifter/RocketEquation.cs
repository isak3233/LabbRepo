namespace LabbUppgifter;

public class RocketEquation
{
    public static int CalculateFuelByMass(int mass)
    {
        int result = (int)mass / 3 - 2;
        return result;
    }

    public static int CalculateFuelNeededForExtraFuel(int mass)
    {

        int totalFuelNeeded = 0;
        int calculatedFuel = mass;
        while (true)
        {
            calculatedFuel = CalculateFuelByMass(calculatedFuel);
            if (calculatedFuel <= 0)
            {
                break;
            }
            totalFuelNeeded += calculatedFuel;
        }

        return totalFuelNeeded;
    }
}