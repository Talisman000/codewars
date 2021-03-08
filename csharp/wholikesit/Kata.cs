using System;

// title:Who likes it?
// kyu:6
// URL:https://www.codewars.com/kata/5266876b8f4bf2da9b000362/csharp
public static class Kata
{
    public static string Likes(string[] name)
    {
        if (name.Length == 0) return "no one likes this";
        if (name.Length == 1) return String.Format("{0} likes this", name[0]);
        if (name.Length == 2) return String.Format("{0} and {1} like this", name[0], name[1]);
        if (name.Length == 3) return String.Format("{0}, {1} and {2} like this", name[0], name[1], name[2]);
        else return String.Format("{0}, {1} and {2} others like this", name[0], name[1], name.Length - 2);
    }
}