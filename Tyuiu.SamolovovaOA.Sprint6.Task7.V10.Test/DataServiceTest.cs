using Tyuiu.SamolovovaOA.Sprint6.Task7.V10.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\SamOl\OneDrive\Рабочий стол\DataSprint5\InPutFileTask7V10.csv";

            int[,] result = ds.GetMatrix(path);

            int[,] wait =
            {
                { 1,  2,  3 },
                { 4,  5,  6 },
                { 7,  8,  9 },
                { 10, 11, 12 },
                { 0,  0,  0 }
            };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}
