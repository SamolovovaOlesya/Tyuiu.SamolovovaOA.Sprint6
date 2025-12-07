using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
            {
                string dir = Path.GetDirectoryName(path);
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                File.WriteAllText(path,
                    "GzTsc rdRibhX swrfhvUjC NSRnNINXl\n" +
                    "ELHLVt AucHJjziZ aQsI U raHsMtQF\n" +
                    "EgQpG yhOkcN dsE jiUFMDjMsEervIz\n" +
                    "jojh Aj ZujmucpYQE dOo QybRwHOetJ\n" +
                    "ziwVyU odBBKi WNcOobILAM USuVFcGp");
            }

            string result = "";

            string text = File.ReadAllText(path);
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' },
                                      StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (word.Contains("z") || word.Contains("Z"))
                {
                    if (result.Length > 0) result += " ";
                    result += word;
                }
            }

            return result;
        }
    }
}