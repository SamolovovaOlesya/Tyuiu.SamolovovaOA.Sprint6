namespace Tyuiu.SamolovovaOA.Sprint6.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]

             private string GetTempPath()
        {
            return Path.Combine(Path.GetTempPath(), "testfile.txt");
        }
        public void TestMethod1()
        {

            string path = GetTempPath();
            File.WriteAllText(path, "1,23456\n-5,6789");

            var ds = new Lib.DataService();
            double[] res = ds.LoadFromDataFile(path);

            Assert.AreEqual(1.235, res[0]);
            Assert.AreEqual(-5.679, res[1]); 

            File.Delete(path);
        }
    }
}
