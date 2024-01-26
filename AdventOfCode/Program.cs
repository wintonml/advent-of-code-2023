using Days.One;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            const string fileName = "DayOneInput";
            var solver = new DayOne(fileName, false);

            Console.WriteLine("Day One answer is: " + solver.PartOneSolver());
        }
    }
}
