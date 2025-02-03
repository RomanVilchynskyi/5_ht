using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string numbers = "5 123 4567 9999 10000 99999 1234 9876";
        Regex regex1 = new Regex(@"[1-9]\d{3}");
        List<string> fourDigitNumbers = new List<string>();
        foreach (Match match in regex1.Matches(numbers))
        {
            fourDigitNumbers.Add(match.Value);
        }
        Console.WriteLine("Four-digit numbers: " + string.Join(", ", fourDigitNumbers));

        string[] words = { "asd123zxc456", "bnm567hjk890", "abc12def34", "xyz789uvw123" };
        Regex regex2 = new Regex(@"[a-zA-Z]{3}\d{3}[a-zA-Z]{3}\d{3}");
        List<string> validWords = new List<string>();
        foreach (string word in words)
        {
            if (regex2.IsMatch(word))
            {
                validWords.Add(word);
            }
        }
        Console.WriteLine("Words that match the pattern: " + string.Join(", ", validWords));

        string text = "This is a test with WWW, PDF, TXT, ABC123 BMP";
        Regex regex3 = new Regex(@"[A-Z]{3}");
        List<string> abbreviations = new List<string>();
        foreach (Match match in regex3.Matches(text))
        {
            abbreviations.Add(match.Value);
        }
        Console.WriteLine("Abbreviations: " + string.Join(", ", abbreviations));

        string years = "1899 1900 1950 1999 2000 2050 2099 2100";
        Regex regex4 = new Regex(@"(19\d{2}|20\d{2})");
        List<string> validYears = new List<string>();
        foreach (Match match in regex4.Matches(years))
        {
            validYears.Add(match.Value);
        }
        Console.WriteLine("Years in the range 1900-2099: " + string.Join(", ", validYears));
    }
}