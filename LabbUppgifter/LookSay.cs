using System.Text;

namespace LabbUppgifter;

public class LookSay
{
    public static string GetLookSay(string inputText)
    {
        if (inputText == "" || inputText == null)
        {
            return "";
        }

        StringBuilder stringBuilder = new("");
        var total = 1;
        var number = inputText[0];
        for (int i = 0; i < inputText.Length; i++)
        {
            if (i + 1 >= inputText.Length)
            {
                stringBuilder.Append($"{total}{number}");
                return stringBuilder.ToString();
            }
            if (inputText[i] == inputText[i + 1])
            {
                total += 1;
            }
            else
            {
                stringBuilder.Append($"{total}{number}");
                total = 1;
                number = inputText[i + 1];
            }
        }
        return stringBuilder.ToString();
    }

    public static string GetLookSayRepeatedTimes(string inputText, int timesToRepeat)
    {
        var result = inputText;

        for (int i = 0; i < timesToRepeat; i++)
        {
            result = GetLookSay(result);
        }
        return result;

    }


}