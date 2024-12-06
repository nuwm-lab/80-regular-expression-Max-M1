using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is a sample text with A1B2C3 and word123 but not just4Word or 789.";

        string pattern = @"\b\w*\d\w*\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Слова, що мiстять хоча б одну цифру:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
