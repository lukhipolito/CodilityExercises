using System;

namespace CodilityExercises
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting execution");

            Console.WriteLine(Lessons.OddOccurrencesInArray.Solution.solution(new int[] {
                5, 6, 1, 7, 4, 5, 2, 8, 6, 8, 10, 4, 2, 3
            }));

            Console.ReadKey();
        }
    }
}
