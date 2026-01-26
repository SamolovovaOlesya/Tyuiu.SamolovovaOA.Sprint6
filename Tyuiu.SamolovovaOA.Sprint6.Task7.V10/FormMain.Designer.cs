namespace Tyuiu.SamolovovaOA.Sprint6.Task7.V10
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButton_SOA = new Panel();
            buttonSaveFile_SOA = new Button();
            buttonInfo_SOA = new Button();
            buttonDone_SOA = new Button();
            buttonOpenFile_SOA = new Button();
            panelInfo_SOA = new Panel();
            groupBoxInfo_SOA = new GroupBox();
            textBoxInfo_SOA = new TextBox();
            splitContainer_SOA = new SplitContainer();
            groupBoxInput_SOA = new GroupBox();
            dataGridViewIn_SOA = new DataGridView();
            groupBoxOut_SOA = new GroupBox();
            dataGridViewOut_SOA = new DataGridView();
            openFileDialogTask_SOA = new OpenFileDialog();
            toolTip_SOA = new ToolTip(components);
            saveFileDialogTask_SOA = new SaveFileDialog();
            panelButton_SOA.SuspendLayout();
            panelInfo_SOA.SuspendLayout();
            groupBoxInfo_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_SOA).BeginInit();
            splitContainer_SOA.Panel1.SuspendLayout();
            splitContainer_SOA.Panel2.SuspendLayout();
            splitContainer_SOA.SuspendLayout();
            groupBoxInput_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_SOA).BeginInit();
            groupBoxOut_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_SOA).BeginInit();
            SuspendLayout();
            // 
            // panelButton_SOA
            // 
            panelButton_SOA.Controls.Add(buttonSaveFile_SOA);
            panelButton_SOA.Controls.Add(buttonInfo_SOA);
            panelButton_SOA.Controls.Add(buttonDone_SOA);
            panelButton_SOA.Controls.Add(buttonOpenFile_SOA);
            panelButton_SOA.Dock = DockStyle.Top;
            panelButton_SOA.Location = new Point(0, 0);
            panelButton_SOA.Name = "panelButton_SOA";
            panelButton_SOA.Size = new Size(1487, 94);
            panelButton_SOA.TabIndex = 0;
            // 
            // buttonSaveFile_SOA
            // 
            buttonSaveFile_SOA.Location = new Point(338, 6);
            buttonSaveFile_SOA.Name = "buttonSaveFile_SOA";
            buttonSaveFile_SOA.Size = new Size(157, 84);
            buttonSaveFile_SOA.TabIndex = 7;
            buttonSaveFile_SOA.Text = "Сохранить";
            toolTip_SOA.SetToolTip(buttonSaveFile_SOA, "Сохраняет результат в файл OutPutFileTask7.csv.");
            buttonSaveFile_SOA.UseVisualStyleBackColor = true;
            buttonSaveFile_SOA.Click += buttonSaveFile_SOA_Click;
            // 
            // buttonInfo_SOA
            // 
            buttonInfo_SOA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_SOA.Location = new Point(1302, 6);
            buttonInfo_SOA.Name = "buttonInfo_SOA";
            buttonInfo_SOA.Size = new Size(173, 84);
            buttonInfo_SOA.TabIndex = 6;
            buttonInfo_SOA.Text = "Сведения";
            toolTip_SOA.SetToolTip(buttonInfo_SOA, "Сведения о программе");
            buttonInfo_SOA.UseVisualStyleBackColor = true;
            buttonInfo_SOA.Click += buttonInfo_SOA_Click;
            // 
            // buttonDone_SOA
            // 
            buttonDone_SOA.Location = new Point(175, 6);
            buttonDone_SOA.Name = "buttonDone_SOA";
            buttonDone_SOA.Size = new Size(157, 84);
            buttonDone_SOA.TabIndex = 5;
            buttonDone_SOA.Text = "Выполнить";
            toolTip_SOA.SetToolTip(buttonDone_SOA, "Меняет в пятой строке значения от 5 до 10 на 0.");
            buttonDone_SOA.UseVisualStyleBackColor = true;
            buttonDone_SOA.Click += buttonDone_SOA_Click;
            // 
            // buttonOpenFile_SOA
            // 
            buttonOpenFile_SOA.Location = new Point(10, 5);
            buttonOpenFile_SOA.Name = "buttonOpenFile_SOA";
            buttonOpenFile_SOA.Size = new Size(159, 84);
            buttonOpenFile_SOA.TabIndex = 4;
            buttonOpenFile_SOA.Text = "Открыть файл";
            toolTip_SOA.SetToolTip(buttonOpenFile_SOA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n\r\n");
            buttonOpenFile_SOA.UseVisualStyleBackColor = true;
            buttonOpenFile_SOA.Click += buttonOpenFile_SOA_Click;
            // 
            // panelInfo_SOA
            // 
            panelInfo_SOA.Controls.Add(groupBoxInfo_SOA);
            panelInfo_SOA.Dock = DockStyle.Top;
            panelInfo_SOA.Location = new Point(0, 94);
            panelInfo_SOA.Name = "panelInfo_SOA";
            panelInfo_SOA.Size = new Size(1487, 138);
            panelInfo_SOA.TabIndex = 1;
            // 
            // groupBoxInfo_SOA
            // 
            groupBoxInfo_SOA.Controls.Add(textBoxInfo_SOA);
            groupBoxInfo_SOA.Dock = DockStyle.Fill;
            groupBoxInfo_SOA.Location = new Point(0, 0);
            groupBoxInfo_SOA.Name = "groupBoxInfo_SOA";
            groupBoxInfo_SOA.Size = new Size(1487, 138);
            groupBoxInfo_SOA.TabIndex = 1;
            groupBoxInfo_SOA.TabStop = false;
            groupBoxInfo_SOA.Text = "Условие:";
            // 
            // textBoxInfo_SOA
            // 
            textBoxInfo_SOA.Dock = DockStyle.Fill;
            textBoxInfo_SOA.Location = new Point(3, 27);
            textBoxInfo_SOA.Multiline = true;
            textBoxInfo_SOA.Name = "textBoxInfo_SOA";
            textBoxInfo_SOA.ReadOnly = true;
            textBoxInfo_SOA.Size = new Size(1481, 108);
            textBoxInfo_SOA.TabIndex = 0;
            textBoxInfo_SOA.TabStop = false;
            textBoxInfo_SOA.Text = resources.GetString("textBoxInfo_SOA.Text");
            // 
            // splitContainer_SOA
            // 
            splitContainer_SOA.Dock = DockStyle.Fill;
            splitContainer_SOA.Location = new Point(0, 232);
            splitContainer_SOA.Name = "splitContainer_SOA";
            // 
            // splitContainer_SOA.Panel1
            // 
            splitContainer_SOA.Panel1.Controls.Add(groupBoxInput_SOA);
            // 
            // splitContainer_SOA.Panel2
            // 
            splitContainer_SOA.Panel2.Controls.Add(groupBoxOut_SOA);
            splitContainer_SOA.Size = new Size(1487, 483);
            splitContainer_SOA.SplitterDistance = 758;
            splitContainer_SOA.TabIndex = 6;
            // 
            // groupBoxInput_SOA
            // 
            groupBoxInput_SOA.Controls.Add(dataGridViewIn_SOA);
            groupBoxInput_SOA.Dock = DockStyle.Fill;
            groupBoxInput_SOA.Location = new Point(0, 0);
            groupBoxInput_SOA.Name = "groupBoxInput_SOA";
            groupBoxInput_SOA.Size = new Size(758, 483);
            groupBoxInput_SOA.TabIndex = 0;
            groupBoxInput_SOA.TabStop = false;
            groupBoxInput_SOA.Text = "Ввод";
            // 
            // dataGridViewIn_SOA
            // 
            dataGridViewIn_SOA.AllowUserToAddRows = false;
            dataGridViewIn_SOA.AllowUserToDeleteRows = false;
            dataGridViewIn_SOA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_SOA.ColumnHeadersVisible = false;
            dataGridViewIn_SOA.Dock = DockStyle.Fill;
            dataGridViewIn_SOA.Location = new Point(3, 27);
            dataGridViewIn_SOA.Name = "dataGridViewIn_SOA";
            dataGridViewIn_SOA.ReadOnly = true;
            dataGridViewIn_SOA.RowHeadersVisible = false;
            dataGridViewIn_SOA.RowHeadersWidth = 62;
            dataGridViewIn_SOA.Size = new Size(752, 453);
            dataGridViewIn_SOA.TabIndex = 0;
            // 
            // groupBoxOut_SOA
            // 
            groupBoxOut_SOA.Controls.Add(dataGridViewOut_SOA);
            groupBoxOut_SOA.Dock = DockStyle.Fill;
            groupBoxOut_SOA.Location = new Point(0, 0);
            groupBoxOut_SOA.Name = "groupBoxOut_SOA";
            groupBoxOut_SOA.Size = new Size(725, 483);
            groupBoxOut_SOA.TabIndex = 0;
            groupBoxOut_SOA.TabStop = false;
            groupBoxOut_SOA.Text = "Вывод";
            // 
            // dataGridViewOut_SOA
            // 
            dataGridViewOut_SOA.AllowUserToAddRows = false;
            dataGridViewOut_SOA.AllowUserToDeleteRows = false;
            dataGridViewOut_SOA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_SOA.ColumnHeadersVisible = false;
            dataGridViewOut_SOA.Dock = DockStyle.Fill;
            dataGridViewOut_SOA.Location = new Point(3, 27);
            dataGridViewOut_SOA.Name = "dataGridViewOut_SOA";
            dataGridViewOut_SOA.ReadOnly = true;
            dataGridViewOut_SOA.RowHeadersVisible = false;
            dataGridViewOut_SOA.RowHeadersWidth = 62;
            dataGridViewOut_SOA.Size = new Size(719, 453);
            dataGridViewOut_SOA.TabIndex = 0;
            // 
            // openFileDialogTask_SOA
            // 
            openFileDialogTask_SOA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1487, 715);
            Controls.Add(splitContainer_SOA);
            Controls.Add(panelInfo_SOA);
            Controls.Add(panelButton_SOA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 10 | Самоловова О.А.";
            panelButton_SOA.ResumeLayout(false);
            panelInfo_SOA.ResumeLayout(false);
            groupBoxInfo_SOA.ResumeLayout(false);
            groupBoxInfo_SOA.PerformLayout();
            splitContainer_SOA.Panel1.ResumeLayout(false);
            splitContainer_SOA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_SOA).EndInit();
            splitContainer_SOA.ResumeLayout(false);
            groupBoxInput_SOA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_SOA).EndInit();
            groupBoxOut_SOA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_SOA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButton_SOA;
        private Button buttonSaveFile_SOA;
        private Button buttonInfo_SOA;
        private Button buttonDone_SOA;
        private Button buttonOpenFile_SOA;
        private Panel panelInfo_SOA;
        private GroupBox groupBoxInfo_SOA;
        private TextBox textBoxInfo_SOA;
        private SplitContainer splitContainer_SOA;
        private GroupBox groupBoxInput_SOA;
        private DataGridView dataGridViewIn_SOA;
        private GroupBox groupBoxOut_SOA;
        private DataGridView dataGridViewOut_SOA;
        private ToolTip toolTip_SOA;
        private OpenFileDialog openFileDialogTask_SOA;
        private SaveFileDialog saveFileDialogTask_SOA;
    }
}
