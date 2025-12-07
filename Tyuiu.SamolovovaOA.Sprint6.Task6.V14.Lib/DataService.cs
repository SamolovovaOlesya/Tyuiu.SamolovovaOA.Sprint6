using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            StringBuilder result = new StringBuilder();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] words = line.Split(new char[] { ' ', '\t' },
                                               StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (word.IndexOf('z', StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            if (result.Length > 0)
                                result.Append(" ");

                            result.Append(word);
                        }
                    }
                }
            }

            return result.ToString();
        }
    }
}