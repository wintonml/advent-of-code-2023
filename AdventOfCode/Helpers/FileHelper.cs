namespace Helpers.FileHelper
{
    public class FileHelper
    {
        static public string[] GetStringArrayFromFile(string filePathway)
        {
            try
            {
                return File.ReadAllLines(filePathway);;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw new Exception();
            }
        }
    }
}
