//02.03, 3/3

using System.Linq;

public static class Program_3 {
    public static int[] Puzzle(int a, int b) {
        return Enumerable.Range(a, b+1).Select(i=> i*i*i).ToArray();
    }
}
