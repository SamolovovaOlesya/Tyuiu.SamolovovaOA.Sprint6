using System;
using System.Windows.Forms;

namespace Tyuiu.SamolovovaOA.Sprint6.Task4.V23
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}