using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var arr = new int[] {  1, 2, 1, 2, 3, 2, 2, 1, 1 };
        Solution sol = new Solution();
        Console.WriteLine(sol.solution(arr));
        
    }
}

class Solution
{
    public int solution(int[] A)
    {
        Dictionary<int, int> numbers = new Dictionary<int, int>();

        foreach (int a in A)
        {
            if (numbers.ContainsKey(a))
                numbers[a]++;
            else
                numbers.Add(a, 1);
        }
        foreach (var num in numbers)
        {
            if (num.Value % 2 != 0)
            {
                return num.Key;
            }
        }
        return 0;
    }
}