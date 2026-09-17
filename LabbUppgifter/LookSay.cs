namespace LabbUppgifter;

public class LookSay
{
    public string GetLookSay(string inputText)
    {
        // 1 = 11
        var total = 1;
        // 2= 12
        // 11 = 21
        // 111222333 = 313233
        var totalString = "";
        var number = inputText[0];
        for (int i = 0; i < inputText.Length; i++)
        {
            if (i + 1 >= inputText.Length)
            {
                totalString += $"{total}{number}";
                return totalString;
            }
            if (inputText[i] == inputText[i + 1])
            {
                total += 1;
            }
            else
            {
                totalString += $"{total}{number}";
                total = 1;
                number = inputText[i + 1];
                
            }
        }
        return totalString;
    }
}