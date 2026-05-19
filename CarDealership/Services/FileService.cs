using System.Text.Json;

namespace CarDealership.Services
{
    public class FileService
    {
        public void SaveToFile<T>(List<T> data, string path)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

            string json =JsonSerializer.Serialize(data, options);

            Directory.CreateDirectory(@"..\..\..\Data");

            File.WriteAllText(path,json);
        }

        public List<T> LoadFromFile<T>(
            string path)
        {
            if (!File.Exists(path))
                return new List<T>();

            string json =File.ReadAllText(path);

            List<T>? data =JsonSerializer.Deserialize <List<T>>(json);

            return data ?? new List<T>();
        }
    }
}