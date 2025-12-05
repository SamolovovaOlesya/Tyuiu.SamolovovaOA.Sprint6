using System;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SamolovovaOA.Sprint6.Task3.V20.Lib
{
    public class DataService : ISprint6Task3V20
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] resultMatrix = (int[,])matrix.Clone();

            int fifthRow = 4;

            for (int j = 0; j < columns; j++)
            {
                if (resultMatrix[fifthRow, j] % 2 == 0)
                {
                    resultMatrix[fifthRow, j] = 0;
                }
            }

            return resultMatrix;
        }
    }
}