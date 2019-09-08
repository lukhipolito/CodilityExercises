using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExercises.Lessons.BinaryGap
{
    public class Solution
    {
        public static int solution(int N)
        {
            int longestSequence = 0;
            int current = 0;
            string binary = Convert.ToString(N, 2);
            for (int i = 0; i < binary.Length; i++)
            {            
                current = 0;
                if (binary[i] == '1' && i+1 < binary.Length && binary[i+1] == '0')
                {
                    for (int j = i + 1; j < binary.Length; j++)
                    {
                        if (binary[j] == '1')
                        {
                            current = j-i-1;
                            break;
                        }
                    }
                    if (current > longestSequence)
                        longestSequence = current;
                }
            }
            return longestSequence;
        }
    }
}
