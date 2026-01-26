using Tyuiu.SamolovovaOA.Sprint6.Task1.V26.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task1.V26
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_SOA.Text = "";
                textBoxResult_SOA.AppendText("+-----+------+" + Environment.NewLine);
                textBoxResult_SOA.AppendText("|  X  | F(X) |" + Environment.NewLine);
                textBoxResult_SOA.AppendText("+-----+------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,3:d}  |{1, 6:f2}|", startStep, valueArray[i]);
                    textBoxResult_SOA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_SOA.AppendText("+-----+------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ПИНб-25-1 Самоловова О.А.", "Сообщение");
        }
    }
}
