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
            Regex regexOne = new(@"\d+");
            Regex regexTwo = new(@"\d+", RegexOptions.RightToLeft);

            return GetTotalValue(regexOne, regexTwo);
        }

        public override int PartTwoSolver()
        {
            GetAndSetFileInputToStringArray(isPartOne: false);
            string pattern = @"(\d|" + string.Join("|", Enum.GetNames(typeof(Numbers)).Select(Regex.Escape)) + ")";
            Console.WriteLine(pattern);

            Regex regexOne = new(pattern, RegexOptions.IgnoreCase);
            Regex regexTwo = new(pattern, RegexOptions.IgnoreCase | RegexOptions.RightToLeft);

            return GetTotalValue(regexOne, regexTwo);
        }

        private int GetTotalValue(Regex regexOne, Regex regexTwo)
        {
            foreach(string line in Input)
            {
                firstVal = GetValue(regexOne, line, isLastValue: false);
                lastVal = GetValue(regexTwo, line, isLastValue: false);
                combinedNum = firstVal.ToString() + lastVal.ToString();
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

        private string GetValue(Regex regex, string inputLine, bool isLastValue)
        {
            MatchCollection matches = regex.Matches(inputLine);
            var matchesSize = matches.Count;
            var value = "";
            if (matchesSize > 0)
            {
                value = matches[0].ToString();
                var valueLength = value.Length;

                if(!IsStringAnIntValue(value))
                {
                    value = GetNumbersEnumIntValueAsString(value);
                }
                else
                {
                    value = isLastValue ?
                    value[0].ToString():
                    value[0].ToString();
                }
            }
            return value;
        }
    }
}