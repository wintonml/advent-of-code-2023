using Days.One;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            var solver = new DayOne(nameof(DayOne).ToString(), false);

            solver.GetAndSetFileInputToStringArray(isPartOne: true);
            Console.WriteLine("Day One Part One answer is: " + solver.PartOneSolver());

            solver.GetAndSetFileInputToStringArray(isPartOne: false);
            Console.WriteLine("Day One Part Two answer is: " + solver.PartTwoSolver());
        }
    }
}
