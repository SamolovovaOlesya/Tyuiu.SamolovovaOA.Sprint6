using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SamolovovaOA.Sprint6.Task5.V26.Lib;

namespace Tyuiu.SamolovovaOA.Sprint6.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTests
    {
        private DataService ds;
        private readonly string filePath = @"C:\DataSprint6\InPutFileTask5V26.txt";

        [TestInitialize]
        public void Initialize()
        {
            ds = new DataService();
            string directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            CreateTestFile(filePath);
        }

        [TestMethod]
        public void LoadFromDataFile_ValidFile_ReturnsCorrectArray()
        {
            double[] result = ds.LoadFromDataFile(filePath);

            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Length);

            Assert.AreEqual(-10.0, result[0], 0.001);
            Assert.AreEqual(5.0, result[1], 0.001);
            Assert.AreEqual(35.0, result[2], 0.001);
            Assert.AreEqual(10.0, result[3], 0.001);
        }

        private void CreateTestFile(string path)
        {
            string fileContent = @"-17
-10
12
-14,32
5
-7,84
12,89
-1,57
-3,64
-13,26
-8,91
-17,77
35
-9
13,83
12,76
8,86
10
-1,49
-7";

            File.WriteAllText(path, fileContent);
        }
    }
}