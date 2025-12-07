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

        [TestMethod]
        public void CollectTextFromFile_ValidFile_ReturnsCorrectWords()
        {
            string testFile = "testFile.txt";
            string fileContent = @"GzTsc rdRibhX swrfhvUjC NSRnNINXl
 ELHLVt AucHJjziZ aQsI U raHsMtQF
EgQpG yhOkcN dsE jiUFMDjMsEervIz
jojh Aj ZujmucpYQE dOo QybRwHOetJ
ziwVyU odBBKi WNcOobILAM USuVFcGp";

            File.WriteAllText(testFile, fileContent);

            string result = ds.CollectTextFromFile(testFile);

            string expected = "GzTsc AucHJjziZ jiUFMDjMsEervIz ZujmucpYQE ziwVyU";

            Assert.AreEqual(expected, result);

            File.Delete(testFile);
        }

        [TestMethod]
        public void CollectTextFromFile_NoZWords_ReturnsEmptyString()
        {
            string testFile = "testNoZ.txt";
            File.WriteAllText(testFile, "Hello World Test Example");

            string result = ds.CollectTextFromFile(testFile);

            Assert.AreEqual("", result);

            File.Delete(testFile);
        }

        [TestMethod]
        public void CollectTextFromFile_MixedCaseZ_ReturnsCorrectWords()
        {
            string testFile = "testMixed.txt";
            File.WriteAllText(testFile, "Zoom ZOO lazy Aztec PRIZE");

            string result = ds.CollectTextFromFile(testFile);

            Assert.AreEqual("Zoom ZOO lazy Aztec PRIZE", result);

            File.Delete(testFile);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void CollectTextFromFile_InvalidPath_ThrowsException()
        {
            ds.CollectTextFromFile(@"C:\Nonexistent\file.txt");
        }

        [TestMethod]
        public void CollectTextFromFile_EmptyFile_ReturnsEmptyString()
        {
            string testFile = "testEmpty.txt";
            File.WriteAllText(testFile, "");

            string result = ds.CollectTextFromFile(testFile);

            Assert.AreEqual("", result);

            File.Delete(testFile);
        }
    }
}