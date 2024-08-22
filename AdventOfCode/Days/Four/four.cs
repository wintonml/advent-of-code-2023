using System.Data;
using System.Text.RegularExpressions;

namespace AdventOfCode.Days.Four
{
    public class DayFour() : DayBase.DayBase
    {
        public override int PartOneSolver()
        {
            var totalPoints = 0;

            if (Input == null)
            {
                throw new Exception("Input is null");
            }

            foreach (var card in Input)
            {
                var cardNumbers = card.Split(":")[1];
                var numbers = cardNumbers.Split("|");
                var winningNumbers = numbers[0].Trim().Split(" ");
                var lotteryNumbers = numbers[1].Trim().Split(" ");

                var totalWinningNumbers = winningNumbers.Intersect(lotteryNumbers).Count();

                if(totalWinningNumbers > 0)
                {
                    totalPoints += (int)Math.Pow(2, totalWinningNumbers - 1);
                }
            }

            return totalPoints;
        }

        public override int PartTwoSolver()
        {
            throw new NotImplementedException();
        }
    }
}