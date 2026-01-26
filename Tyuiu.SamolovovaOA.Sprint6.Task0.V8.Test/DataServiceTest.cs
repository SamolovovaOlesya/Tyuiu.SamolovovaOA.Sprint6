using Tyuiu.SamolovovaOA.Sprint6.Task0.V8.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 6.425;
            Assert.AreEqual(wait, res);
        }
    }
}
