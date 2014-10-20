//03.04, 2/3

using System;
using System.Linq;
using System.Collections;

public static class Program_4 {
    public static bool Puzzle(int n) {
        return new BitArray(new byte[]{(byte)n}).Cast<bool>().Count(i=> i==true) % 2 == 1;
    }

    /*
	* Other implementations I tried
    */
    public static bool PuzzleAlt1(int n) {
        bool c = false;
        for(int i = 0; i < 8; i++, c = (n&1) == 1 ? !c : c, n = n >> 1);
        return c;
    }

    public static bool PuzzleAlt2(int n) {
        return Convert.ToString(n, 2).Count(i=>i=='1') % 2 == 1;
    }

    public static bool PuzzleAlt3(int n) {
        return n > 0 && ((n&1) == 1 ^ Puzzle(n >> 1));
    }
}