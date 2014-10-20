//02.01, 3/3

public static class Program_1 {
    public static int[] Puzzle(int[] p, int[] q) {
        return new int[]{ p[0]*q[0]-p[1]*q[1], p[0]*q[1]+p[1]*q[0] };
    }
}
