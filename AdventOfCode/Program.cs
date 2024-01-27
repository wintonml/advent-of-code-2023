using Days.One;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            var solver = new DayOne(nameof(DayOne).ToString(), false);

            Console.WriteLine("Day One Part One answer is: " + solver.PartOneSolver());
            Console.WriteLine("Day One Part Two answer is: " + solver.PartTwoSolver());
        }
    }
}
