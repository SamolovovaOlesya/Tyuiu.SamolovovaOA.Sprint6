using System.Drawing.Drawing2D;
using Tyuiu.SamolovovaOA.Sprint6.Task3.V20.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task3.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] matrix =
        {
            { -14, 17, -19, 3, 2 },
            { -4, -14, -19, -9, -1 },
            { 1, 0, 13, 14, 8 },
            { 13, 7, 8, -3, -15 },
            { 2, -20, 12, -14, 4 }
        };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridViewInput_SOA.RowCount = rows;
            dataGridViewInput_SOA.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInput_SOA.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
        private void buttonDone_SOA_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(matrix);

            int rows = result.GetLength(0);
            int columns = result.GetLength(1);

            dataGridViewResult_SOA.RowCount = rows;
            dataGridViewResult_SOA.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_SOA.Rows[i].Cells[j].Value = result[i, j];
                }
            }
        }
        private void buttonHelp_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ПИНб-25-1 Самоловова О.А.", "Сообщение");
        }
    }
}
