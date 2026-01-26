using System.Diagnostics;
using Tyuiu.SamolovovaOA.Sprint6.Task5.V26.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task5.V26
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();
        private string path = @"C:\Users\SamOl\OneDrive\Рабочий стол\DataSprint5\InPutDataFileTask5V26.txt";

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonD_SOA_Click(object sender, EventArgs e)
        {
            double[] nums = ds.LoadFromDataFile(path);

            dataGridViewNums_SOA.Rows.Clear();
            dataGridViewNums_SOA.Columns.Clear();
            dataGridViewNums_SOA.Columns.Add("Value", "Значение");

            for (int i = 0; i < nums.Length; i++)
                dataGridViewNums_SOA.Rows.Add(nums[i]);


            formsPlot_SOA.Plot.Clear();

            if (nums.Length == 0)
            {
                formsPlot_SOA.Refresh();
                return;
            }


            var bars = formsPlot_SOA.Plot.Add.Bars(nums);


            formsPlot_SOA.Plot.Title("Диаграмма по данным из файла");
            formsPlot_SOA.Plot.XLabel("Номер элемента");
            formsPlot_SOA.Plot.YLabel("Значение");

            formsPlot_SOA.Plot.Axes.AutoScale();

            formsPlot_SOA.Refresh();

        }

        private void buttonOpenFile_SOA_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("Файл не найден", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Process txt = new Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonH_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 5 выполнила студентка группы ПИНб-25-1 Самоловова О.А.",
                "Сообщение");
        }
    }
}
