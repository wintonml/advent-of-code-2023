using AdventOfCode.Days.One;
using AdventOfCode.Helpers;

namespace Tests.DayTests
{
    public class DayOneExampleTest
    {
        static readonly string Day = nameof(DayOne).ToString();
        readonly string DayOnePartOneTestFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: true, isPartOne: true, Day);
        readonly string DayOnePartOneRealFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: false, isPartOne: true, Day);
        readonly string DayOnePartTwoTestFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: true, isPartOne: false, Day);
        readonly string DayOnePartTwoRealFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: false, isPartOne: false, Day);

        [Fact]
        public void DayOnePartOneExampleResult()
        {
            var solver = new DayOne();
            solver.SetInputUsingFileDirectory(DayOnePartOneTestFile);
            var result = solver.PartOneSolver();

            Assert.Equal(142, result);
        }

        [Fact]
        public void DayOnePartOneMultipleDigitsInARow()
        {
            var solver = new DayOne();
            string[] input = ["123asd32"];

            solver.SetInput(input);
            var result = solver.PartOneSolver();

            Assert.Equal(12, result);
        }

        [Fact]
        public void DayOnePartTwoExampleResult()
        {
            var solver = new DayOne();
            solver.SetInputUsingFileDirectory(DayOnePartTwoTestFile);
            var result = solver.PartTwoSolver();

            Assert.Equal(281, result);
        }

        [Fact]
        public void DayOnePartTwoOverlappingWordsAreSeparated()
        {
            var solver = new DayOne();
            string[] input = ["twone", "12three5eighthree"];
            solver.SetInput(input);
            var result = solver.PartTwoSolver();

            Assert.Equal(34, result);
        }

        [Fact]
        public void DayOnePartTwoOneIntInString()
        {
            var solver = new DayOne();
            string[] input = ["aaaa1aaaa"];
            solver.SetInput(input);
            var result = solver.PartTwoSolver();

            Assert.Equal(11, result);
        }

        [Fact]
        public void DayOnePartTwoTwoNumbersAsStrings()
        {
            var solver = new DayOne();
            string[] input = ["oneight"];
            solver.SetInput(input);
            var result = solver.PartTwoSolver();

            Assert.Equal(18, result);
        }

        [Fact]
        public void DayOnePartTwoInputLineHasNoNumbers()
        {
            var solver = new DayOne();
            string[] input = ["oneightwo", "asdasdnjkvsjknd"];
            solver.SetInput(input);
            var result = solver.PartTwoSolver();

            Assert.Equal(12, result);
        }

        #region Day One Answers
        [Fact]
        public void DayOnePartOneAnswer()
        {
            var solver = new DayOne();
            solver.SetInputUsingFileDirectory(DayOnePartTwoRealFile);
            var result = solver.PartOneSolver();

            Assert.Equal(53651, result);
        }

        [Fact]
        public void DayOnePartTwoAnswer()
        {
            var solver = new DayOne();
            solver.SetInputUsingFileDirectory(DayOnePartTwoRealFile);
            var result = solver.PartTwoSolver();

            Assert.Equal(53894, result);
        }
        #endregion
    }
}
