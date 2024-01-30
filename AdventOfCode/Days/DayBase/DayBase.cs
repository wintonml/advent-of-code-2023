using Helpers.FileHelper;

namespace AdventOfCode;

public abstract class DayBase(string dayAndNumber, bool isTest)
{
    public string _dayAndNumber  = dayAndNumber;
    public readonly bool _isTest = isTest;
    public string[]? Input { get; set; }

    public abstract int PartOneSolver();
    public abstract int PartTwoSolver();
    public void SetFileInputAsStringArray(string fileDirectory)
    {
        if(!string.IsNullOrEmpty(fileDirectory))
        {
            Input = FileHelper.GetStringArrayFromFile(fileDirectory);
        }
    }

    private string SetFileDirectory(bool isPartOne)
    {
        string section = isPartOne ? "PartOne" : "PartTwo";
        string fileDirectory = _isTest ?
        $"../../../../Inputs/Examples/{_dayAndNumber}/{_dayAndNumber}{section}ExampleInput.txt":
        $"Inputs/Puzzles/{_dayAndNumber}/{_dayAndNumber}{section}Input.txt";
        return fileDirectory;
    }

    public void GetAndSetFileInputToStringArray(bool isPartOne)
    {
        var file = SetFileDirectory(isPartOne);
        SetFileInputAsStringArray(file);
    }
}
