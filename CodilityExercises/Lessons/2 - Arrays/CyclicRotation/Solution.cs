using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExercises.Lessons.CyclicRotation
{
    public static class Solution { 
        public static int[] solution(int[] A, int K)
        {
            if (A.Any())
            {
                for (int i = 0; i < K; i++)
                {

                    var B = new int[A.Length];

                    for (int j = 0; j < B.Length; j++)
                    {
                        B[j] = A[j];
                    }

                    int last = A.ElementAt(A.Length - 1);

                    for (int k = 0; k < B.Length; k++)
                    {
                        if (k + 1 < B.Length)
                            A[k + 1] = B[k];
                    }

                    A[0] = last;
                }
            }       
            return A;
        }
    }
}
