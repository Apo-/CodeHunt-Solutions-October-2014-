//03.03, 1/3

using System;

public static class Program_3 {
    public static int Puzzle(int n)
    {
        int ps = prevSq(n);
        return n < 2 ? n : n == 3 ? 2 : 3*ps/2 + (n < 3 * ps / 2 ? Puzzle(n - ps) : -(3 * ps / 4) + (n < 7 * ps / 4 ? Puzzle(5*ps/2 - n - 1) : Puzzle(n - ps) - ps/4));
    }
    //Computes the previous power of 2, e.g. prevSq(45) == 32
    public static int prevSq(int n) { 
        return (int)(Math.Pow(2, Math.Floor(Math.Log(n) / Math.Log(2))));
    }
}