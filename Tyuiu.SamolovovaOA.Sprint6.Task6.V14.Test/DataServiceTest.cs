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
            string expected = "GzTsc AucHJjziZ jiUFMDjMsEervIz ZujmucpYQE ziwVyU";

            string? directory = Path.GetDirectoryName(testFilePath);
            if (directory != null && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            File.WriteAllText(testFilePath,
                "GzTsc rdRibhX swrfhvUjC NSRnNINXl\n" +
                "ELHLVt AucHJjziZ aQsI U raHsMtQF\n" +
                "EgQpG yhOkcN dsE jiUFMDjMsEervIz\n" +
                "jojh Aj ZujmucpYQE dOo QybRwHOetJ\n" +
                "ziwVyU odBBKi WNcOobILAM USuVFcGp");

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
    }
}