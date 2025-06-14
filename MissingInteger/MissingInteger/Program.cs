using System;
using System.Collections.Generic;

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
        int N = A.Length;
        var counting = 1;

        List<int> AList = new List<int>();
        AList.AddRange(A);
        AList.Sort();

        for(int i = 0; i < N; i++){
            int a = AList[i];
            if(a < counting)
                continue;
            
            if(a != counting)
                return counting;
            
            counting++;

        }
        return counting;
    }
}
