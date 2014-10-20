//03.02, 3/3

using System;

public static class Program_2 {
    public static int Puzzle(int n) {
        return (int)(((n & 0xff) << 24) | ((n & 0xff00) << 8) | ((n & 0x00ff0000) >> 8) | (((n & 0xff000000) << 8) | ((n & 0xff000000) >> 24)));
    }
}