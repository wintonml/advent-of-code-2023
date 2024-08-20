using AdventOfCode.Days.One;
using AdventOfCode.Helpers;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            var solver = new DayOne();
            var fileDirectory = FileHelper.ConstructFileDirectory(
                isAccessingFromTest: false, isTest: false,isPartOne: true,
                nameof(DayOne).ToString());
            solver.SetInputUsingFileDirectory(fileDirectory);
            Console.WriteLine("Day One Part One answer is: " + solver.PartOneSolver());

            fileDirectory = FileHelper.ConstructFileDirectory(
                isAccessingFromTest: false, isTest: false,isPartOne: false, nameof(DayOne).ToString());
            solver.SetInputUsingFileDirectory(fileDirectory);
            Console.WriteLine("Day One Part Two answer is: " + solver.PartTwoSolver());
        }
    }
}
