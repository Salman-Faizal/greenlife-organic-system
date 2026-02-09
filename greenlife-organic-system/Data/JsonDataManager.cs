using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace greenlife_organic_system.Data
{
    public static class JsonDataManager
    {
        public static void SaveToFile<T>(string filePath, List<T> data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static List<T> LoadFromFile<T>(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<T>();

            string json = File.ReadAllText(filePath);
            if (string.IsNullOrWhiteSpace(json))
                return new List<T>();

            return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
        }
    }
}
