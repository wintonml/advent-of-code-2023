using System.Text.RegularExpressions;
using AdventOfCode;

namespace Days.One
{
    public class DayOne(string dayAndNumber, bool isTest) : DayBase(dayAndNumber, isTest)
    {
        public override int PartOneSolver()
        {
            GetAndSetFileInputToStringArray(true);
            char firstNum;
            char lastNum;
            string combinedNum;
            int sum = 0;
            foreach(string line in this.Input)
            {
                MatchCollection matches = Regex.Matches(line, @"\d+");
                var matchesSize = matches.Count;
                if (matchesSize > 0)
                {
                    string combinedValues = string.Join(", ", matches.Cast<Match>().Select(match => match.Value));
                    firstNum = combinedValues.FirstOrDefault();
                    lastNum = combinedValues.LastOrDefault();
                    combinedNum = firstNum.ToString() + lastNum.ToString();
                    sum += int.Parse(combinedNum);
                }
            }

            return sum;
        }

        public override int PartTwoSolver()
        {
            return 1;
        }
    }
}