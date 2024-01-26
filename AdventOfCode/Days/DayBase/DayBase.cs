using Helpers.FileHelper;

namespace AdventOfCode;

public abstract class DayBase
{
    public readonly string[] _input;
    public DayBase(string fileName, bool isTest)
    {
        this._input = FileHelper.GetStringArrayFromFile(fileName, isTest);
    }

    public abstract int PartOneSolver();
    public abstract int PartTwoSolver();
}
