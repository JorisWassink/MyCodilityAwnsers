

namespace BinaryGap
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var chain = solution.solution(15672897);
            Console.WriteLine(chain);
        }
    }

    internal class Solution
    {
        public int solution(int N)
        {
            var binary = Convert.ToString(N, 2);
            List<int> binaryList = new List<int>();
            int currentChain = 0;
            Console.WriteLine(binary);
            foreach (var c in binary)
            {
                if (c == '1')
                {
                    binaryList.Add(currentChain);
                    currentChain = 0;
                }
                else 
                    currentChain++;
            }
            binaryList.Add(currentChain);
            binaryList.Sort();
            binaryList.Reverse();
            return binaryList[0];
        }
    }
}