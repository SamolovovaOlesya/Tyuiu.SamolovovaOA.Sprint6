namespace Tyuiu.SamolovovaOA.Sprint6.Task6.V14
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
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            panelButton_SOA = new Panel();
            buttonInfo_SOA = new Button();
            buttonDone_SOA = new Button();
            buttonOpenFile_SOA = new Button();
            groupBoxInfo_SOA = new GroupBox();
            textBoxInfo_SOA = new TextBox();
            splitContainer1 = new SplitContainer();
            groupBoxInput_SOA = new GroupBox();
            textBoxInput_SOA = new TextBox();
            groupBoxResult_SOA = new GroupBox();
            textBoxResult_SOA = new TextBox();
            panelButton_SOA.SuspendLayout();
            groupBoxInfo_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxInput_SOA.SuspendLayout();
            groupBoxResult_SOA.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // panelButton_SOA
            // 
            panelButton_SOA.Controls.Add(buttonInfo_SOA);
            panelButton_SOA.Controls.Add(buttonDone_SOA);
            panelButton_SOA.Controls.Add(buttonOpenFile_SOA);
            panelButton_SOA.Dock = DockStyle.Top;
            panelButton_SOA.Location = new Point(0, 0);
            panelButton_SOA.Name = "panelButton_SOA";
            panelButton_SOA.Size = new Size(1454, 106);
            panelButton_SOA.TabIndex = 1;
            // 
            // buttonInfo_SOA
            // 
            buttonInfo_SOA.Location = new Point(1270, 11);
            buttonInfo_SOA.Name = "buttonInfo_SOA";
            buttonInfo_SOA.Size = new Size(173, 84);
            buttonInfo_SOA.TabIndex = 2;
            buttonInfo_SOA.Text = "Сведения";
            buttonInfo_SOA.UseVisualStyleBackColor = true;
            buttonInfo_SOA.Click += buttonInfo_SOA_Click;
            // 
            // buttonDone_SOA
            // 
            buttonDone_SOA.Location = new Point(223, 11);
            buttonDone_SOA.Name = "buttonDone_SOA";
            buttonDone_SOA.Size = new Size(157, 84);
            buttonDone_SOA.TabIndex = 1;
            buttonDone_SOA.Text = "Выполнить";
            buttonDone_SOA.UseVisualStyleBackColor = true;
            buttonDone_SOA.Click += buttonDone_SOA_Click;
            // 
            // buttonOpenFile_SOA
            // 
            buttonOpenFile_SOA.Location = new Point(25, 11);
            buttonOpenFile_SOA.Name = "buttonOpenFile_SOA";
            buttonOpenFile_SOA.Size = new Size(159, 84);
            buttonOpenFile_SOA.TabIndex = 0;
            buttonOpenFile_SOA.Text = "Открыть файл";
            buttonOpenFile_SOA.UseVisualStyleBackColor = true;
            buttonOpenFile_SOA.Click += buttonOpenFile_SOA_Click;
            // 
            // groupBoxInfo_SOA
            // 
            groupBoxInfo_SOA.Controls.Add(textBoxInfo_SOA);
            groupBoxInfo_SOA.Dock = DockStyle.Top;
            groupBoxInfo_SOA.Location = new Point(0, 106);
            groupBoxInfo_SOA.Name = "groupBoxInfo_SOA";
            groupBoxInfo_SOA.Size = new Size(1454, 105);
            groupBoxInfo_SOA.TabIndex = 2;
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
            textBoxInfo_SOA.Size = new Size(1448, 75);
            textBoxInfo_SOA.TabIndex = 0;
            textBoxInfo_SOA.Text = resources.GetString("textBoxInfo_SOA.Text");
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 211);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxInput_SOA);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxResult_SOA);
            splitContainer1.Size = new Size(1454, 680);
            splitContainer1.SplitterDistance = 741;
            splitContainer1.TabIndex = 3;
            // 
            // groupBoxInput_SOA
            // 
            groupBoxInput_SOA.Controls.Add(textBoxInput_SOA);
            groupBoxInput_SOA.Dock = DockStyle.Fill;
            groupBoxInput_SOA.Location = new Point(0, 0);
            groupBoxInput_SOA.Name = "groupBoxInput_SOA";
            groupBoxInput_SOA.Size = new Size(741, 680);
            groupBoxInput_SOA.TabIndex = 0;
            groupBoxInput_SOA.TabStop = false;
            groupBoxInput_SOA.Text = "Ввод";
            // 
            // textBoxInput_SOA
            // 
            textBoxInput_SOA.Dock = DockStyle.Fill;
            textBoxInput_SOA.Location = new Point(3, 27);
            textBoxInput_SOA.Multiline = true;
            textBoxInput_SOA.Name = "textBoxInput_SOA";
            textBoxInput_SOA.ReadOnly = true;
            textBoxInput_SOA.ScrollBars = ScrollBars.Vertical;
            textBoxInput_SOA.Size = new Size(735, 650);
            textBoxInput_SOA.TabIndex = 0;
            // 
            // groupBoxResult_SOA
            // 
            groupBoxResult_SOA.Controls.Add(textBoxResult_SOA);
            groupBoxResult_SOA.Dock = DockStyle.Fill;
            groupBoxResult_SOA.Location = new Point(0, 0);
            groupBoxResult_SOA.Name = "groupBoxResult_SOA";
            groupBoxResult_SOA.Size = new Size(709, 680);
            groupBoxResult_SOA.TabIndex = 0;
            groupBoxResult_SOA.TabStop = false;
            groupBoxResult_SOA.Text = "Вывод";
            // 
            // textBoxResult_SOA
            // 
            textBoxResult_SOA.Dock = DockStyle.Fill;
            textBoxResult_SOA.Location = new Point(3, 27);
            textBoxResult_SOA.Multiline = true;
            textBoxResult_SOA.Name = "textBoxResult_SOA";
            textBoxResult_SOA.ReadOnly = true;
            textBoxResult_SOA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SOA.Size = new Size(703, 650);
            textBoxResult_SOA.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 891);
            Controls.Add(splitContainer1);
            Controls.Add(groupBoxInfo_SOA);
            Controls.Add(panelButton_SOA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 14 | Самоловова О.А.";
            panelButton_SOA.ResumeLayout(false);
            groupBoxInfo_SOA.ResumeLayout(false);
            groupBoxInfo_SOA.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxInput_SOA.ResumeLayout(false);
            groupBoxInput_SOA.PerformLayout();
            groupBoxResult_SOA.ResumeLayout(false);
            groupBoxResult_SOA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
        private Panel panelButton_SOA;
        private Button buttonInfo_SOA;
        private Button buttonDone_SOA;
        private Button buttonOpenFile_SOA;
        private GroupBox groupBoxInfo_SOA;
        private TextBox textBoxInfo_SOA;
        private SplitContainer splitContainer1;
        private GroupBox groupBoxInput_SOA;
        private TextBox textBoxInput_SOA;
        private GroupBox groupBoxResult_SOA;
        private TextBox textBoxResult_SOA;
    }
}
