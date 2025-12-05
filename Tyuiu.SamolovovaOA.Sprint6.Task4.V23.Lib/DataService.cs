using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SamolovovaOA.Sprint6.Task4.V23.Lib
{
    public class DataService : ISprint6Task4V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 2 * x - 2;

                if (Math.Abs(denominator) < 0.0001)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double part1 = 4 - 2 * x;
                    double part2 = (2 + Math.Cos(x)) / denominator;
                    double result = part1 + part2;
                    valueArray[count] = Math.Round(result, 2);
                }

                count++;
            }

            return valueArray;
        }
            }
        }