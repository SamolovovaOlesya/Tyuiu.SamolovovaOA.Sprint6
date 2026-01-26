using Tyuiu.SamolovovaOA.Sprint6.Task2.V12.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task2.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_SOA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_SOA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_SOA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                dataGridViewFunction.Rows.Clear();

                int startX = startStep;

                for (int i = 0; i < len; i++)
                {
                    dataGridViewFunction.Rows.Add(startStep, valueArray[i]);
                    startStep++;
                }


                formsPlotFunction.Plot.Clear();

                double[] xs = new double[len];
                for (int i = 0; i < len; i++)
                {
                    xs[i] = startX + i; 
                }

                var plot = formsPlotFunction.Plot.Add.Scatter(xs, valueArray);


                plot.MarkerSize = 0;
                plot.LineWidth = 2;

                formsPlotFunction.Plot.Title("График функции");
                formsPlotFunction.Plot.XLabel("Ось X");
                formsPlotFunction.Plot.YLabel("Ось Y");
                formsPlotFunction.Plot.HideLegend();

                formsPlotFunction.Plot.Axes.AutoScale();

                formsPlotFunction.Refresh();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ПИНб-25-1 Самоловова О.А.", "Сообщение");
        }

        private void buttonDone_SOA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SOA.BackColor = System.Drawing.Color.Red;
        }

        private void buttonDone_SOA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SOA.BackColor = System.Drawing.Color.Green;
        }

        private void buttonDone_SOA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SOA.BackColor = System.Drawing.Color.Blue;
        }
    }
}
   
