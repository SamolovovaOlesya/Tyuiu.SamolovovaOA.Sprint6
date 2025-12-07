using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using Tyuiu.SamolovovaOA.Sprint6.Task7.V10.Lib;

namespace Tyuiu.SamolovovaOA.Sprint6.Task7.V10
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();
        private string filePath;
        private int[,] matrixData;
        private int rows, cols;

        public FormMain()
        {
            InitializeComponent();
            this.Text = "Спринт 6 | Таск 7 | Вариант 10 | Самоловова О.А.";
        }

        private void buttonOpenFile_SOA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV файлы|*.csv|Все файлы|*.*",
                Title = "Открыть CSV файл",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePath = openFileDialog.FileName;
                    LoadCSVFile(filePath);

                    int[,] modifiedMatrix = ds.GetMatrix(filePath);
                    ShowMatrix(dataGridViewOut_SOA, modifiedMatrix);

                    buttonSave_SOA.Enabled = true;
                    labelFileName_SOA.Text = $"Файл: {Path.GetFileName(filePath)}";
                    labelStatus_SOA.Text = "Обработано успешно";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelStatus_SOA.Text = "Ошибка обработки";
                }
            }
        }

        private void LoadCSVFile(string filePath)
        {
            string[] allLines = File.ReadAllLines(filePath);
            var lines = allLines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

            rows = lines.Length;
            cols = 10;

            matrixData = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    if (j < values.Length)
                    {
                        string value = values[j].Trim();
                        if (int.TryParse(value, out int num))
                        {
                            matrixData[i, j] = num;
                        }
                    }
                }
            }

            ShowMatrix(dataGridViewIn_SOA, matrixData);
        }

        private void ShowMatrix(DataGridView grid, int[,] data)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            for (int j = 0; j < cols; j++)
            {
                grid.Columns.Add($"Col{j}", $"Столбец {j + 1}");
                grid.Columns[j].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                object[] row = new object[cols];
                for (int j = 0; j < cols; j++)
                {
                    row[j] = data[i, j];
                }
                grid.Rows.Add(row);
            }
        }

        private void buttonSave_SOA_Click(object sender, EventArgs e)
        {
            if (matrixData == null) return;

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "CSV файлы|*.csv|Все файлы|*.*",
                FileName = "OutPutFileTask7.csv",
                Title = "Сохранить результат"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SaveCSVFile(saveDialog.FileName);
                    MessageBox.Show($"Результат сохранен в файл:\n{saveDialog.FileName}",
                        "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveCSVFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                int rows = matrixData.GetLength(0);
                int cols = matrixData.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        writer.Write(matrixData[i, j]);
                        if (j < cols - 1) writer.Write(";");
                    }
                    writer.WriteLine();
                }
            }
        }

        private void buttonHelp_SOA_Click(object sender, EventArgs e)
        {
            Form infoForm = new Form();
            infoForm.Text = "Справка";
            infoForm.Size = new Size(600, 400);
            infoForm.StartPosition = FormStartPosition.CenterParent;
            infoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            infoForm.MaximizeBox = false;
            infoForm.MinimizeBox = false;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(20, 20);
            pictureBox.Size = new Size(150, 200);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;

            string imagePath = @"C:\DataSprint6\olesya.jpg";

            try
            {
                if (File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox.Image = SystemIcons.Information.ToBitmap();
                    pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
            catch
            {
                pictureBox.Image = SystemIcons.Information.ToBitmap();
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            Label label = new Label();
            label.Location = new Point(240, 20);
            label.Size = new Size(320, 280);
            label.Text = "Разработчик: Самоловова О.А.\n" +
                         "Группа: ПИНб-25-1\n\n" +
                         "Программа разработана в рамках изучения языка С#\n\n" +
                         "Тюменский индустриальный университет (с) 2025\n\n" +
                         "Высшая школа цифровых технологий (с) 2025\n\n" +
                         "Внутренее имя:\n" +
                         "Tyuiu.SamolovovaOA.Sprint6.Task7.V10\n";
            label.Font = new Font("Microsoft Sans Serif", 9F);

            Button button = new Button();
            button.Text = "OK";
            button.Location = new Point(260, 320);
            button.Size = new Size(80, 30);
            button.Click += (s, args) => infoForm.Close();

            infoForm.Controls.Add(pictureBox);
            infoForm.Controls.Add(label);
            infoForm.Controls.Add(button);
            infoForm.ShowDialog();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonSave_SOA.Enabled = false;
            labelFileName_SOA.Text = "Файл: не выбран";
            labelStatus_SOA.Text = "Готов к работе";
        }
    }
}