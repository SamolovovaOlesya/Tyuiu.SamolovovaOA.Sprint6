using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SamolovovaOA.Sprint6.Task4.V23.Lib;

namespace Tyuiu.SamolovovaOA.Sprint6.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(11, result.Length);

            Assert.AreEqual(0, result[6], 0.001, "Ошибка при делении на ноль (x=1)");

            double expectedAtMinus5 = 4 - 2 * (-5) + (2 + Math.Cos(-5)) / (2 * (-5) - 2);
            Assert.AreEqual(Math.Round(expectedAtMinus5, 2), result[0], 0.001);
            double expectedAtZero = 4 - 2 * 0 + (2 + Math.Cos(0)) / (2 * 0 - 2);
            Assert.AreEqual(Math.Round(expectedAtZero, 2), result[5], 0.001);

            double expectedAtFive = 4 - 2 * 5 + (2 + Math.Cos(5)) / (2 * 5 - 2);
            Assert.AreEqual(Math.Round(expectedAtFive, 2), result[10], 0.001);
        }
    }
}