using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Путь к файлу не может быть пустым", nameof(path));
            }

            string result = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (!string.IsNullOrEmpty(word))
                        {
                            if (word.ToLower().IndexOf('z') >= 0)
                            {
                                result += word + " ";
                            }
                        }
                    }
                }
            }

            return result.Trim();
        }
    }
}