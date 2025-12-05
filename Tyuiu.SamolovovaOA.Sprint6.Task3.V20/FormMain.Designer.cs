using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.SamolovovaOA.Sprint6.Task3.V20.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.SamolovovaOA.Sprint6.Task3.V20
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        private int[,] originalMatrix = {
            {-14, 17, -19, 3, 2},
            {-4, -14, -19, -9, -1},
            {1, 0, 13, 14, 8},
            {13, 7, 8, -3, -15},
            {2, -20, 12, -14, 4}
        };

        public FormMain()
        {
            InitializeComponent();
            ShowCondition();
            LoadMatrixToGrid();
        }

        private void ShowCondition()
        {
            textBoxCondition_SOA.Text = "Задание: Заменить четные значения в пятой строке на 0.\r\n\r\n" +
                                      "Исходная матрица 5x5:\r\n" +
                                      "-14  17 -19   3   2\r\n" +
                                      "-4 -14 -19  -9  -1\r\n" +
                                      "  1   0  13  14   8\r\n" +
                                      " 13   7   8  -3 -15\r\n" +
                                      "  2 -20  12 -14   4\r\n\r\n" +
                                      "Пятая строка (индекс 4): 2, -20, 12, -14, 4\r\n" +
                                      "Четные числа: 2, -20, 12, -14, 4 (все четные)";
        }

        private void LoadMatrixToGrid()
        {
            dataGridViewMatrix_SOA.ColumnCount = 5;
            dataGridViewMatrix_SOA.RowCount = 5;
            dataGridViewMatrix_SOA.RowHeadersVisible = true;
            dataGridViewMatrix_SOA.ColumnHeadersVisible = true;

            for (int i = 0; i < 5; i++)
            {
                dataGridViewMatrix_SOA.Columns[i].HeaderText = $"Столбец {i + 1}";
                dataGridViewMatrix_SOA.Columns[i].Width = 60;
            }

            for (int i = 0; i < 5; i++)
            {
                dataGridViewMatrix_SOA.Rows[i].HeaderCell.Value = $"Строка {i + 1}";

                for (int j = 0; j < 5; j++)
                {
                    dataGridViewMatrix_SOA[j, i].Value = originalMatrix[i, j];
                    dataGridViewMatrix_SOA[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    if (i == 4)
                    {
                        dataGridViewMatrix_SOA[j, i].Style.BackColor = Color.LightYellow;
                    }
                }
            }
        }

        private void buttonExecute_SOA_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] resultMatrix = ds.Calculate(originalMatrix);

                ShowResultInTextBox(resultMatrix);

                ShowResultInGrid(resultMatrix);

                ShowStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowResultInTextBox(int[,] matrix)
        {
            textBoxResult_SOA.Clear();
            textBoxResult_SOA.AppendText("Результат после замены четных чисел в 5-й строке:\r\n\r\n");

            for (int i = 0; i < 5; i++)
            {
                string row = "";
                for (int j = 0; j < 5; j++)
                {
                    row += matrix[i, j].ToString().PadLeft(4);
                }
                textBoxResult_SOA.AppendText(row + Environment.NewLine);
            }

            textBoxResult_SOA.AppendText(Environment.NewLine + "Изменения в 5-й строке:" + Environment.NewLine);
            textBoxResult_SOA.AppendText("Было:  2 -20  12 -14   4" + Environment.NewLine);
            textBoxResult_SOA.AppendText("Стало:  0   0   0   0   0");
        }

        private void ShowResultInGrid(int[,] matrix)
        {
            dataGridViewResult_SOA.ColumnCount = 5;
            dataGridViewResult_SOA.RowCount = 5;
            dataGridViewResult_SOA.RowHeadersVisible = true;
            dataGridViewResult_SOA.ColumnHeadersVisible = true;

            for (int i = 0; i < 5; i++)
            {
                dataGridViewResult_SOA.Columns[i].HeaderText = $"Столбец {i + 1}";
                dataGridViewResult_SOA.Columns[i].Width = 60;
            }

            for (int i = 0; i < 5; i++)
            {
                dataGridViewResult_SOA.Rows[i].HeaderCell.Value = $"Строка {i + 1}";

                for (int j = 0; j < 5; j++)
                {
                    dataGridViewResult_SOA[j, i].Value = matrix[i, j];
                    dataGridViewResult_SOA[j, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    if (i == 4 && originalMatrix[i, j] != matrix[i, j])
                    {
                        dataGridViewResult_SOA[j, i].Style.BackColor = Color.LightGreen;
                        dataGridViewResult_SOA[j, i].Style.Font = new Font(dataGridViewResult_SOA.Font, FontStyle.Bold);
                    }
                }
            }
        }

        private void ShowStatistics()
        {
            int[,] resultMatrix = ds.Calculate(originalMatrix);
            int changedCount = 0;

            for (int j = 0; j < 5; j++)
            {
                if (originalMatrix[4, j] != resultMatrix[4, j])
                {
                    changedCount++;
                }
            }

            string stats = $"Статистика замен:\r\n" +
                          $"Всего элементов в 5-й строке: 5\r\n" +
                          $"Изменено элементов: {changedCount}\r\n" +
                          $"Неизмененных элементов: {5 - changedCount}\r\n\r\n" +
                          $"Все четные числа были заменены на 0.";

            MessageBox.Show(stats, "Статистика выполнения",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHelp_SOA_Click(object sender, EventArgs e)
        {
            string info = "Таск 3 вариант 20 выполнил студент группы ПИНб-25-1\r\n" +
                         "Самоловова Олеся Алексеевна\r\n\r\n" +
                         "Задание: Заменить четные значения в пятой строке на 0.";

            MessageBox.Show(info, "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonExecute_SOA.PerformClick();
        }

        private void dataGridViewMatrix_SOA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int value = originalMatrix[e.RowIndex, e.ColumnIndex];
                string parity = (value % 2 == 0) ? "четное" : "нечетное";

                string info = $"Ячейка [{e.RowIndex + 1},{e.ColumnIndex + 1}]\r\n" +
                            $"Значение: {value}\r\n" +
                            $"Параметры: {parity}";

                if (e.RowIndex == 4)
                {
                    info += "\r\n\nВнимание: Это пятая строка!";
                    if (value % 2 == 0)
                    {
                        info += "\nЭто значение будет заменено на 0.";
                    }
                }

                toolTip1.SetToolTip(dataGridViewMatrix_SOA, info);
            }
        }

        private void dataGridViewResult_SOA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int[,] resultMatrix = ds.Calculate(originalMatrix);
                int originalValue = originalMatrix[e.RowIndex, e.ColumnIndex];
                int resultValue = resultMatrix[e.RowIndex, e.ColumnIndex];

                string info = $"Ячейка [{e.RowIndex + 1},{e.ColumnIndex + 1}]\r\n" +
                            $"Было: {originalValue}\r\n" +
                            $"Стало: {resultValue}";

                if (originalValue != resultValue)
                {
                    info += $"\r\n\nИзменено! {originalValue} → {resultValue}";
                }

                toolTip1.SetToolTip(dataGridViewResult_SOA, info);
            }
        }
    }
}