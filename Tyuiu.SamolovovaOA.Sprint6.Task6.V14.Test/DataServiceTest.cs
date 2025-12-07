using System;
using System.IO;
using Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Test
{
    class Program
    {
        static void Main()
        {
            string testFile = "test.txt";
            File.WriteAllText(testFile,
                "GzTsc rdRibhX swrfhvUjC NSRnNINXl\n" +
                "ELHLVt AucHJjziZ aQsI U raHsMtQF\n" +
                "EgQpG yhOkcN dsE jiUFMDjMsEervIz\n" +
                "jojh Aj ZujmucpYQE dOo QybRwHOetJ\n" +
                "ziwVyU odBBKi WNcOobILAM USuVFcGp");

            Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Lib.DataService ds =
                new Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Lib.DataService();

            string result = ds.CollectTextFromFile(testFile);

            Console.WriteLine("Результат:");
            Console.WriteLine(result);

            string expected = "GzTsc AucHJjziZ jiUFMDjMsEervIz ZujmucpYQE ziwVyU";
            Console.WriteLine("\nОжидалось:");
            Console.WriteLine(expected);

            if (result == expected)
                Console.WriteLine("\n✓ КОМПИЛЯЦИЯ И ТЕСТ ПРОЙДЕНЫ!");
            else
                Console.WriteLine($"\n✗ Результат не совпадает. Длина: {result.Length}, ожидалось: {expected.Length}");

            File.Delete(testFile);
            Console.ReadKey();
        }
    }
}