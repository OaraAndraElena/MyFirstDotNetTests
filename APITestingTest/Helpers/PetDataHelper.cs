
using System.Diagnostics;
using System.Reflection;
using Newtonsoft.Json;

namespace APITestingTest.Helpers
{
    public class PetDataHelper
    {
        public static PetData ReadPetDataFromJson(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<PetData>(json);
        }

        public static string ReadDataFromFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public static PetData ReadPetDataFromRelativePath(string relativePath)
        {
            // Get the base directory where your application or test assembly is located
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Combine the base directory with the relative path to your JSON file
            string filePath = Path.Combine(baseDirectory, relativePath);

            // Read the JSON file
            string json = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<PetData>(json);
        }

        public static string ReadPetJsonFromRelativePath(string relativePath)
        {
            // Get the base directory where your application or test assembly is located
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Combine the base directory with the relative path to your JSON file
            string filePath = Path.Combine(baseDirectory, relativePath);

            // Read the JSON file
            string json = File.ReadAllText(filePath);
            return json;
        }
    }

}
