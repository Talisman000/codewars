using System.Collections.Generic;
using System.Linq;

// title:Moving Zeros To The End
// kyu:5
// URL:https://www.codewars.com/kata/52597aa56021e91c93000cb0/csharp
public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        var zero = arr.Where(a => a == 0);
        var notZero = arr.Where(a => a != 0);
        return notZero.Concat(zero).ToArray();
    }
}