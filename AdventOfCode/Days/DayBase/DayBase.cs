using AdventOfCode.Helpers;

namespace AdventOfCode.Days.DayBase
{
    public abstract class DayBase()
    {
        protected string[]? Input { get; set; }

        public abstract int PartOneSolver();
        public abstract int PartTwoSolver();
        public void SetInputUsingFileDirectory(string fileDirectory)
        {
            if (!string.IsNullOrEmpty(fileDirectory))
            {
                Input = FileHelper.GetStringArrayFromFile(fileDirectory);
            }
        }

        public void SetInput(string[] input)
        {
            Input = input;
        }
    }
}
