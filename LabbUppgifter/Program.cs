using LabbUppgifter;

//var result = LookSay.GetLookSayRepeatedTimes("3113322113", 50);
//Console.WriteLine(result.Length);
string text = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Input.txt"));
var inputNumbers = Input.Numbers(text);
var total = 0;
foreach (var inputNumber in inputNumbers)
{
    total += RocketEquation.CalculateFuelNeededForExtraFuel(inputNumber);
}
Console.WriteLine(total);
