using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SamolovovaOA.Sprint6.Task4.V23.Lib
{
    public class DataService : ISprint6Task4V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                if (2 * x - 2 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = 4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2);
                }
                result[index] = Math.Round(y, 2);
                index++;
            }

            return result;
        }
    }
}
