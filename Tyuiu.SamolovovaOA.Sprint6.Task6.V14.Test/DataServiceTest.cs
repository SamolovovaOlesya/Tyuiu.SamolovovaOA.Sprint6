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
            // Arrange - подготовка теста
            string expected = "GzTsc AucHJjziZ jiUFMDjMsEervIz ZujmucpYQE ziwVyU";

            // Создаем тестовый файл
            string directory = Path.GetDirectoryName(testFilePath);
            if (!Directory.Exists(directory))
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
                // Act - выполнение тестируемого метода
                string result = ds.CollectTextFromFile(testFilePath);

                // Assert - проверка результата
                Assert.AreEqual(expected, result);
            }
            finally
            {
                // Очистка после теста
                if (File.Exists(testFilePath))
                {
                    File.Delete(testFilePath);
                }
            }
        }
        [TestMethod]
        public void EmptyFile_ReturnsEmptyString()
        {
            // Arrange
            string emptyFilePath = @"C:\DataSprint6\EmptyTestFile.txt";
            File.WriteAllText(emptyFilePath, "");

            try
            {
                // Act
                string result = ds.CollectTextFromFile(emptyFilePath);

                // Assert
                Assert.AreEqual("", result);
            }
            finally
            {
                // Очистка
                if (File.Exists(emptyFilePath))
                {
                    File.Delete(emptyFilePath);
                }
            }
        }

        [TestMethod]
        public void NoZWords_ReturnsEmptyString()
        {
            // Arrange
            string noZFilePath = @"C:\DataSprint6\NoZFile.txt";
            File.WriteAllText(noZFilePath, "Hello World Test ABC");

            try
            {
                // Act
                string result = ds.CollectTextFromFile(noZFilePath);

                // Assert
                Assert.AreEqual("", result);
            }
            finally
            {
                // Очистка
                if (File.Exists(noZFilePath))
                {
                    File.Delete(noZFilePath);
                }
            }
        }

        [TestMethod]
        public void WordsWithZ_ReturnsCorrectWords()
        {
            // Arrange
            string mixedFilePath = @"C:\DataSprint6\MixedFile.txt";
            File.WriteAllText(mixedFilePath,
                "Zoom test ZOO example\n" +
                "lazy zebra AZTEC");

            string expected = "Zoom ZOO lazy zebra AZTEC";

            try
            {
                // Act
                string result = ds.CollectTextFromFile(mixedFilePath);

                // Assert
                Assert.AreEqual(expected, result);
            }
            finally
            {
                // Очистка
                if (File.Exists(mixedFilePath))
                {
                    File.Delete(mixedFilePath);
                }
            }
        }
    }
}