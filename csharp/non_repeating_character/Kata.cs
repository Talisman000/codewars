using System.Collections.Generic;
using System.Linq;
// title:First non-repeating character
// kyu:5
// URL:https://www.codewars.com/kata/52bc74d4ac05d0945d00054e/csharp
public class Kata
{
    public static string FirstNonRepeatingLetter(string s)
    {
        Dictionary<string, int> letterCounts = new Dictionary<string, int>();
        foreach (var c in s)
        {
            var letter = c.ToString();
            if (letterCounts.ContainsKey(letter.ToLower())) letterCounts[letter.ToLower()]++;
            else if (letterCounts.ContainsKey(letter.ToUpper())) letterCounts[letter.ToUpper()]++;
            else letterCounts.Add(letter, 1);
        }
        letterCounts.Add("", 1);
        return letterCounts.FirstOrDefault(letterCount => letterCount.Value == 1).Key;
    }
}