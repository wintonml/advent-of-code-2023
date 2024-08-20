using AdventOfCode.Days.Two;
using AdventOfCode.Helpers;

namespace Tests.DayTests
{
    public class DayTwoExampleTest
    {
        static readonly string Day = nameof(DayTwo).ToString();
        readonly string DayTwoPartOneTestFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: true, isPartOne: true, Day);
        readonly string DayTwoPartOneRealFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: false, isPartOne: true, Day);
        readonly string DayTwoPartTwoTestFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: true, isPartOne: false, Day);
        readonly string DayTwoPartTwoRealFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: false, isPartOne: false, Day);

        [Fact]
        public void DayTwoPartOneExampleResult()
        {
            var solver = new DayTwo();
            solver.SetInputUsingFileDirectory(DayTwoPartOneTestFile);
            var result = solver.PartOneSolver();

            Assert.Equal(8, result);
        }

        [Fact]
        public void DayTwoPartTwoExampleResult()
        {
            var solver = new DayTwo();
            solver.SetInputUsingFileDirectory(DayTwoPartTwoTestFile);
            var result = solver.PartTwoSolver();

            Assert.Equal(2286, result);
        }

        #region Day Two Answers
        [Fact]
        public void DayTwoPartOneAnswer()
        {
            var solver = new DayTwo();
            solver.SetInputUsingFileDirectory(DayTwoPartOneRealFile);
            var result = solver.PartOneSolver();

            Assert.Equal(2512, result);
        }

        [Fact]
        public void DayTwoPartTwoAnswer()
        {
            var solver = new DayTwo();
            solver.SetInputUsingFileDirectory(DayTwoPartTwoRealFile);
            var result = solver.PartTwoSolver();

            Assert.Equal(67335, result);
        }

        #endregion
    }
}
