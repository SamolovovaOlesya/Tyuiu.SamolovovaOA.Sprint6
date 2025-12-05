using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SamolovovaOA.Sprint6.Task3.V20.Lib;

namespace Tyuiu.SamolovovaOA.Sprint6.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                {-14, 17, -19, 3, 2},
                {-4, -14, -19, -9, -1},
                {1, 0, 13, 14, 8},
                {13, 7, 8, -3, -15},
                {2, -20, 12, -14, 4}
            };

            int[,] expected = {
                {-14, 17, -19, 3, 2},
                {-4, -14, -19, -9, -1},
                {1, 0, 13, 14, 8},
                {13, 7, 8, -3, -15},
                {0, 0, 0, 0, 0}
            };

            int[,] result = ds.Calculate(matrix);

            Assert.AreEqual(expected.GetLength(0), result.GetLength(0));
            Assert.AreEqual(expected.GetLength(1), result.GetLength(1));

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }
    }
}