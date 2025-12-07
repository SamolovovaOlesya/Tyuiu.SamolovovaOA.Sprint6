using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string path)
        {
            // Проверка входных параметров
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Путь к файлу не может быть пустым", nameof(path));
            }

            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}", path);
            }

            string result = "";

            try
            {
                // Читаем все строки файла
                string[] allLines = File.ReadAllLines(path);

                foreach (string line in allLines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    // Разбиваем строку на слова
                    string[] words = line.Split(new char[] { ' ', '\t' },
                                              StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        // Проверяем наличие буквы 'z' без учета регистра
                        if (word.IndexOf('z', StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            if (!string.IsNullOrEmpty(result))
                                result += " ";
                            result += word;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при обработке файла: {ex.Message}", ex);
            }

            return result;
        }
    }
}