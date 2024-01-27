using Days.One;

namespace Tests;

public class DayOneExampleTest
{
    [Fact]
    public void DayOnePartOneExampleResult()
    {
        var solver = new DayOne(nameof(DayOne).ToString(), isTest: true);
        var result = solver.PartOneSolver();

        Assert.Equal(142, result);
    }

    [Fact]
    public void DayOnePartTwoExampleResult()
    {
        var solver = new DayOne(nameof(DayOne).ToString(), isTest: true);
        var result = solver.PartTwoSolver();

        Assert.Equal(281, result);
    }
}