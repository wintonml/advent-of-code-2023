using System.Text.RegularExpressions;

namespace Days.One
{
    public class DayOne(string[] input)
    {
        private readonly string[] _input = input;

        public int Solve()
        {
            char firstNum;
            char lastNum;
            string combinedNum;
            int sum = 0;
            foreach(string line in _input)
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
    }
}