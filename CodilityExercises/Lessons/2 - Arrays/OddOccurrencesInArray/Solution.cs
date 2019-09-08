using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExercises.Lessons.OddOccurrencesInArray
{
    public class Solution {
        public static int solution(int[] A)
        {
            int[] count = new int[A.Length];
            for (int i = 0; i< A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (count[i] != 1 && count[j] != 1 && A[i] == A[j])
                    {
                        count[i]++;
                        count[j]++;
                    }
                }
            }
            int odd = A[Array.IndexOf(count, 0)];
            return odd;
        }
    }
}
