using Days.One;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            var solver = new DayOne(nameof(DayOne).ToString(), false);

            Console.WriteLine("Day One answer is: " + solver.PartOneSolver());
        }
    }
}
