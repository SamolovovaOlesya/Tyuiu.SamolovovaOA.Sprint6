using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SamolovovaOA.Sprint6.Task7.V10.Lib;

namespace Tyuiu.SamolovovaOA.Sprint6.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V10.csv");

            string testData =
                "4;19;1;2;7;19;-13;13;14;-17\n" +
                "-7;-11;-7;11;13;-5;11;-14;-7;-17\n" +
                "-11;16;0;-9;-10;2;-14;-7;6;-15\n" +
                "0;0;-14;16;16;-8;-19;-15;-13;-10\n" +
                "-18;11;18;10;-9;12;-4;10;8;-2\n" +
                "10;20;11;19;13;-8;4;-3;-15;17\n" +
                "-10;-6;-5;13;3;16;-9;-12;-1;14\n" +
                "17;10;-12;0;1;4;19;-17;6;-9\n" +
                "-9;20;-20;11;-5;15;-8;6;17;-2\n" +
                "5;-15;4;9;16;12;-12;-20;-4;14";

            File.WriteAllText(path, testData);

            int[,] result = ds.GetMatrix(path);

            Assert.AreEqual(-18, result[4, 0]);
            Assert.AreEqual(11, result[4, 1]);
            Assert.AreEqual(18, result[4, 2]);
            Assert.AreEqual(0, result[4, 3]);
            Assert.AreEqual(-9, result[4, 4]);
            Assert.AreEqual(12, result[4, 5]);
            Assert.AreEqual(-4, result[4, 6]);
            Assert.AreEqual(0, result[4, 7]);
            Assert.AreEqual(0, result[4, 8]);
            Assert.AreEqual(-2, result[4, 9]);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}