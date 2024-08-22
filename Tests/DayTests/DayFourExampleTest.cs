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

        [Fact]
        public void DayFourPartOneFiveMatches()
        {
            var solver = new DayFour();
            string[] input = ["Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53"];

            solver.SetInput(input);
            var result = solver.PartOneSolver();

            Assert.Equal(8, result);
        }

        [Fact]
        public void DayFourPartOneNoMatches()
        {
            var solver = new DayFour();
            string[] input = ["Card 1: 1 2 3 4 5 | 83 86  6 31 17  9 48 53"];

            solver.SetInput(input);
            var result = solver.PartOneSolver();

            Assert.Equal(0, result);
        }

        [Fact]
        public void DayFourPartOneEmptySpaces()
        {
            // Because of the spacing to make the cards displayed nicely you need to account for double spacing
            // i.e. When displaying a single digit it will " 9" instead of "9" that way it aligns with double
            // digits better.
            var solver = new DayFour();
            string[] input = ["Card 1: 1  2  3  4  5 | 83 86  6 31 17  9 48 53"];

            solver.SetInput(input);
            var result = solver.PartOneSolver();

            Assert.Equal(0, result);
        }

        #region Day Four Answers
        // [Fact]
        // public void DayFourPartOneAnswer()
        // {
        //     var solver = new DayFour();
        //     solver.SetInputUsingFileDirectory(DayFourPartOneRealFile);
        //     var result = solver.PartOneSolver();

        //     Assert.Equal(0, result);
        // }32447
        #endregion
    }
}
