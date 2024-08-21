using AdventOfCode.Days.Three;
using AdventOfCode.Helpers;

namespace Tests.DayTests
{
    public class DayThreeExampleTest
    {
        static readonly string Day = nameof(DayThree).ToString();
        readonly string DayThreePartOneTestFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: true, isPartOne: true, Day);
        readonly string DayThreePartOneRealFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: false, isPartOne: true, Day);
        readonly string DayThreePartTwoTestFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: true, isPartOne: false, Day);
        readonly string DayThreePartTwoRealFile = FileHelper.ConstructFileDirectory(isAccessingFromTest: true, isTest: false, isPartOne: false, Day);

        [Fact]
        public void DayThreePartOneExampleResult()
        {
            var solver = new DayThree();
            solver.SetInputUsingFileDirectory(DayThreePartOneTestFile);
            var result = solver.PartOneSolver();

            Assert.Equal(4361, result);
        }

        [Fact]
        public void DayThreePartTwoExampleResult()
        {
            var solver = new DayThree();
            solver.SetInputUsingFileDirectory(DayThreePartTwoTestFile);
            var result = solver.PartTwoSolver();

            Assert.Equal(467835, result);
        }

        [Fact]
        public void DayThreePartOneDigitTopLeft()
        {
            var solver = new DayThree();
            string[] input = [
                "1..",
                ".*.",
                "...",
                ];

            solver.SetInput(input);
            var result = solver.PartOneSolver();

            Assert.Equal(1, result);
        }

        [Fact]
        public void DayThreePartOneDigitTopMiddle()
        {
            var solver = new DayThree();
            string[] input = [
                ".1.",
                ".*.",
                "...",
                ];

            solver.SetInput(input);
            var result = solver.PartOneSolver();

            Assert.Equal(1, result);
        }

        [Fact]
        public void DayThreePartOneDigitTopRight()
        {
            var solver = new DayThree();
            string[] input = [
                "..1",
                ".*.",
                "...",
                ];

            solver.SetInput(input);
            var result = solver.PartOneSolver();

            Assert.Equal(1, result);
        }

        [Fact]
        public void DayThreePartOneDigitBottomLeft()
        {
            var solver = new DayThree();
            string[] input = [
                "...",
                ".*.",
                "1..",
                ];

            solver.SetInput(input);
            var result = solver.PartOneSolver();

            Assert.Equal(1, result);
        }

        [Fact]
        public void DayThreePartOneDigitBottomMiddle()
        {
            var solver = new DayThree();
            string[] input = [
                "...",
                ".*.",
                ".1.",
                ];

            solver.SetInput(input);
            var result = solver.PartOneSolver();

            Assert.Equal(1, result);
        }

        [Fact]
        public void DayThreePartOneDigitBottomRight()
        {
            var solver = new DayThree();
            string[] input = [
                "...",
                ".*.",
                "..1",
                ];

            solver.SetInput(input);
            var result = solver.PartOneSolver();

            Assert.Equal(1, result);
        }

        [Fact]
        public void DayThreePartOneFullySurrounded()
        {
            var solver = new DayThree();
            string[] input = [
                "111",
                "1*1",
                "111",
                ];

            solver.SetInput(input);
            var result = solver.PartOneSolver();

            Assert.Equal(224, result);
        }

        [Fact]
        public void DayThreePartOneTopLeftAndRight()
        {
            var solver = new DayThree();
            string[] input = [
                "1.1",
                ".*.",
                "...",
                ];

            solver.SetInput(input);
            var result = solver.PartOneSolver();

            Assert.Equal(2, result);
        }

        #region Day Three Answers
        [Fact]
        public void DayThreePartOneAnswer()
        {
            var solver = new DayThree();
            solver.SetInputUsingFileDirectory(DayThreePartOneRealFile);
            var result = solver.PartOneSolver();

            Assert.Equal(560670, result);
        }

        [Fact]
        public void DayThreePartTwoAnswer()
        {
            var solver = new DayThree();
            solver.SetInputUsingFileDirectory(DayThreePartTwoRealFile);
            var result = solver.PartTwoSolver();

            Assert.True(false);
        }

        #endregion
    }
}
