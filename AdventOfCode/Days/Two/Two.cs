namespace AdventOfCode.Days.Two
{
    public class DayTwo() : DayBase.DayBase
    {
        // What games are possible with only 12 red cubes, 13 green cubes, and 14 blue cubes
        private enum MaxNumberOfCubes
        {
            red = 12,
            green = 13,
            blue = 14,
        }

        private List<int> validGameIds = new List<int>();

        public override int PartOneSolver()
        {
            if (Input == null)
            {
                throw new Exception("Input is null");
            }

            foreach (var entry in Input)
            {
                var gameDetails = entry.Split(':');
                var gameId = ConvertStringToInt(gameDetails[0].Split(' ')[1]);
                var games = gameDetails[1].Split(';');
                var successfulGame = true;

                foreach (var game in games)
                {
                    var cubes = game.Split(',');

                    foreach (var cube in cubes)
                    {
                        var cubeDetails = cube.Trim().Split(' '); // 0 is the number of cubes. 1 is the cube colour
                        var numberOfCubes = ConvertStringToInt(cubeDetails[0]);
                        var maxNumberOfCubes = GetMaxNumberOfCubesEnumIntValue(cubeDetails[1]);

                        if (numberOfCubes > maxNumberOfCubes)
                        {
                            successfulGame = false;
                            break;
                        }
                    }
                }
                if (successfulGame)
                {
                    validGameIds.Add(gameId);
                }
            }

            return validGameIds.Sum();
        }

        public override int PartTwoSolver()
        {
            throw new NotImplementedException();
        }

        private static int GetMaxNumberOfCubesEnumIntValue(string value)
        {
            var parsedSuccessfully = Enum.TryParse(value, true, out MaxNumberOfCubes num);
            if (parsedSuccessfully)
            {
                return (int)num;
            }
            else
            {
                throw new Exception("Invalid value given: " + value);
            }
        }

        private static int ConvertStringToInt(string value)
        {
            var parsedSuccessfully = int.TryParse(value, out int num);
            if (parsedSuccessfully)
            {
                return num;
            }
            else
            {
                throw new Exception("Invalid value given: " + value);
            }
        }
    }
}