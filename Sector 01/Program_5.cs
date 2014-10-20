//01.05, 3/3

using System.Linq;

public class Program_5 {
    public static int[] Puzzle(int[] a) {
      return a.Skip(1).Take(a.Length-1).Select((e, i) => e - a[i]).ToArray();
    }
}