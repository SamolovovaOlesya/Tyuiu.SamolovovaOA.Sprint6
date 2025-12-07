using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SamolovovaOA.Sprint6.Task7.V10.Lib
{
    public class DataService : ISprint6Task7V10
    {
            public int[,] GetMatrix(string path)
            {
                string[] lines = File.ReadAllLines(path);
                int rows = lines.Length;
                int cols = 10;

                int[,] matrix = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    string[] values = lines[i].Split(';');
                    for (int j = 0; j < cols; j++)
                    {
                        if (j < values.Length)
                        {
                            string value = values[j].Trim();
                            if (int.TryParse(value, out int num))
                            {
                                matrix[i, j] = num;
                            }
                        }
                    }
                }

                for (int j = 0; j < cols; j++)
                {
                    if (matrix[4, j] >= 5 && matrix[4, j] <= 10)
                    {
                        matrix[4, j] = 0;
                    }
                }

                return matrix;
            }
        }
    }