using AdventOfCode.Days.Two;
using AdventOfCode.Helpers;

namespace Tests.DayTests
{
    public class DayTwoExampleTest
    {
        static readonly string Day = nameof(DayTwo).ToString();
        readonly string DayTwoPartOneTestFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: true, isPartOne: true, Day);
        readonly string DayTwoPartOneRealFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: false, isPartOne: true, Day);

        [Fact]
        public void DayOnePartOneExampleResult()
        {
            var solver = new DayTwo();
            solver.SetInputUsingFileDirectory(DayTwoPartOneTestFile);
            var result = solver.PartOneSolver();

            Assert.Equal(8, result);
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

        #endregion
    }
}
