using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SamolovovaOA.Sprint6.Task3.V20.Lib
{
    public class DataService : ISprint6Task3V20
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;

            int row = rows - 1;

            for (int j = 0; j < columns; j++)
            {
                if (matrix[row, j] % 2 == 0)
                {
                    matrix[row, j] = 0;
                }
            }

            return matrix;
        }
    }
}
