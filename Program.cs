using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace ООП_ПР5
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point() { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
            => $"Point: ({X}, {Y})";
    }
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Серіалізація найпростішого об'єкта Point:");
            var startpoint = new Point(80, 140);
            Console.WriteLine($"\nОригінальний об'єкт: {startpoint}");
            string jsonpath = "point.json";
            SerializeToJson(startpoint, jsonpath);
            Console.WriteLine($"\n(JSON) Успішно записано у файл: {jsonpath} в папці проекту.");
            var jsonlpoint = DeserializeFromJson<Point>(jsonpath);
            Console.WriteLine($"(JSON) Десеріалізований об'єкт: {jsonlpoint}");
            string xmlpath = "point.xml";
            SerializeToXml(startpoint, xmlpath);
            Console.WriteLine($"\n(XML) Успішно записано у файл: {xmlpath} в папці проекту.");
            var xmlpoint = DeserializeFromXml<Point>(xmlpath);
            Console.WriteLine($"(XML) Десеріалізований об'єкт: {xmlpoint}");
            Console.WriteLine($"\nЗавершено. Файли {jsonpath} та {xmlpath} знаходяться в папці проекту.");
            Console.WriteLine("\nНатисніть Enter для виходу..");
            Console.ReadLine();
        }
        static void SerializeToJson<T>(T obj, string path)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(obj, options);
            File.WriteAllText(path, json);
        }
        static T DeserializeFromJson<T>(string path)
        {
            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<T>(json)!;
        }
        static void SerializeToXml<T>(T obj, string path)
        {
            var serializer = new XmlSerializer(typeof(T));
            using var writer = new StreamWriter(path);
            serializer.Serialize(writer, obj);
        }
        static T DeserializeFromXml<T>(string path)
        {
            var serializer = new XmlSerializer(typeof(T));
            using var reader = new StreamReader(path);
            return (T)serializer.Deserialize(reader)!;
        }
    }
}