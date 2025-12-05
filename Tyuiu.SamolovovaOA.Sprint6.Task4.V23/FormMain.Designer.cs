using System;
using System.Windows.Forms;
using System.IO;
using Tyuiu.SamolovovaOA.Sprint6.Task4.V23.Lib;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.SamolovovaOA.Sprint6.Task4.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonResult_SOA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_SOA.Text);
                int stopValue = Convert.ToInt32(textBoxStop_SOA.Text);

                double[] resultArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_SOA.Text = "Результаты табулирования функции:\r\n";
                textBoxResult_SOA.Text += "F(x) = 4 - 2x + (2 + cos(x)) / (2x - 2)\r\n";
                textBoxResult_SOA.Text += "Диапазон: [" + startValue + "; " + stopValue + "] с шагом 1\r\n";
                textBoxResult_SOA.Text += "----------------------------------------\r\n";
                textBoxResult_SOA.Text += "   x   |   F(x)\r\n";
                textBoxResult_SOA.Text += "-------------------\r\n";

                for (int i = 0; i < resultArray.Length; i++)
                {
                    int x = startValue + i;
                    string valueStr;

                    // Особый формат для деления на ноль
                    if (resultArray[i] == 0 && (2 * x - 2) == 0)
                    {
                        valueStr = "0 (деление на ноль)";
                        textBoxResult_SOA.SelectionStart = textBoxResult_SOA.TextLength;
                        textBoxResult_SOA.SelectionLength = 0;
                        textBoxResult_SOA.SelectionColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        valueStr = resultArray[i].ToString("F2");
                    }

                    string line = $"{x,6} | {valueStr,8}\r\n";
                    textBoxResult_SOA.AppendText(line);

                    // Возвращаем цвет к черному
                    textBoxResult_SOA.SelectionColor = System.Drawing.Color.Black;
                }

                // Рисуем график
                DrawGraph(resultArray, startValue, stopValue);

                // Обновляем информацию
                labelInfo_SOA.Text = $"Значений: {resultArray.Length}";
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawGraph(double[] array, int start, int stop)
        {
            chartFunction_SOA.Series[0].Points.Clear();
            chartFunction_SOA.ChartAreas[0].AxisX.Title = "Значение x";
            chartFunction_SOA.ChartAreas[0].AxisY.Title = "F(x)";
            chartFunction_SOA.Titles.Clear();
            chartFunction_SOA.Titles.Add("График функции F(x) = 4 - 2x + (2 + cos(x)) / (2x - 2)");

            for (int i = 0; i < array.Length; i++)
            {
                int x = start + i;
                chartFunction_SOA.Series[0].Points.AddXY(x, array[i]);

                // Особое оформление для точки с делением на ноль
                if (array[i] == 0 && (2 * x - 2) == 0)
                {
                    DataPoint point = chartFunction_SOA.Series[0].Points[i];
                    point.Color = System.Drawing.Color.Red;
                    point.MarkerStyle = MarkerStyle.Star5;
                    point.MarkerSize = 10;
                    point.Label = "0\n(дел. на 0)";
                }
            }

            chartFunction_SOA.Series[0].ChartType = SeriesChartType.Spline;
            chartFunction_SOA.Series[0].BorderWidth = 3;
            chartFunction_SOA.Series[0].Color = System.Drawing.Color.Blue;
            chartFunction_SOA.Series[0].MarkerStyle = MarkerStyle.Circle;
            chartFunction_SOA.Series[0].MarkerSize = 6;
            chartFunction_SOA.Series[0].MarkerColor = System.Drawing.Color.Red;
        }

        private void buttonSave_SOA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V23.txt";

                int startValue = Convert.ToInt32(textBoxStart_SOA.Text);
                int stopValue = Convert.ToInt32(textBoxStop_SOA.Text);
                double[] resultArray = ds.GetMassFunction(startValue, stopValue);

                string str = "Табулирование функции:\r\n";
                str += "F(x) = 4 - 2x + (2 + cos(x)) / (2x - 2)\r\n";
                str += "Диапазон: [" + startValue + "; " + stopValue + "] с шагом 1\r\n";
                str += "При делении на ноль возвращается 0\r\n";
                str += "Округление до 2 знаков после запятой\r\n\r\n";
                str += "x\tF(x)\r\n";
                str += "------------------------\r\n";

                for (int i = 0; i < resultArray.Length; i++)
                {
                    int x = startValue + i;
                    if (resultArray[i] == 0 && (2 * x - 2) == 0)
                    {
                        str += $"{x}\t0 (деление на ноль)\r\n";
                    }
                    else
                    {
                        str += $"{x}\t{resultArray[i]:F2}\r\n";
                    }
                }

                File.WriteAllText(path, str);

                DialogResult dialogResult = MessageBox.Show($"Файл {path} сохранен успешно!\nОткрыть его в блокноте?",
                    "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("notepad.exe", path);
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 вариант 23 выполнил студент группы ПИНб-25-1 Самоловова Олеся Алексеевна",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Устанавливаем значения по умолчанию
            textBoxStart_SOA.Text = "-5";
            textBoxStop_SOA.Text = "5";
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