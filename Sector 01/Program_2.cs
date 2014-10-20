//01.02, 2/3

using System;

public static class Program_2 {
    public static int Puzzle(int x) {
        return 32 + 2*x - (x - 2 + (4*Math.Sign(x)))/5;
    }
}