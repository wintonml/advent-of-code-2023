using Days.One;

namespace Tests;

public class DayOneExampleTest
{
    [Fact]
    public void DayOneExampleResult()
    {
        var solver = new DayOne(nameof(DayOne).ToString(), true);
        var result = solver.PartOneSolver();

        Assert.Equal(142, result);
    }
}