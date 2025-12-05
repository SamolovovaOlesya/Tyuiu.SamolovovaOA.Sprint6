using System;
using System.Collections.Generic;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SamolovovaOA.Sprint6.Task5.V26.Lib
{
    public class DataService : ISprint6Task5V26
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] strNums = File.ReadAllLines(path);
            double[] nums = new double[strNums.Length];

            for (int i = 0; i < strNums.Length; i++)
            {
                strNums[i] = strNums[i].Replace(',', '.');

                if (double.TryParse(strNums[i], out double num))
                {
                    nums[i] = Math.Round(num, 3);
                }
            }

            return nums;
        }
    }
}