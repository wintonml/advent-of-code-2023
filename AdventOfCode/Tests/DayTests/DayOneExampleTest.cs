using Helpers.FileHelper;
using Days.One;

namespace Tests;

public class DayOneExampleTest
{
    [Fact]
    public void DayOneExampleResult()
    {
        const string fileDirectory = "../../../../Inputs/Examples/DayOneExampleInput.txt";
        var input = FileHelper.GetStringArrayFromFile(fileDirectory);
        var solver = new DayOne(input);
        var result = solver.Solve();

        Assert.Equal(142, result);
    }
}