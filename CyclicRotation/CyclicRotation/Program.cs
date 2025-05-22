namespace CyclicRotation
{

    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Solution solution = new Solution();
            var ar = solution.solution(array, 3);

            foreach (var a in ar)
            {
                Console.Write(a + ", ");
            }
        }
    }

    class Solution
    {
        public int[] solution(int[] A, int K)
        {

            for (int i = 0; i < K; i++)
            {
                int[] B = new int[A.Length];
                for (int j = A.Length - 1; j >= 0; j--)
                {
                    int position;
                    if (j - 1 < 0)
                        position = A.Length - 1;
                    else
                        position = j - 1;

                    B[j] = A[position];
                }

                A = B;
            }

            return A;
        }
    }
}