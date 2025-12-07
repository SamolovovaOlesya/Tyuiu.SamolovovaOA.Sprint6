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

        [TestInitialize]
        public void Initialize()
        {
            // Создаем тестовый файл перед каждым тестом
            string directory = Path.GetDirectoryName(testFilePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string testData = @"GzTsc rdRibhX swrfhvUjC NSRnNINXl
ELHLVt AucHJjziZ aQsI U raHsMtQF
EgQpG yhOkcN dsE jiUFMDjMsEervIz
jojh Aj ZujmucpYQE dOo QybRwHOetJ
ziwVyU odBBKi WNcOobILAM USuVFcGp";

            File.WriteAllText(testFilePath, testData);
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Удаляем тестовый файл после тестов
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }

        // ТЕСТ 1: Основной тест - правильная работа метода
        [TestMethod]
        public void ValidCollectTextFromFile_ReturnsCorrectWords()
        {
            // Arrange
            string expected = "GzTsc AucHJjziZ jiUFMDjMsEervIz ZujmucpYQE ziwVyU";

            // Act
            string result = ds.CollectTextFromFile(testFilePath);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // ТЕСТ 2: Тест на исключение при несуществующем файле
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void CollectTextFromFile_InvalidPath_ThrowsFileNotFoundException()
        {
            // Act
            ds.CollectTextFromFile(@"C:\Nonexistent\File.txt");
        }
    }
}