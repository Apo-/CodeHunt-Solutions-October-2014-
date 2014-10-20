//01.03, 3/3

using System.Linq;

public class Program_3 {
    public static string Puzzle(int n) {
        return toQ("", n);
    }
    
    //Converts number from numeral system with base 10 to base 4
    public static string toQ(string s, int n){
        return n < 4 ? n.ToString() + s : toQ((n%4).ToString() + s, n/4);
    }
}