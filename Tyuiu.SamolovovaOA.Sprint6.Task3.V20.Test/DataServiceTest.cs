using Tyuiu.SamolovovaOA.Sprint6.Task3.V20.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task3.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] array =
            { { -14, 17, -19, 3, 2},
              { -4, -14, -19, -9, -1},
              { 1, 0, 13, 14, 8},
              { 13, 7, 8, -3, -15},
              { 2, -20, 12, -14, 4}
            };

            int[,] res = ds.Calculate(array);
            int[,] wait = { { -14, 17, -19, 3, 2},
              { -4, -14, -19, -9, -1},
              { 1, 0, 13, 14, 8},
              { 13, 7, 8, -3, -15},
              { 0, 0, 0, 0, 0}
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
