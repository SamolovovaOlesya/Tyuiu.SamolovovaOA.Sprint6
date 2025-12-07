using System;
using Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task6.V14
{
    class TestProgram
    {
        static void Main()
        {
            try
            {
                string testFile = "test.txt";
                string content = @"GzTsc rdRibhX swrfhvUjC NSRnNINXl
 ELHLVt AucHJjziZ aQsI U raHsMtQF
EgQpG yhOkcN dsE jiUFMDjMsEervIz
jojh Aj ZujmucpYQE dOo QybRwHOetJ
ziwVyU odBBKi WNcOobILAM USuVFcGp";

                System.IO.File.WriteAllText(testFile, content);

                DataService ds = new DataService();
                string result = ds.CollectTextFromFile(testFile);

                Console.WriteLine("Результат:");
                Console.WriteLine(result);
                Console.WriteLine();

                string expected = "GzTsc AucHJjziZ jiUFMDjMsEervIz ZujmucpYQE ziwVyU";
                Console.WriteLine("Ожидалось:");
                Console.WriteLine(expected);

                if (result == expected)
                    Console.WriteLine("\n✓ ТЕСТ ПРОЙДЕН!");
                else
                    Console.WriteLine("\n✗ ТЕСТ НЕ ПРОЙДЕН!");

                System.IO.File.Delete(testFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}