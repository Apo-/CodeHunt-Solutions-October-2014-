//01.04, 3/3

using System;

public class Program_4 {
    public static bool Puzzle(bool a, bool b) {
      return !(a||b) || (Convert.ToInt16(a)!=Convert.ToInt16(b));
    }
}