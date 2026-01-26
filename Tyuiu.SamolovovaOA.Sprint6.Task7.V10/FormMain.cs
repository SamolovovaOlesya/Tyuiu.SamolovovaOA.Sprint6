using Tyuiu.SamolovovaOA.Sprint6.Task7.V10.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task7.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();


        private void buttonOpenFile_SOA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SOA.ShowDialog();
            openFilePath = openFileDialogTask_SOA.FileName;

            int[,] matrix = LoadFromFileData(openFilePath);

            dataGridViewIn_SOA.ColumnCount = columns;
            dataGridViewIn_SOA.RowCount = rows;

            dataGridViewOut_SOA.ColumnCount = columns;
            dataGridViewOut_SOA.RowCount = rows;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_SOA.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }

            buttonDone_SOA.Enabled = true;
        }

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(
                new char[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries
            );

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line[c]);
                }
            }

            return arrayValues;
        }

        private void buttonDone_SOA_Click(object sender, EventArgs e)
        {
            int[,] result = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_SOA.Rows[r].Cells[c].Value = result[r, c];
                }
            }

            buttonSaveFile_SOA.Enabled = true;
        }

        private void buttonSaveFile_SOA_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_SOA.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask_SOA.InitialDirectory =
                Directory.GetCurrentDirectory();
            saveFileDialogTask_SOA.ShowDialog();

            string path = saveFileDialogTask_SOA.FileName;

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            int rCount = dataGridViewOut_SOA.RowCount;
            int cCount = dataGridViewOut_SOA.ColumnCount;

            string str = "";

            for (int i = 0; i < rCount; i++)
            {
                for (int j = 0; j < cCount; j++)
                {
                    if (j < cCount - 1)
                        str += dataGridViewOut_SOA.Rows[i].Cells[j].Value + ";";
                    else
                        str += dataGridViewOut_SOA.Rows[i].Cells[j].Value;
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonInfo_SOA_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }
    }
}

