using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExercises.Lessons.Sample_test
{
    public static class Solution
    {
        public static int solution(int[] A)
        {
            int smallest = 1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A.Any(el => el == smallest))
                    smallest++;
                else
                    break;
            }
            return smallest;
        }
    }
}
