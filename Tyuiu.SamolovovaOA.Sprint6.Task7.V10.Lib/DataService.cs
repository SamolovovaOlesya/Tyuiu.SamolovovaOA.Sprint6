using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SamolovovaOA.Sprint6.Task7.V10.Lib
{
    public class DataService : ISprint6Task7V10
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            int targetRow = 4;

            if (rows > targetRow)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[targetRow, j] >= 5 && matrix[targetRow, j] <= 10)
                    {
                        matrix[targetRow, j] = 0;
                    }
                }
            }


            return matrix;
        }
    }
}
