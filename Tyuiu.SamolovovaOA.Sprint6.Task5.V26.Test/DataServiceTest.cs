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
        private readonly string filePath = @"C:\DataSprint6\InPutFileTask5V26.txt";

        [TestInitialize]
        public void Initialize()
        {
            ds = new DataService();

            if (!File.Exists(filePath))
            {
                CreateTestFile(filePath);
            }
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
            Assert.AreEqual(4, result.Length, "Должно быть 4 числа, кратных 5");

            CollectionAssert.Contains(result, -10.000);
            CollectionAssert.Contains(result, 5.000);
            CollectionAssert.Contains(result, 35.000);
            CollectionAssert.Contains(result, 10.000);

            Assert.AreEqual(-10.000, result[0], 0.001);
            Assert.AreEqual(5.000, result[1], 0.001);
            Assert.AreEqual(35.000, result[2], 0.001);
            Assert.AreEqual(10.000, result[3], 0.001);
        }

        [TestMethod]
        public void LoadFromDataFile_CheckNegativeNumbers()
        {
            string testPath = @"C:\DataSprint6\TestNegativeNumbers.txt";
            string testContent = @"-10
-5
-15.5
20
3.14";

            File.WriteAllText(testPath, testContent);

            double[] result = ds.LoadFromDataFile(testPath);

            Assert.AreEqual(3, result.Length);
            CollectionAssert.Contains(result, -10.000);
            CollectionAssert.Contains(result, -5.000);
            CollectionAssert.Contains(result, 20.000);

            File.Delete(testPath);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LoadFromDataFile_InvalidPath_ThrowsException()
        {
            string invalidPath = @"C:\InvalidPath\NonExistentFile.txt";

            ds.LoadFromDataFile(invalidPath);
        }

        [TestMethod]
        public void LoadFromDataFile_EmptyFile_ReturnsEmptyArray()
        {
            string testPath = @"C:\DataSprint6\TestEmptyFile.txt";
            File.WriteAllText(testPath, "");

            double[] result = ds.LoadFromDataFile(testPath);

            Assert.AreEqual(0, result.Length);

            File.Delete(testPath);
        }

        private void CreateTestFile(string path)
        {
            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

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