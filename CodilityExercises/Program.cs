using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting execution");

            Console.WriteLine(Lessons.Sample_test.Solution.solution(new int[] {
            1, 3, 6, 4, 1, 2
            }));

            Console.ReadKey();
        }
    }
}
