//02.04, 3/3

using System;

public class Program_4 {
    public static int Puzzle(int n) {
      return n%5 == 0 ? n : Puzzle(n+1);
    }
}
