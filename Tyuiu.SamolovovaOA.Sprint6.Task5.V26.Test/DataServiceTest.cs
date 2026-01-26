using Tyuiu.SamolovovaOA.Sprint6.Task5.V26.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\SamOl\OneDrive\Рабочий стол\DataSprint5\InPutDataFileTask5V26.txt";

            File.WriteAllLines(path, new string[]
            {
                "10",
                "12",
                "15",
                "7",
                "20",
                "3.5"
            });

            double[] wait =
            {
                10.000,
                15.000,
                20.000
            };

            double[] result = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(wait, result);
        }
    }
}
