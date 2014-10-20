//02.02, 3/3

using System;

public static class Program_2 {
    public static int[] Puzzle(int[] p) {
       int s = Math.Sign(p[0] * p[1]); p[0] = Math.Abs(p[0]); p[1] = Math.Abs(p[1]);
        for (int i = 2, l = (int)Math.Sqrt(Math.Max(p[0], p[1])); i <= l; i++) {
            while (p[0] % i == 0 && p[1] % i == 0 && (p[0]!=i || p[1]!=i)) {
                p[0] /= i;
                p[1] /= i;
            }
        }
        return new int[]{s*p[0], p[1]};
    }
}
