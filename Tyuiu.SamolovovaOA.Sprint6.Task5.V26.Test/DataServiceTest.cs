using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SamolovovaOA.Sprint6.Task5.V26.Lib;

namespace Tyuiu.SamolovovaOA.Sprint6.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTests
    {
        private DataService ds = new DataService();
        private readonly string filePath = @"C:\DataSprint6\InPutDataFileTask5V26.txt";

        [TestInitialize]
        public void Initialize()
        {
            ds = new DataService();
        }

        [TestMethod]
        public void LoadFromDataFile_ValidFile_ReturnsCorrectArray()
        {
            if (!File.Exists(filePath))
            {
                Assert.Inconclusive($"Файл не найден по пути: {filePath}");
            }

            double[] result = ds.LoadFromDataFile(filePath);

            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Length);

            Assert.AreEqual(-10.000, result[0], 0.001);
            Assert.AreEqual(5.000, result[1], 0.001);
            Assert.AreEqual(35.000, result[2], 0.001);
            Assert.AreEqual(10.000, result[3], 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LoadFromDataFile_InvalidPath_ThrowsException()
        {
            string invalidPath = @"C:\InvalidPath\NonExistentFile.txt";

            ds.LoadFromDataFile(invalidPath);
        }
    }
}