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

                if (matches.Count == 0){ continue; }

                for (int j = 0; j < rowLength; j++)
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
                            GetAdjacentNumbers(isEndOfLine, isStartOfLine, adjacentNumbers, rowIndexAbove, j);
                        }

                        if (!isBottomRow)
                        {
                            var rowIndexBelow = i + 1;
                            GetAdjacentNumbers(isEndOfLine, isStartOfLine, adjacentNumbers, rowIndexBelow, j);
                        }

                        if(!isStartOfLine)
                        {
                            var foundNumber = ExtractNumberAtPosition(Input[i], (j - 1));
                            adjacentNumbers.Add(foundNumber);
                        }

                        if(!isEndOfLine)
                        {
                            var foundNumber = ExtractNumberAtPosition(Input[i], (j + 1));
                            adjacentNumbers.Add(foundNumber);
                        }
                    }
                }
                schematicNumbers.Add(adjacentNumbers.Sum());
            }

            return schematicNumbers.Sum();
        }

        public override int PartTwoSolver()
        {
            throw new NotImplementedException();
        }

        public static int ExtractNumberAtPosition(string line, int position)
        {
            int start = position;
            int end = position;

            if(char.IsDigit(line[start])){
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
            }

            var numberAsString = line.Substring(start, end - start);
            var isSuccessful = int.TryParse(numberAsString, out int number);
            return isSuccessful ? number : 0;
        }

        private void GetAdjacentNumbers(bool isEndOfLine, bool isStartOfLine, List<int> adjacentNumbers, int rowIndex, int columnIndex)
        {
            if (Input == null)
            {
                throw new Exception("Input is null");
            }

            var row = Input[rowIndex];
            var foundNumber = ExtractNumberAtPosition(row, columnIndex);

            if (foundNumber == 0)
            {
                if (!isStartOfLine)
                {
                    adjacentNumbers.Add(ExtractNumberAtPosition(row, (columnIndex - 1)));
                }
                if (!isEndOfLine)
                {
                    adjacentNumbers.Add(ExtractNumberAtPosition(row, (columnIndex + 1)));
                }
            }
            else
            {
                adjacentNumbers.Add(foundNumber);
            }
        }
    }
}