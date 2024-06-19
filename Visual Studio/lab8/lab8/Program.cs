using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    { 
        string text = "Інформатика - це наука про інформацію. Інформатика включає програмування. Інші науки теж важливі.";
 
        string pattern = @"\bІнформатика\b";
 
        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
 
        int count = matches.Count;
 
        Console.WriteLine($"Кількість речень, що починаються зі слова 'Інформатика': {count}");
    }
}