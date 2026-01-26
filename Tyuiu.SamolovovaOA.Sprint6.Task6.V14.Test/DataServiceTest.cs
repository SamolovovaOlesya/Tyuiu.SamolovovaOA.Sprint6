using Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\SamOl\OneDrive\Рабочий стол\DataSprint5\InPutFileTask6V14.txt";

            string wait = "zebra maze zero buzz";

            string result = ds.CollectTextFromFile(path);

            Assert.AreEqual(wait, result);
        }
    }
}
