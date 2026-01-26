using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SamolovovaOA.Sprint6.Task1.V26.Lib
{
    public class DataService : ISprint6Task1V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];

            int index = 0;
            double y;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (2 * x - 1 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = ((2 * Math.Cos(x) + 2) / (2 * x - 1)) + Math.Cos(x) - 5 * x + 3;
                }

                result[index] = Math.Round(y, 2);
                index++;

            }
            return result;
        }
    }
}
