//03.01, 3/3

using System;
using System.Linq;

public class Program_1 {
    public static int Puzzle(int[] a)
    {
        int x = int.MaxValue;
        for (int i = 0; i < a.Length; i++) {
            for (int j = i + 1; j < a.Length; j++) {
                if (Math.Abs(a[i] - a[j]) < x) {
                    x = Math.Abs(a[i] - a[j]);
                }
            }
        }
        return x;
    }
}