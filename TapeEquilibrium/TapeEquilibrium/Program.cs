using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine(solution.solution(a));
    }
}



class Solution {
    public int solution(int[] A) {
        int lowest = int.MaxValue;

        int p1 = A[0];
        int p2 = A.Sum() - A[0];


        for(int P = 1; P < A.Length; P++){
            lowest = Math.Min(lowest, Math.Abs(p1-p2));

            p1 += A[P];
            p2 -= A[P];
        }
        return lowest;
    }
}