using System.Text.RegularExpressions;

namespace Days.One
{
    public class DayOne(string[] input)
    {
        private readonly string[] _input = input;

        public int Solve()
        {
            string firstNum;
            string lastNum;
            string combinedNum;
            int sum = 0;
            foreach(string line in _input)
            {
                MatchCollection matches = Regex.Matches(line, @"\d+");
                var matchesSize = matches.Count;

                if (matchesSize > 0)
                {
                    firstNum = matches[0].Value.ToString();
                    lastNum = matches[matchesSize - 1].Value.ToString();
                    combinedNum = firstNum + lastNum;
                    sum += int.Parse(combinedNum);
                }
            }

            return sum;
        }
    }
}