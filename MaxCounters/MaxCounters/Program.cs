using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] a = { 3,4,4,6,1,4,4 };

        var b = Solution.solution(5, a);
        foreach (int i in b)
        {
            Console.WriteLine(i);
        }
    }
}

class Solution {
    public static int[] solution(int N, int[] A) {
        int[] counters = new int[N];
        int currentHighest = counters[0];
        int lastUpdate = 0;

        for(int i = 0; i < A.Length; i++){
            int X = A[i];
            if (1 <= X && X <= N){
                var c = counters[X- 1];
                if (c < lastUpdate)
                    counters[X-1] = lastUpdate;
                var a = counters[X - 1] + 1;
                counters[X-1] = a;
                if(a > currentHighest)
                    currentHighest = a;

            } else{
                lastUpdate = currentHighest;
            }
        }

        for(int i = 0; i < counters.Length; i++){
            if(counters[i] < lastUpdate)
                counters[i] = lastUpdate;
        }
        return counters;
    }
}