using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Lib;

namespace Tyuiu.SamolovovaOA.Sprint6.Task6.V14
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
            this.Text = "Спринт 6 | Таск 6 | Вариант 14 | Самоловова О.А.";
        }

        private void buttonOpenFile_SOA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                Title = "Выберите файл для обработки",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName ?? string.Empty;
                    if (string.IsNullOrEmpty(filePath))
                    {
                        MessageBox.Show("Файл не выбран", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    textBoxIn_SOA.Text = File.ReadAllText(filePath);

                    string result = ds.CollectTextFromFile(filePath);

                    textBoxOut_SOA.Text = result;

                    labelFileName_SOA.Text = $"Файл: {Path.GetFileName(filePath)}";
                    labelStatus_SOA.Text = $"Обработано успешно. Найдено слов: {result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length}";
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"Файл не найден: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обработке файла: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonHelp_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6. Вариант 14.\n" +
                           "Выполнила: Самоловова О.А.\n\n" +
                           "Задание:\n" +
                           "1. Загрузить текстовый файл через OpenFileDialog\n" +
                           "2. Отобразить содержимое файла в левом TextBox\n" +
                           "3. Найти все слова, содержащие букву 'z' (без учета регистра)\n" +
                           "4. Вывести найденные слова через пробел в правый TextBox\n" +
                           "5. Оба TextBox должны быть многострочными с полосами прокрутки\n\n" +
                           "Формат файла: обычный текстовый файл (.txt)",
                           "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_SOA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxOut_SOA.Text))
            {
                MessageBox.Show("Нет данных для сохранения. Сначала откройте и обработайте файл.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt",
                FileName = "ResultTask6V14.txt",
                Title = "Сохранить результат"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveDialog.FileName ?? string.Empty;
                    if (string.IsNullOrEmpty(filePath))
                    {
                        MessageBox.Show("Не указано имя файла для сохранения",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    File.WriteAllText(filePath, textBoxOut_SOA.Text);
                    MessageBox.Show($"Результат сохранен в файл:\n{filePath}",
                        "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxIn_SOA.ReadOnly = true;
            textBoxOut_SOA.ReadOnly = true;
            labelFileName_SOA.Text = "Файл: не выбран";
            labelStatus_SOA.Text = "Готов к работе";
        }
    }
}