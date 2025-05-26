namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] A = { 1, 2, 3, 4, 5, 6, 8, 9, 10 };
            int result = solution.solution(A);
            Console.WriteLine(result);
        }
        
        internal class Solution {
            public int solution(int[] A) {
                var aList = new List<int>();
                foreach(int a in A){
                    aList.Add(a);
                }
                aList.Sort();
                aList.Insert(0, 0);

                for(int i = 0; i < aList.Count; i++){
                    if(i == aList[i])
                        continue;

                    return i;
                }
                return aList.Count;
            }
        }
    }
    
}

