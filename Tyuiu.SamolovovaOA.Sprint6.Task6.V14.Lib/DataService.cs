using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Путь к файлу не может быть null или пустым", nameof(path));
            }

            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}", path);
            }

            string result = "";

            string[] lines = File.ReadAllLines(path);

            Console.WriteLine($"Читаем файл: {path}");
            Console.WriteLine($"Количество строк: {lines.Length}");

            foreach (string line in lines)
            {
                string[] words = line.Split(new char[] { ' ', '\t', '\r', '\n' },
                                          StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (word.Contains("z", StringComparison.OrdinalIgnoreCase))
                    {
                        if (!string.IsNullOrEmpty(result))
                            result += " ";
                        result += word;
                    }
                }
            }

            Console.WriteLine($"Результат: {result}");
            return result;
        }
    }
}