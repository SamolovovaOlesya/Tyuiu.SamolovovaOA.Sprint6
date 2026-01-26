using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SamolovovaOA.Sprint6.Task5.V26.Lib
{
    public class DataService : ISprint6Task5V26
    {
        public double[] LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            string[] parts = text.Split(new char[] { ' ', '\n', '\r', '\t' },StringSplitOptions.RemoveEmptyEntries);

            double[] numsArray = new double[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                numsArray[i] = Convert.ToDouble(parts[i], CultureInfo.InvariantCulture);
            }

            numsArray = numsArray.Where(val => val % 5 == 0).Select(val => Math.Round(val, 3)).ToArray();

            return numsArray;
        }
    }
}
