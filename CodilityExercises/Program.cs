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

            Console.WriteLine(Lessons.OddOccurrencesInArray.Solution.solution( new int[] {
              9,
              1,
              9,
              1,
              9,
              3,
              9
            }));

            Console.ReadKey();
        }
    }
}
