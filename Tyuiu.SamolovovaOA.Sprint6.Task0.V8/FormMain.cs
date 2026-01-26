using Tyuiu.SamolovovaOA.Sprint6.Task0.V8.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task0.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_SOA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_SOA.Text = Convert.ToString((ds.Calculate(Convert.ToInt32(textBoxVarX_SOA.Text))));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ПИНб-25-1 Самоловова О.А.", "Сообщение");
        }

        private void textBoxVarX_SOA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8)) ;
        }
    }
}
