using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.SamolovovaOA.Sprint6.Task2.V12.Lib;

namespace Tyuiu.SamolovovaOA.Sprint6.Task2.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetupChart();

            textBoxStart_SOA.Text = "-5";
            textBoxStop_SOA.Text = "5";
        }

        private void SetupChart()
        {
            chartFunction_SOA.Titles.Clear();
            chartFunction_SOA.Series.Clear();
            chartFunction_SOA.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("MainChartArea");
            chartArea.AxisX.Title = "X";
            chartArea.AxisY.Title = "F(x)";
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartFunction_SOA.ChartAreas.Add(chartArea);

            Series series = new Series("Function");
            series.ChartType = SeriesChartType.Spline;
            series.Color = Color.RoyalBlue;
            series.BorderWidth = 3;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.MarkerColor = Color.Red;
            chartFunction_SOA.Series.Add(series);
        }

        private void buttonDone_SOA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_SOA.Text);
                int stopValue = Convert.ToInt32(textBoxStop_SOA.Text);

                if (startValue > stopValue)
                {
                    MessageBox.Show("Начальное значение не может быть больше конечного!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataService ds = new DataService();

                double[] values = ds.GetMassFunction(startValue, stopValue);

                dataGridViewResult_SOA.Rows.Clear();
                chartFunction_SOA.Series["Function"].Points.Clear();

                int count = 0;
                for (int x = startValue; x <= stopValue; x++)
                {
                    dataGridViewResult_SOA.Rows.Add(x.ToString(), values[count].ToString("F2"));

                    chartFunction_SOA.Series["Function"].Points.AddXY(x, values[count]);

                    count++;
                }

                chartFunction_SOA.Titles.Clear();
                chartFunction_SOA.Titles.Add($"График функции F(x) = (2x+6)/(cos(x)+x) - 3");

                dataGridViewResult_SOA.Columns[0].HeaderText = "X";
                dataGridViewResult_SOA.Columns[1].HeaderText = "F(x)";

                labelInfo_SOA.Text = $"Количество точек: {values.Length}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные целочисленные значения!",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 вариант 12 выполнил студент группы ПИНб-25-1 Самоловова Олеся Алексеевна",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_SOA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && ((TextBox)sender).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void textBoxStop_SOA_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxStart_SOA_KeyPress(sender, e);
        }
    }
}