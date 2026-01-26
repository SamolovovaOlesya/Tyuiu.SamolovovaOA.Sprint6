using Tyuiu.SamolovovaOA.Sprint6.Task2.V12.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait =
            {
                -2.15,
                -2.57,
                -3.00,
                -3.83,
                -11.70,
                3.00,
                2.19,
                3.31,
                2.97,
                1.18,
                0.03
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
