using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SamolovovaOA.Sprint6.Task5.V26.Lib
{
    public class DataService : ISprint6Task5V26
    {
        private readonly string filePath = @"C:\DataSprint6\InPutDataFileTask5V26.txt";

        public double[] LoadFromDataFile(string path)
        {
            List<double> resultList = new List<double>();

            try
            {
                string actualPath = !string.IsNullOrWhiteSpace(path) ? path : this.filePath;

                if (!File.Exists(actualPath))
                {
                    throw new FileNotFoundException($"Файл не найден по пути: {actualPath}");
                }

                string[] lines = File.ReadAllLines(actualPath);

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string normalizedLine = line.Trim().Replace(',', '.');

                    if (double.TryParse(normalizedLine, NumberStyles.Any,
                        CultureInfo.InvariantCulture, out double number))
                    {
                        double roundedNumber = Math.Round(number, 3);

                        double remainder = Math.Abs(roundedNumber % 5);
                        if (remainder < 0.001 || Math.Abs(remainder - 5) < 0.001)
                        {
                            resultList.Add(roundedNumber);
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new Exception($"Файл не найден: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при чтении файла: {ex.Message}", ex);
            }

            return resultList.ToArray();
        }
    }
}