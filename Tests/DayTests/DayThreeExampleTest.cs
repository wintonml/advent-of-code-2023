using AdventOfCode.Days.Three;
using AdventOfCode.Helpers;

namespace Tests.DayTests
{
    public class DayThreeExampleTest
    {
        static readonly string Day = nameof(DayThree).ToString();
        readonly string DayThreePartOneTestFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: true, isPartOne: true, Day);
        readonly string DayThreePartOneRealFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: false, isPartOne: true, Day);
        // readonly string DayThreePartTwoTestFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: true, isPartOne: false, Day);
        // readonly string DayThreePartTwoRealFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: false, isPartOne: false, Day);

        [Fact]
        public void DayTwoPartOneExampleResult()
        {
            var solver = new DayThree();
            solver.SetInputUsingFileDirectory(DayThreePartOneTestFile);
            var result = solver.PartOneSolver();

            Assert.Equal(4361, result);
        }

        #region Day Three Answers
        // [Fact]
        // public void DayThreePartOneAnswer()
        // {
        //     var solver = new DayThree();
        //     solver.SetInputUsingFileDirectory(DayThreePartOneRealFile);
        //     var result = solver.PartOneSolver();

        //     Assert.True(false);
        // }

        #endregion
    }
}
