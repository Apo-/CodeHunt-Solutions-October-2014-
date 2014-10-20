//02.05, 3/3

using System;

using System.Linq;
public static class Program_5 {
    public static string Puzzle(string s) {
        return String.Join(" ", s.Split().Select(i=> new string(i.Reverse().ToArray()).Trim())).Trim();
    }
}