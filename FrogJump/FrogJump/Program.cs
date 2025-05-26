namespace FrogJump
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var jumpAmount = solution.solution(60, 500, 3);
            Console.WriteLine(jumpAmount);
        }
    }
    
    internal class Solution {
        public int solution(int X, int Y, int D) {
            double s = Y - X;
            double d = (s / D);
            return (int)Math.Ceiling(d);
        }
    }
    
}




