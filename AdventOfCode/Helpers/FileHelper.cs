namespace AdventOfCode.Helpers
{
    public class FileHelper
    {
        static public string[] GetStringArrayFromFile(string fileDirectory)
        {
            try
            {
                return File.ReadAllLines(fileDirectory);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw new Exception();
            }
        }

        static public string ConstructFileDirectory(bool isAccessingFromTest, bool isTest, bool isPartOne, string dayNumber)
        {
            string section = isPartOne ? "PartOne" : "PartTwo";
            string prefix = isAccessingFromTest ? "../../../../AdventOfCode/" : string.Empty;
            string fileDirectory;
            if (isTest)
            {
                fileDirectory = $"{prefix}Inputs/Examples/{dayNumber}/{dayNumber}{section}ExampleInput.txt";
            }
            else
            {
                fileDirectory = $"{prefix}Inputs/Puzzles/{dayNumber}/{dayNumber}{section}Input.txt";
            }
            return fileDirectory;
        }
    }
}
