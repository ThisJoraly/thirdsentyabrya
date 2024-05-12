using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace thirdsentyabrya.ViewModel.Helpers
{
    internal class Serializer
    {
        public static void SerializeToJson<T>(T obj, string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = JsonSerializer.Serialize(obj, options);
            File.WriteAllText(filePath, jsonString);
        }

        public static T DeserializeFromJson<T>(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }

        public static void SerializeToXml<T>(T obj, string filePath)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var writer = new StreamWriter(filePath))
            {
                xmlSerializer.Serialize(writer, obj);
            }
        }

        public static T DeserializeFromXml<T>(string filePath)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var reader = new StreamReader(filePath))
            {
                return (T)xmlSerializer.Deserialize(reader);
            }
        }
    }
}
