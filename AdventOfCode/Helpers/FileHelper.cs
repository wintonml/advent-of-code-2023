namespace Helpers.FileHelper
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
    }
}
