using System.Text;
using Tyuiu.SamolovovaOA.Sprint6.Task4.V23.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task4.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        double[] values;
        double[] xs;
        private void buttonDone_SOA_Click(object sender, EventArgs e)
        {
            textBoxResult_SOA.Clear();

            int startValue = Convert.ToInt32(textBoxStart_SOA.Text);
            int stopValue = Convert.ToInt32(textBoxStop_SOA.Text);

            values = ds.GetMassFunction(startValue, stopValue);

            int len = values.Length;
            xs = new double[len];

            int x = startValue;

            for (int i = 0; i < len; i++)
            {
                xs[i] = x;

                textBoxResult_SOA.AppendText("x = " + x + "\t f(x) = " + values[i] + Environment.NewLine);
                x++;
            }

            formsPlotFunction_SOA.Plot.Clear();
            formsPlotFunction_SOA.Plot.Add.Scatter(xs, values);
            formsPlotFunction_SOA.Plot.Title("График функции F(x)");
            formsPlotFunction_SOA.Plot.XLabel("Ось X");
            formsPlotFunction_SOA.Plot.YLabel("Ось Y");
            formsPlotFunction_SOA.Plot.Axes.SetLimitsX(startValue, stopValue);
            formsPlotFunction_SOA.Plot.Axes.AutoScaleY();
            formsPlotFunction_SOA.Refresh();
        }

        private void buttonSave_SOA_Click(object sender, EventArgs e)
        {
            if (values == null)
            {
                MessageBox.Show("Сначала выполните расчёт.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int startValue = Convert.ToInt32(textBoxStart_SOA.Text);
            string path = "OutPutFileTask4V23.txt";

            StringBuilder sb = new StringBuilder();
            int x = startValue;

            for (int i = 0; i < values.Length; i++)
            {
                sb.AppendLine("x = " + x + "\t f(x) = " + values[i]);
                x++;
            }

            File.WriteAllText(path, sb.ToString(), Encoding.UTF8);

            DialogResult res = MessageBox.Show(
                "Файл\n" + Path.GetFullPath(path) +
                "\nсохранён успешно!\nОткрыть его в блокноте?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("notepad.exe", path);
            }
        }
        private void buttonHelp_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ПИНб-25-1 Самоловова О.А.", "Сообщение");
        }

    }
}
    
