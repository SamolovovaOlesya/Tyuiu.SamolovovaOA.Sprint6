using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SamolovovaOA.Sprint6.Task5.V26.Lib
{
    public class DataService : ISprint6Task5V26
    {
        public double[] LoadFromDataFile(string path)
        {
            List<double> resultList = new List<double>();

            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string normalizedLine = line.Trim().Replace(',', '.');

                if (double.TryParse(normalizedLine, NumberStyles.Any,
                    CultureInfo.InvariantCulture, out double number))
                {
                    double roundedNumber = Math.Round(number, 3);

                    double remainder = Math.Abs(number % 5);
                    if (remainder < 0.0001 || Math.Abs(remainder - 5) < 0.0001)
                    {
                        resultList.Add(roundedNumber);
                    }
                }
            }

            return resultList.ToArray();
        }
    }
}