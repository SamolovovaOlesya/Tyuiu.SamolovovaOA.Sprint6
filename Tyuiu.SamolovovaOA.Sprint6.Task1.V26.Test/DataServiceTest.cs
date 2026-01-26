using Tyuiu.SamolovovaOA.Sprint6.Task1.V26.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task1.V26.Test
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
                    28.05,
                    22.27,
                    17.01,
                    12.35,
                    7.51,
                    0.00,
                    1.62,
                    -7.03,
                    -12.99,
                    -17.55,
                    -21.43
            };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
