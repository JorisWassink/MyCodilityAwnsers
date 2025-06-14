using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var x = 3;
        Console.WriteLine(solution.solution(x, a));
    }
}



class Solution {
    public int solution(int X, int[] A) {
        List<bool> isFilled = new List<bool>();
        int filledAmount = 0;

        isFilled.Add(true);
        for (int i = 1; i < X + 1; i++){
            isFilled.Add(false);
        }


        for(int i = 0; i < A.Length; i++){
            if(!isFilled[A[i]]){
                isFilled[A[i]] = true;
                filledAmount++;
       
                if(filledAmount == X)
                    return i;
            }
        }
        return -1;
    }
}