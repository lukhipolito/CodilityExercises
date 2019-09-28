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

            Lessons.CyclicRotation.Solution.solution(new int[] { 
            1,2,3,4,5,6
            }, 2).ToList().ForEach(x => Console.WriteLine(x));

            Console.ReadKey();
        }
    }
}
