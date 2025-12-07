using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Lib;

namespace Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTests
    {
        private DataService ds = new DataService();
        private readonly string testFilePath = @"C:\DataSprint6\InPutDataFileTask6V14.txt";

        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string expected = "wFrlYaZtHI AJuvHYzIfi WfmrpQjAze eAezSXF zCOZQ";

            string? directory = Path.GetDirectoryName(testFilePath);
            if (directory != null && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            File.WriteAllText(testFilePath,
                "kvrwY jVdRV wFrlYaZtHI AJuvHYzIfi\n" +
                "WfmrpQjAze gtlOC XuLENkL l oqCuXN\n" +
                "lG YebQ BV ypiUHHFJ eAezSXF aPIjKf\n" +
                "wMQ M ltxrhBXm eqSGAiC PvLqtMALPm\n" +
                "zCOZQ Qxv HbJcPW wUdVEuNB aidoqRW");

            try
            {
                string result = ds.CollectTextFromFile(testFilePath);
                Assert.AreEqual(expected, result);
            }
            finally
            {
                if (File.Exists(testFilePath))
                {
                    File.Delete(testFilePath);
                }
            }
        }

        [TestMethod]
        public void EmptyFile_ReturnsEmptyString()
        {
            string emptyFilePath = @"C:\DataSprint6\EmptyTestFile.txt";
            string dir = Path.GetDirectoryName(emptyFilePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            File.WriteAllText(emptyFilePath, "");

            try
            {
                string result = ds.CollectTextFromFile(emptyFilePath);
                Assert.AreEqual("", result);
            }
            finally
            {
                if (File.Exists(emptyFilePath))
                {
                    File.Delete(emptyFilePath);
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void FileNotFound_ThrowsException()
        {
            string nonExistentPath = @"C:\DataSprint6\NonExistentFile.txt";
            ds.CollectTextFromFile(nonExistentPath);
        }
    }
}