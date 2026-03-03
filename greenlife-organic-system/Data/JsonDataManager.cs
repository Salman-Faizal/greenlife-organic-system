using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace greenlife_organic_system.Data
{
    // Central JSON helper used across services.
    public static class JsonDataManager
    {
        // Serializes a list of records to disk with indentation so files stay
        public static void SaveToFile<T>(string filePath, List<T> data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        // Loads records from disk and always returns a non-null list.
        // Returning an empty list for missing/blank files keeps callers simple.
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
