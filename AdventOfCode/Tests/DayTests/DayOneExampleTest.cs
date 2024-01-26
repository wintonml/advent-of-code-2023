using Days.One;

namespace Tests;

public class DayOneExampleTest
{
    [Fact]
    public void DayOneExampleResult()
    {
        const string fileName = "DayOneExampleInput";
        var solver = new DayOne(fileName, true);
        var result = solver.PartOneSolver();

        Assert.Equal(142, result);
    }
}