using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Lib;

namespace Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V14.txt");

            string testData = "GzTsc rdRibhX swrfhvUjC NSRnNINXl\n" +
                              "ELHLVt AucHJjziZ aQsI U raHsMtQF\n" +
                              "EgQpG yhOkcN dsE jiUFMDjMsEervIz\n" +
                              "jojh Aj ZujmucpYQE dOo QybRwHOetJ\n" +
                              "ziwVyU odBBKi WNcOobILAM USuVFcGp";

            File.WriteAllText(path, testData);

            string result = ds.CollectTextFromFile(path);
            string expected = "GzTsc AucHJjziZ jiUFMDjMsEervIz ZujmucpYQE ziwVyU";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EmptyFileTest()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "EmptyFile.txt");
            File.WriteAllText(path, "");

            string result = ds.CollectTextFromFile(path);
            string expected = "";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            Assert.AreEqual(expected, result);
        }
    }
}