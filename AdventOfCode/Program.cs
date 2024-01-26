using Days.One;
using Helpers.FileHelper;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            const string fileDirectory = "Inputs/Puzzles/DayOneInput.txt";
            var input = FileHelper.GetStringArrayFromFile(fileDirectory);
            var solver = new DayOne(input);

            Console.WriteLine("Day One answer is: " + solver.Solve());
        }
    }
}
