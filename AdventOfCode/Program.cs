using AdventOfCode.Helpers;

namespace AdventOfCode
{
    public class Program
    {
        static void Main()
        {
            var dayOneSolver = new Days.One.DayOne();
            var fileDirectory = FileHelper.ConstructFileDirectory(
                isAccessingFromTest: false, isTest: false, isPartOne: true,
                nameof(Days.One.DayOne).ToString());
            dayOneSolver.SetInputUsingFileDirectory(fileDirectory);
            Console.WriteLine("Day One Part One answer is: " + dayOneSolver.PartOneSolver());

            fileDirectory = FileHelper.ConstructFileDirectory(
                isAccessingFromTest: false, isTest: false, isPartOne: false, nameof(Days.One.DayOne).ToString());
            dayOneSolver.SetInputUsingFileDirectory(fileDirectory);
            Console.WriteLine("Day One Part Two answer is: " + dayOneSolver.PartTwoSolver());

            var dayTwoSolver = new Days.Two.DayTwo();
            fileDirectory = FileHelper.ConstructFileDirectory(
                isAccessingFromTest: false, isTest: false, isPartOne: true,
                nameof(Days.Two.DayTwo).ToString());
            dayTwoSolver.SetInputUsingFileDirectory(fileDirectory);
            Console.WriteLine("Day Two Part One answer is: " + dayTwoSolver.PartOneSolver());

            fileDirectory = FileHelper.ConstructFileDirectory(
                isAccessingFromTest: false, isTest: false, isPartOne: false,
                nameof(Days.Two.DayTwo).ToString());
            dayTwoSolver.SetInputUsingFileDirectory(fileDirectory);
            Console.WriteLine("Day Two Part Two answer is: " + dayTwoSolver.PartTwoSolver());

            var dayThreeSolver = new Days.Three.DayThree();
            fileDirectory = FileHelper.ConstructFileDirectory(
                isAccessingFromTest: false, isTest: false, isPartOne: true,
                nameof(Days.Three.DayThree).ToString());
            dayThreeSolver.SetInputUsingFileDirectory(fileDirectory);
            Console.WriteLine("Day Three Part One answer is: " + dayThreeSolver.PartOneSolver());

            fileDirectory = FileHelper.ConstructFileDirectory(
                isAccessingFromTest: false, isTest: false, isPartOne: false,
                nameof(Days.Three.DayThree).ToString());
            dayThreeSolver.SetInputUsingFileDirectory(fileDirectory);
            Console.WriteLine("Day Three Part Two answer is: " + dayThreeSolver.PartTwoSolver());

            var dayFourSolver = new Days.Four.DayFour();
            fileDirectory = FileHelper.ConstructFileDirectory(
                isAccessingFromTest: false, isTest: false, isPartOne: true,
                nameof(Days.Four.DayFour).ToString());
            dayFourSolver.SetInputUsingFileDirectory(fileDirectory);
            Console.WriteLine("Day Four Part One answer is: " + dayFourSolver.PartOneSolver());
        }
    }
}
