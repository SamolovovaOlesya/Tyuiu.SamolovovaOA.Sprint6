using Tyuiu.SamolovovaOA.Sprint6.Task4.V23.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task4.V23.Test
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

            double[] result = ds.GetMassFunction(startValue, stopValue);
            double[] wait =
            {
              13.81,
              11.87,
              9.87,
              7.74,
              5.36,
              2.50,
              0.00,
              0.79,
              -1.75,
              -3.78,
              -5.71
            };
            CollectionAssert.AreEqual(wait, result);
        }
    }
}
