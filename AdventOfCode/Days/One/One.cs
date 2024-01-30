using System.Text.RegularExpressions;
using AdventOfCode;

namespace Days.One
{
    public class DayOne(string dayAndNumber, bool isTest) : DayBase(dayAndNumber, isTest)
    {
        private enum Numbers
        {
            zero,
            one,
            two,
            three,
            four,
            five,
            six,
            seven,
            eight,
            nine
        }
        private string firstVal = "";
        private string lastVal = "";
        private string combinedNum = string.Empty;
        private int sum = 0;

        public override int PartOneSolver()
        {
            GetAndSetFileInputToStringArray(isPartOne: true);
            Regex regex = new(@"\d");

            return GetTotalValue(regex);
        }

        public override int PartTwoSolver()
        {
            GetAndSetFileInputToStringArray(isPartOne: false);
            string pattern = @"(?:(\d|" + string.Join("|", Enum.GetNames(typeof(Numbers)).Select(Regex.Escape)) + "))";

            Regex regex = new(pattern, RegexOptions.IgnoreCase);

            return GetTotalValue(regex);
        }

        private int GetTotalValue(Regex regex)
        {
            foreach(string line in Input)
            {
                MatchCollection matches = regex.Matches(line);
                var matchesSize = matches.Count;
                if (matchesSize > 0)
                {
                    firstVal = matches[0].ToString();
                    lastVal = matches[matchesSize - 1].ToString();

                    firstVal = IsStringAnIntValue(firstVal) ?
                                firstVal :
                                GetNumbersEnumIntValueAsString(firstVal);

                    lastVal = IsStringAnIntValue(lastVal) ?
                                lastVal :
                                GetNumbersEnumIntValueAsString(lastVal) ;
                }

                combinedNum = firstVal + lastVal;
                sum += int.Parse(combinedNum);
            }

            return sum;
        }

        private static string GetNumbersEnumIntValueAsString(string value)
        {
            Enum.TryParse(value, true, out Numbers num);
            return ((int)num).ToString();
        }

        private static bool IsStringAnIntValue(string value)
        {
            return int.TryParse(value, out _);
        }
    }
}