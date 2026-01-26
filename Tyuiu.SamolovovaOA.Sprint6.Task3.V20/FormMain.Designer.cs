namespace Tyuiu.SamolovovaOA.Sprint6.Task3.V20
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
            groupBoxResult_SOA = new GroupBox();
            dataGridViewResult_SOA = new DataGridView();
            buttonHelp_SOA = new Button();
            labelResult_SOA = new Label();
            buttonDone_SOA = new Button();
            groupBoxTask_SOA = new GroupBox();
            dataGridViewInput_SOA = new DataGridView();
            textBoxTask_SOA = new TextBox();
            groupBoxResult_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SOA).BeginInit();
            groupBoxTask_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_SOA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxResult_SOA
            // 
            groupBoxResult_SOA.Controls.Add(dataGridViewResult_SOA);
            groupBoxResult_SOA.Controls.Add(buttonHelp_SOA);
            groupBoxResult_SOA.Controls.Add(labelResult_SOA);
            groupBoxResult_SOA.Controls.Add(buttonDone_SOA);
            groupBoxResult_SOA.Location = new Point(718, 12);
            groupBoxResult_SOA.Name = "groupBoxResult_SOA";
            groupBoxResult_SOA.Size = new Size(306, 424);
            groupBoxResult_SOA.TabIndex = 19;
            groupBoxResult_SOA.TabStop = false;
            groupBoxResult_SOA.Text = "Вывод данных:";
            // 
            // dataGridViewResult_SOA
            // 
            dataGridViewResult_SOA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResult_SOA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_SOA.ColumnHeadersVisible = false;
            dataGridViewResult_SOA.Location = new Point(25, 62);
            dataGridViewResult_SOA.Name = "dataGridViewResult_SOA";
            dataGridViewResult_SOA.RowHeadersVisible = false;
            dataGridViewResult_SOA.RowHeadersWidth = 62;
            dataGridViewResult_SOA.Size = new Size(275, 170);
            dataGridViewResult_SOA.TabIndex = 2;
            // 
            // buttonHelp_SOA
            // 
            buttonHelp_SOA.BackColor = SystemColors.ButtonHighlight;
            buttonHelp_SOA.Location = new Point(165, 362);
            buttonHelp_SOA.Name = "buttonHelp_SOA";
            buttonHelp_SOA.Size = new Size(57, 56);
            buttonHelp_SOA.TabIndex = 18;
            buttonHelp_SOA.Text = "?";
            buttonHelp_SOA.UseVisualStyleBackColor = false;
            buttonHelp_SOA.Click += buttonHelp_SOA_Click;
            // 
            // labelResult_SOA
            // 
            labelResult_SOA.AutoSize = true;
            labelResult_SOA.Location = new Point(25, 34);
            labelResult_SOA.Name = "labelResult_SOA";
            labelResult_SOA.Size = new Size(93, 25);
            labelResult_SOA.TabIndex = 1;
            labelResult_SOA.Text = "Результат:";
            // 
            // buttonDone_SOA
            // 
            buttonDone_SOA.BackColor = SystemColors.ButtonHighlight;
            buttonDone_SOA.Location = new Point(35, 362);
            buttonDone_SOA.Name = "buttonDone_SOA";
            buttonDone_SOA.Size = new Size(112, 56);
            buttonDone_SOA.TabIndex = 19;
            buttonDone_SOA.Text = "Выполнить";
            buttonDone_SOA.UseVisualStyleBackColor = false;
            buttonDone_SOA.Click += buttonDone_SOA_Click;
            // 
            // groupBoxTask_SOA
            // 
            groupBoxTask_SOA.Controls.Add(dataGridViewInput_SOA);
            groupBoxTask_SOA.Controls.Add(textBoxTask_SOA);
            groupBoxTask_SOA.Location = new Point(12, 12);
            groupBoxTask_SOA.Name = "groupBoxTask_SOA";
            groupBoxTask_SOA.Size = new Size(687, 424);
            groupBoxTask_SOA.TabIndex = 18;
            groupBoxTask_SOA.TabStop = false;
            groupBoxTask_SOA.Text = "Условие:";
            // 
            // dataGridViewInput_SOA
            // 
            dataGridViewInput_SOA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInput_SOA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_SOA.ColumnHeadersVisible = false;
            dataGridViewInput_SOA.Location = new Point(412, 62);
            dataGridViewInput_SOA.Name = "dataGridViewInput_SOA";
            dataGridViewInput_SOA.RowHeadersVisible = false;
            dataGridViewInput_SOA.RowHeadersWidth = 62;
            dataGridViewInput_SOA.Size = new Size(269, 170);
            dataGridViewInput_SOA.TabIndex = 3;
            // 
            // textBoxTask_SOA
            // 
            textBoxTask_SOA.BackColor = SystemColors.Menu;
            textBoxTask_SOA.ForeColor = SystemColors.InfoText;
            textBoxTask_SOA.Location = new Point(0, 37);
            textBoxTask_SOA.Multiline = true;
            textBoxTask_SOA.Name = "textBoxTask_SOA";
            textBoxTask_SOA.ReadOnly = true;
            textBoxTask_SOA.ShortcutsEnabled = false;
            textBoxTask_SOA.Size = new Size(406, 380);
            textBoxTask_SOA.TabIndex = 1;
            textBoxTask_SOA.TabStop = false;
            textBoxTask_SOA.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в пятой строке на 0.\r\n\r\n\r\n\r\n-14  17 -19   3   2\r\n\r\n  -4 -14 -19  -9  -1\r\n\r\n   1   0  13  14   8\r\n\r\n  13   7   8  -3 -15\r\n\r\n   2 -20  12 -14   4\r\n";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 450);
            Controls.Add(groupBoxResult_SOA);
            Controls.Add(groupBoxTask_SOA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 20 | Самоловова О.А.";
            Load += FormMain_Load;
            groupBoxResult_SOA.ResumeLayout(false);
            groupBoxResult_SOA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SOA).EndInit();
            groupBoxTask_SOA.ResumeLayout(false);
            groupBoxTask_SOA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_SOA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxResult_SOA;
        private DataGridView dataGridViewResult_SOA;
        private Button buttonHelp_SOA;
        private Label labelResult_SOA;
        private Button buttonDone_SOA;
        private GroupBox groupBoxTask_SOA;
        private DataGridView dataGridViewInput_SOA;
        private TextBox textBoxTask_SOA;
    }
}
