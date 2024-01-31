using System.Text.RegularExpressions;
using AdventOfCode;

namespace Days.One
{
    public class DayOne() : DayBase
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
        private string firstValue = "";
        private string lastValue = "";
        private string combinedNumber = string.Empty;
        private int sum = 0;

        public override int PartOneSolver()
        {
            sum = 0;
            Regex regex = new(@"\d");

            try
            {
                return GetTotalValue(regex);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"An exception occurred: {ex.Message}");
                throw new ApplicationException("An error occurred while accessing SomeProperty.", ex);
            }
        }

        public override int PartTwoSolver()
        {
            sum = 0;
            string pattern = @"\d|(?=(" + string.Join("|", Enum.GetNames(typeof(Numbers)).Select(Regex.Escape)) + "))";

            Regex regex = new(pattern, RegexOptions.IgnoreCase);

            return GetTotalValue(regex);
        }

        private int GetTotalValue(Regex regex)
        {
            foreach(string line in Input)
            {
                firstValue = "0";
                lastValue = "0";

                MatchCollection matches = regex.Matches(line);
                var matchesSize = matches.Count;
                if (matchesSize > 0)
                {
                    firstValue = GetValue(matches[0]);
                    lastValue = GetValue(matches[matchesSize - 1]);
                }

                combinedNumber = firstValue + lastValue;
                sum += int.Parse(combinedNumber);
            }

            return sum;
        }

        private static string GetValue(Match value)
        {
            var stringValue = value.ToString();
            if(string.IsNullOrEmpty(stringValue))
            {
                var groupSize = value.Groups.Count;
                var wordValue = value.Groups[groupSize - 1].Value.ToString();
                return GetNumbersEnumIntValueAsString(wordValue);
            }
            else
            {
                return stringValue;
            }
        }

        private static string GetNumbersEnumIntValueAsString(string value)
        {
            Enum.TryParse(value, true, out Numbers num);
            return ((int)num).ToString();
        }
    }
}