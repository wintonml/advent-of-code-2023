namespace Helpers.FileHelper
{
    public class FileHelper
    {
        static public string[] GetStringArrayFromFile(string fileName, bool isTest)
        {
            string fileDirectory = isTest ?
            $"../../../../Inputs/Examples/{fileName}.txt":
            $"Inputs/Puzzles/{fileName}.txt";

            try
            {
                return File.ReadAllLines(fileDirectory);;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw new Exception();
            }
        }
    }
}
