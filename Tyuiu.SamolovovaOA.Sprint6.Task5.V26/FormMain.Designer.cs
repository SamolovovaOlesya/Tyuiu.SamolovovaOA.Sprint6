namespace Tyuiu.SamolovovaOA.Sprint6.Task5.V26
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            splitter1 = new Splitter();
            panel4 = new Panel();
            panel3 = new Panel();
            groupBoxResult_SOA = new GroupBox();
            dataGridViewNums_SOA = new DataGridView();
            panel2 = new Panel();
            buttonH_SOA = new Button();
            buttonOpenFile_SOA = new Button();
            buttonD_SOA = new Button();
            groupBoxCondition_SOA = new GroupBox();
            textBoxCondition_SOA = new TextBox();
            formsPlot_SOA = new ScottPlot.WinForms.FormsPlot();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxResult_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_SOA).BeginInit();
            panel2.SuspendLayout();
            groupBoxCondition_SOA.SuspendLayout();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Location = new Point(528, 150);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 712);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(formsPlot_SOA);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(528, 150);
            panel4.Name = "panel4";
            panel4.Size = new Size(1088, 712);
            panel4.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(groupBoxResult_SOA);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(528, 712);
            panel3.TabIndex = 10;
            // 
            // groupBoxResult_SOA
            // 
            groupBoxResult_SOA.Controls.Add(dataGridViewNums_SOA);
            groupBoxResult_SOA.Dock = DockStyle.Fill;
            groupBoxResult_SOA.Location = new Point(0, 0);
            groupBoxResult_SOA.Name = "groupBoxResult_SOA";
            groupBoxResult_SOA.Size = new Size(528, 712);
            groupBoxResult_SOA.TabIndex = 0;
            groupBoxResult_SOA.TabStop = false;
            groupBoxResult_SOA.Text = "Вывод:";
            // 
            // dataGridViewNums_SOA
            // 
            dataGridViewNums_SOA.AllowUserToAddRows = false;
            dataGridViewNums_SOA.AllowUserToDeleteRows = false;
            dataGridViewNums_SOA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_SOA.ColumnHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.White;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewNums_SOA.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewNums_SOA.Dock = DockStyle.Fill;
            dataGridViewNums_SOA.Location = new Point(3, 27);
            dataGridViewNums_SOA.MultiSelect = false;
            dataGridViewNums_SOA.Name = "dataGridViewNums_SOA";
            dataGridViewNums_SOA.ReadOnly = true;
            dataGridViewNums_SOA.RowHeadersVisible = false;
            dataGridViewNums_SOA.RowHeadersWidth = 62;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewNums_SOA.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewNums_SOA.Size = new Size(522, 682);
            dataGridViewNums_SOA.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(buttonH_SOA);
            panel2.Controls.Add(buttonOpenFile_SOA);
            panel2.Controls.Add(buttonD_SOA);
            panel2.Controls.Add(groupBoxCondition_SOA);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1616, 150);
            panel2.TabIndex = 9;
            // 
            // buttonH_SOA
            // 
            buttonH_SOA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonH_SOA.BackColor = Color.SteelBlue;
            buttonH_SOA.Location = new Point(1454, 21);
            buttonH_SOA.Name = "buttonH_SOA";
            buttonH_SOA.Size = new Size(151, 98);
            buttonH_SOA.TabIndex = 13;
            buttonH_SOA.Text = "Справка";
            buttonH_SOA.UseVisualStyleBackColor = false;
            buttonH_SOA.Click += buttonH_SOA_Click;
            // 
            // buttonOpenFile_SOA
            // 
            buttonOpenFile_SOA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenFile_SOA.BackColor = Color.Green;
            buttonOpenFile_SOA.Location = new Point(1284, 21);
            buttonOpenFile_SOA.Name = "buttonOpenFile_SOA";
            buttonOpenFile_SOA.Size = new Size(151, 98);
            buttonOpenFile_SOA.TabIndex = 14;
            buttonOpenFile_SOA.Text = "Открыть файл";
            buttonOpenFile_SOA.UseVisualStyleBackColor = false;
            buttonOpenFile_SOA.Click += buttonOpenFile_SOA_Click;
            // 
            // buttonD_SOA
            // 
            buttonD_SOA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonD_SOA.BackColor = Color.Green;
            buttonD_SOA.Location = new Point(1110, 21);
            buttonD_SOA.Name = "buttonD_SOA";
            buttonD_SOA.Size = new Size(151, 98);
            buttonD_SOA.TabIndex = 12;
            buttonD_SOA.Text = "Выполнить";
            buttonD_SOA.UseVisualStyleBackColor = false;
            buttonD_SOA.Click += buttonD_SOA_Click;
            // 
            // groupBoxCondition_SOA
            // 
            groupBoxCondition_SOA.Controls.Add(textBoxCondition_SOA);
            groupBoxCondition_SOA.Location = new Point(6, 9);
            groupBoxCondition_SOA.Name = "groupBoxCondition_SOA";
            groupBoxCondition_SOA.Size = new Size(791, 131);
            groupBoxCondition_SOA.TabIndex = 0;
            groupBoxCondition_SOA.TabStop = false;
            groupBoxCondition_SOA.Text = "Условие:";
            // 
            // textBoxCondition_SOA
            // 
            textBoxCondition_SOA.Dock = DockStyle.Fill;
            textBoxCondition_SOA.Location = new Point(3, 27);
            textBoxCondition_SOA.Multiline = true;
            textBoxCondition_SOA.Name = "textBoxCondition_SOA";
            textBoxCondition_SOA.ReadOnly = true;
            textBoxCondition_SOA.Size = new Size(785, 101);
            textBoxCondition_SOA.TabIndex = 0;
            textBoxCondition_SOA.TabStop = false;
            textBoxCondition_SOA.Text = "Прочитать данные из файла InPutFileTask5V26.txt. Вывести в dataGridView. Дан список из чисел. Вывести все числа, кратные 5.\r\n";
            // 
            // formsPlot_SOA
            // 
            formsPlot_SOA.DisplayScale = 1.5F;
            formsPlot_SOA.Dock = DockStyle.Fill;
            formsPlot_SOA.Location = new Point(0, 0);
            formsPlot_SOA.Name = "formsPlot_SOA";
            formsPlot_SOA.Size = new Size(1088, 712);
            formsPlot_SOA.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1616, 862);
            Controls.Add(splitter1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 26 | Самоловова О.А.";
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBoxResult_SOA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_SOA).EndInit();
            panel2.ResumeLayout(false);
            groupBoxCondition_SOA.ResumeLayout(false);
            groupBoxCondition_SOA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Splitter splitter1;
        private Panel panel4;
        private Panel panel3;
        private GroupBox groupBoxResult_SOA;
        private DataGridView dataGridViewNums_SOA;
        private Panel panel2;
        private Button buttonH_SOA;
        private Button buttonOpenFile_SOA;
        private Button buttonD_SOA;
        private GroupBox groupBoxCondition_SOA;
        private TextBox textBoxCondition_SOA;
        private ScottPlot.WinForms.FormsPlot formsPlot_SOA;
    }
}
