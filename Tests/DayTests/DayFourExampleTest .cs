using AdventOfCode.Days.Four;
using AdventOfCode.Helpers;

namespace Tests.DayTests
{
    public class DayFourExampleTest
    {
        static readonly string Day = nameof(DayFour).ToString();
        readonly string DayFourPartOneTestFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: true, isPartOne: true, Day);
        readonly string DayFourPartOneRealFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: false, isPartOne: true, Day);

        [Fact]
        public void DayFourPartOneExampleResult()
        {
            var solver = new DayFour();
            solver.SetInputUsingFileDirectory(DayFourPartOneTestFile);
            var result = solver.PartOneSolver();

            Assert.Equal(13, result);
        }

        #region Day Three Answers
        // [Fact]
        // public void DayFourPartOneAnswer()
        // {
        //     var solver = new DayFour();
        //     solver.SetInputUsingFileDirectory(DayFourPartOneRealFile);
        //     var result = solver.PartOneSolver();

        //     Assert.Equal(0, 1);
        // }
        #endregion
    }
}
