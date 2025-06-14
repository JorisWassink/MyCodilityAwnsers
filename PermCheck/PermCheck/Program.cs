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
        bool[] list = new bool[A.Length + 1];
        int completed = 1;

        for(int i = 0; i < list.Length; i++){
            list[i] = false;
        }

        list[0] = true;

        for(int i = 0; i < A.Length; i++){
            try {
                if(list[A[i]] == false){
                    list[A[i]] = true;
                    completed++;
                }
                else
                    return 0;
            } 
            catch(Exception e) {
                return 0;
            }
        }



        if(completed == list.Length)
            return 1;
        else
            return 0;
    }
}
