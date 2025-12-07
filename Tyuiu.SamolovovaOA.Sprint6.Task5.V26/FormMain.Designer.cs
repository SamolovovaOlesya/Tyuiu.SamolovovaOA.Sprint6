using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.SamolovovaOA.Sprint6.Task5.V26.Lib;

namespace Tyuiu.SamolovovaOA.Sprint6.Task5.V26
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();
        private readonly string filePath = @"C:\DataSprint6\InPutFileTask5V26.txt";

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_SOA_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    CreateTestFile(filePath);
                }

                string[] lines = File.ReadAllLines(filePath);

                double[] divisibleNumbers = ds.LoadFromDataFile(filePath);

                dataGridViewAll_SOA.Rows.Clear();
                dataGridViewDivisible_SOA.Rows.Clear();
                chart_SOA.Series[0].Points.Clear();

                if (dataGridViewAll_SOA.Columns.Count == 0)
                {
                    dataGridViewAll_SOA.Columns.Add("Index", "№");
                    dataGridViewAll_SOA.Columns.Add("Value", "Значение");

                    dataGridViewDivisible_SOA.Columns.Add("Index", "№");
                    dataGridViewDivisible_SOA.Columns.Add("Value", "Значение (кратно 5)");
                }

                int allIndex = 1;
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    if (double.TryParse(line.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out double value))
                    {
                        double roundedValue = Math.Round(value, 3);
                        dataGridViewAll_SOA.Rows.Add(allIndex, roundedValue.ToString("F3"));
                        allIndex++;
                    }
                }

                int divisibleIndex = 1;
                foreach (double number in divisibleNumbers)
                {
                    dataGridViewDivisible_SOA.Rows.Add(divisibleIndex, number.ToString("F3"));
                    chart_SOA.Series[0].Points.AddXY(divisibleIndex, number);
                    chart_SOA.Series[0].Points.Last().ToolTip = $"Значение: {number:F3}";
                    divisibleIndex++;
                }

                chart_SOA.ChartAreas[0].AxisX.Title = "Номер элемента";
                chart_SOA.ChartAreas[0].AxisY.Title = "Значение";
                chart_SOA.Series[0].ChartType = SeriesChartType.Column;
                chart_SOA.Series[0].Name = "Значения кратные 5";
                chart_SOA.Titles.Clear();
                chart_SOA.Titles.Add("Диаграмма значений (кратные 5)");

                foreach (var point in chart_SOA.Series[0].Points)
                {
                    point.Color = System.Drawing.Color.DodgerBlue;
                    point.BorderColor = System.Drawing.Color.Blue;
                    point.BorderWidth = 2;
                }

                labelInfo_SOA.Text = $"Всего чисел: {allIndex - 1}, Кратных 5: {divisibleIndex - 1}";

                MessageBox.Show($"Обработано {lines.Length} строк.\n" +
                              $"Всех чисел: {allIndex - 1}\n" +
                              $"Кратных 5: {divisibleIndex - 1}",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateTestFile(string path)
        {
            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string fileContent = @"-17
-10
12
-14,32
5
-7,84
12,89
-1,57
-3,64
-13,26
-8,91
-17,77
35
-9
13,83
12,76
8,86
10
-1,49
-7";

            File.WriteAllText(path, fileContent);
        }

        private void buttonHelp_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5. Вариант 26.\n" +
                           "Выполнила: Самоловова Олеся Алексеевна\n\n" +
                           "Задание:\n" +
                           "1. Прочитать данные из файла InPutFileTask5V26.txt\n" +
                           "2. Вывести все числа в левую таблицу\n" +
                           "3. Вывести числа, КРАТНЫЕ 5 в правую таблицу\n" +
                           "4. Построить диаграмму по значениям, кратным 5\n" +
                           "5. Вещественные значения округлены до 3 знаков после запятой\n\n" +
                           "Формат файла: одно число на строке, десятичный разделитель - запятая",
                           "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_SOA_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
                saveDialog.FileName = "ResultTask5V26.txt";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        writer.WriteLine("Результаты обработки файла InPutFileTask5V26.txt");
                        writer.WriteLine("Дата: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
                        writer.WriteLine("=================================================");
                        writer.WriteLine();
                        writer.WriteLine("Все числа из файла:");
                        writer.WriteLine("№\tЗначение");

                        for (int i = 0; i < dataGridViewAll_SOA.Rows.Count; i++)
                        {
                            writer.WriteLine($"{dataGridViewAll_SOA.Rows[i].Cells[0].Value}\t" +
                                          $"{dataGridViewAll_SOA.Rows[i].Cells[1].Value}");
                        }

                        writer.WriteLine();
                        writer.WriteLine("Числа, кратные 5:");
                        writer.WriteLine("№\tЗначение");

                        for (int i = 0; i < dataGridViewDivisible_SOA.Rows.Count; i++)
                        {
                            writer.WriteLine($"{dataGridViewDivisible_SOA.Rows[i].Cells[0].Value}\t" +
                                          $"{dataGridViewDivisible_SOA.Rows[i].Cells[1].Value}");
                        }
                    }

                    MessageBox.Show($"Результаты сохранены в файл:\n{saveDialog.FileName}",
                        "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonOpenFile_SOA.PerformClick();
        }
    }
}