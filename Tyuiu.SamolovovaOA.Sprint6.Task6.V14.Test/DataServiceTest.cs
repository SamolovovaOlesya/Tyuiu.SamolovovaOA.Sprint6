using System;

class Test
{
    static void Main()
    {
        try
        {
            var ds = new Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Lib.DataService();
            string result = ds.CollectTextFromFile(@"C:\DataSprint6\InPutDataFileTask6V14.txt");

            Console.WriteLine("Результат: " + result);

            string expected = "GzTsc AucHJjziZ jiUFMDjMsEervIz ZujmucpYQE ziwVyU";
            Console.WriteLine("Ожидалось: " + expected);

            if (result == expected)
                Console.WriteLine("✓ УСПЕХ!");
            else
                Console.WriteLine("✗ ОШИБКА!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }

        Console.ReadKey();
    }
}