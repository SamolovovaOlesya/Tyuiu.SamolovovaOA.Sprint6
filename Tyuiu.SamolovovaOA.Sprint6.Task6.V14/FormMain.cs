using Tyuiu.SamolovovaOA.Sprint6.Task6.V14.Lib;
namespace Tyuiu.SamolovovaOA.Sprint6.Task6.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath = string.Empty;
        DataService ds = new DataService();

        private void buttonInfo_SOA_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void buttonOpenFile_SOA_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialogTask.FileName;

                textBoxInput_SOA.Clear();
                textBoxInput_SOA.AppendText(
                    File.ReadAllText(openFilePath)
                );

                buttonDone_SOA.Enabled = true;
            }
        }

        private void buttonDone_SOA_Click(object sender, EventArgs e)
        {
            textBoxResult_SOA.Clear();
            textBoxResult_SOA.AppendText(ds.CollectTextFromFile(openFilePath));
        }
    }
}
    
