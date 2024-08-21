using System.Text.RegularExpressions;

namespace AdventOfCode.Days.Three
{
    public class DayThree() : DayBase.DayBase
    {
        public override int PartOneSolver()
        {
            var schematicNumbers = new List<int>();
            var ignoreNumbersAndFullstops = new Regex(@"[^0-9.]");

            if (Input == null)
            {
                throw new Exception("Input is null");
            }
            var numOfRows = Input.Length;

            for (int i = 0; i < numOfRows; i++)
            {
                var adjacentNumbers = new List<int>();
                var row = Input[i];
                var rowLength = row.Length;
                var matches = ignoreNumbersAndFullstops.Matches(row);

                if (matches.Count == 0){ break; }

                for (int j = 0; i < rowLength ; j++)
                {
                    var character = row[j];
                    var characterMatches = matches.Cast<Match>().Any(match => match.Value.Contains(character));
                    if (characterMatches)
                    {
                        var isTopRow = i == 0;
                        var isBottomRow = i == (numOfRows - 1);
                        var isStartOfLine = j == 0;
                        var isEndOfLine = j == (rowLength - 1);

                        if (!isTopRow)
                        {
                            var rowIndexAbove = i - 1;
                            // Check row above
                            if (!isStartOfLine)
                            {
                                // Check left side of character
                            }
                            if (!isEndOfLine)
                            {
                                // Check right side of character
                            }
                            // Check character above
                        }

                        if (!isBottomRow)
                        {
                            // Check row below
                            if (!isStartOfLine)
                            {
                                // Check left side of character
                            }
                            if (!isEndOfLine)
                            {
                                // Check right side of character
                            }
                            // Check character below
                        }

                        if(!isStartOfLine)
                        {
                            // Check left side
                        }

                        if(!isEndOfLine)
                        {
                            // Check right side
                        }

                    }
                }
            }

            return 0;
        }

        public override int PartTwoSolver()
        {
            throw new NotImplementedException();
        }

        public static string ExtractNumberAtPosition(string line, int position)
        {
            int start = position;
            int end = position;

            // Find the start of the number
            while (start > 0 && char.IsDigit(line[start - 1]))
            {
                start--;
            }

            // Find the end of the number
            while (end < line.Length && char.IsDigit(line[end]))
            {
                end++;
            }

            // Extract the number substring
            return line.Substring(start, end - start);
        }
    }
}