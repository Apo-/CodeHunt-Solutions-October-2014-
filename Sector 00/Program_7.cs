//00.07, 3/3

using System.Linq;

public class Program_7 {
    public static int[] Puzzle(int b, int e){
        return Enumerable.Range(0, e + 1).Select(i => (pow(b, i))).ToArray();
    }
    public static int pow(int b, int e) {
        return e == 0 ? 1 : b * pow(b, e-1);
    }
}