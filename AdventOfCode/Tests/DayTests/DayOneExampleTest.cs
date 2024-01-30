using Days.One;

namespace Tests;

public class DayOneExampleTest
{
    [Fact]
    public void DayOnePartOneExampleResult()
    {
        var solver = new DayOne(nameof(DayOne).ToString(), isTest: true);
        solver.GetAndSetFileInputToStringArray(isPartOne: true);
        var result = solver.PartOneSolver();

        Assert.Equal(142, result);
    }

    [Fact]
    public void DayOnePartTwoExampleResult()
    {
        var solver = new DayOne(nameof(DayOne).ToString(), isTest: true);
        solver.GetAndSetFileInputToStringArray(isPartOne: false);
        var result = solver.PartTwoSolver();

        Assert.Equal(281, result);
    }

    [Fact]
    public void DayOnePartTwoOverlappingWordsAreSeparated()
    {
        var solver = new DayOne(nameof(DayOne).ToString(), isTest: true)
        {
            Input = ["twone", "12three5eighthree"] // return 21 +13 = 34
        };
        var result = solver.PartTwoSolver();

        Assert.Equal(34, result);
    }

    [Fact]
    public void DayOnePartTwoOneIntInString()
    {
        var solver = new DayOne(nameof(DayOne).ToString(), isTest: true)
        {
            Input = ["aaaa1aaaa"]
        };
        var result = solver.PartTwoSolver();

        Assert.Equal(11, result);
    }

    [Fact]
    public void DayOnePartTwoTwoNumbersAsStrings()
    {
        var solver = new DayOne(nameof(DayOne).ToString(), isTest: true)
        {
            Input = ["oneight"]
        };
        var result = solver.PartTwoSolver();

        Assert.Equal(18, result);
    }

    [Fact]
    public void DayOnePartTwoThreeNumbersAsStringsInARow()
    {
        var solver = new DayOne(nameof(DayOne).ToString(), isTest: true)
        {
            Input = ["oneightwo"]
        };
        var result = solver.PartTwoSolver();

        Assert.Equal(12, result);
    }

    [Fact]
    public void DayOnePartTwoInputLineHasNoNumbers()
    {
        var solver = new DayOne(nameof(DayOne).ToString(), isTest: true)
        {
            Input = ["oneightwo", "asdasdnjkvsjknd"]
        };
        var result = solver.PartTwoSolver();

        Assert.Equal(12, result);
    }
}