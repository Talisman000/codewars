using System;
using System.Text.RegularExpressions;


// title:Regex validate PIN code
// kyu:7
// URL:https://www.codewars.com/kata/55f8a9c06c018a0d6e000132/csharp
public class Kata
{
    public static bool ValidatePin(string pin)
    {
        return Regex.IsMatch(pin, @"((\A[0-9]{4}\z)|(\A[0-9]{6})\z)");
    }
}