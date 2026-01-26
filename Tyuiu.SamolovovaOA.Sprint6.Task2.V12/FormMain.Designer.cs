namespace Tyuiu.SamolovovaOA.Sprint6.Task2.V12
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
            formsPlotFunction = new ScottPlot.WinForms.FormsPlot();
            buttonDone_SOA = new Button();
            buttonHelp_SOA = new Button();
            groupBoxResult_SOA = new GroupBox();
            dataGridViewFunction = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            labelResult_SOA = new Label();
            groupBoxInput_SOA = new GroupBox();
            labelEndStep_SOA = new Label();
            textBoxStopStep_SOA = new TextBox();
            labelStartStep_SOA = new Label();
            textBoxStartStep_SOA = new TextBox();
            groupBoxTask_SOA = new GroupBox();
            textBoxTask_SOA = new TextBox();
            groupBoxResult_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            groupBoxInput_SOA.SuspendLayout();
            groupBoxTask_SOA.SuspendLayout();
            SuspendLayout();
            // 
            // formsPlotFunction
            // 
            formsPlotFunction.DisplayScale = 1.5F;
            formsPlotFunction.Location = new Point(808, 15);
            formsPlotFunction.Name = "formsPlotFunction";
            formsPlotFunction.Size = new Size(333, 405);
            formsPlotFunction.TabIndex = 21;
            // 
            // buttonDone_SOA
            // 
            buttonDone_SOA.BackColor = SystemColors.MenuHighlight;
            buttonDone_SOA.Location = new Point(451, 326);
            buttonDone_SOA.Name = "buttonDone_SOA";
            buttonDone_SOA.Size = new Size(136, 84);
            buttonDone_SOA.TabIndex = 20;
            buttonDone_SOA.Text = "Выполнить";
            buttonDone_SOA.UseVisualStyleBackColor = false;
            buttonDone_SOA.Click += buttonDone_SOA_Click;
            buttonDone_SOA.MouseDown += buttonDone_SOA_MouseDown;
            buttonDone_SOA.MouseEnter += buttonDone_SOA_MouseEnter;
            buttonDone_SOA.MouseLeave += buttonDone_SOA_MouseLeave;
            // 
            // buttonHelp_SOA
            // 
            buttonHelp_SOA.BackColor = Color.Green;
            buttonHelp_SOA.Location = new Point(339, 325);
            buttonHelp_SOA.Name = "buttonHelp_SOA";
            buttonHelp_SOA.Size = new Size(106, 84);
            buttonHelp_SOA.TabIndex = 19;
            buttonHelp_SOA.Text = "Справка";
            buttonHelp_SOA.UseVisualStyleBackColor = false;
            buttonHelp_SOA.Click += buttonHelp_SOA_Click;
            // 
            // groupBoxResult_SOA
            // 
            groupBoxResult_SOA.Controls.Add(dataGridViewFunction);
            groupBoxResult_SOA.Controls.Add(labelResult_SOA);
            groupBoxResult_SOA.Location = new Point(594, 12);
            groupBoxResult_SOA.Name = "groupBoxResult_SOA";
            groupBoxResult_SOA.Size = new Size(199, 398);
            groupBoxResult_SOA.TabIndex = 18;
            groupBoxResult_SOA.TabStop = false;
            groupBoxResult_SOA.Text = "Вывод данных:";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.AllowUserToAddRows = false;
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewFunction.Location = new Point(0, 72);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 62;
            dataGridViewFunction.Size = new Size(181, 325);
            dataGridViewFunction.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "X";
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "F(x)";
            Column2.HeaderText = "F(x)";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 80;
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
            // groupBoxInput_SOA
            // 
            groupBoxInput_SOA.Controls.Add(labelEndStep_SOA);
            groupBoxInput_SOA.Controls.Add(textBoxStopStep_SOA);
            groupBoxInput_SOA.Controls.Add(labelStartStep_SOA);
            groupBoxInput_SOA.Controls.Add(textBoxStartStep_SOA);
            groupBoxInput_SOA.Location = new Point(12, 314);
            groupBoxInput_SOA.Name = "groupBoxInput_SOA";
            groupBoxInput_SOA.Size = new Size(309, 96);
            groupBoxInput_SOA.TabIndex = 17;
            groupBoxInput_SOA.TabStop = false;
            groupBoxInput_SOA.Text = "Ввод данных:";
            // 
            // labelEndStep_SOA
            // 
            labelEndStep_SOA.AutoSize = true;
            labelEndStep_SOA.Location = new Point(171, 27);
            labelEndStep_SOA.Name = "labelEndStep_SOA";
            labelEndStep_SOA.Size = new Size(111, 25);
            labelEndStep_SOA.TabIndex = 5;
            labelEndStep_SOA.Text = "Конец шага:";
            // 
            // textBoxStopStep_SOA
            // 
            textBoxStopStep_SOA.Location = new Point(171, 65);
            textBoxStopStep_SOA.Name = "textBoxStopStep_SOA";
            textBoxStopStep_SOA.Size = new Size(126, 31);
            textBoxStopStep_SOA.TabIndex = 4;
            // 
            // labelStartStep_SOA
            // 
            labelStartStep_SOA.AutoSize = true;
            labelStartStep_SOA.Location = new Point(16, 27);
            labelStartStep_SOA.Name = "labelStartStep_SOA";
            labelStartStep_SOA.Size = new Size(105, 25);
            labelStartStep_SOA.TabIndex = 3;
            labelStartStep_SOA.Text = "Старт шага:";
            // 
            // textBoxStartStep_SOA
            // 
            textBoxStartStep_SOA.Location = new Point(16, 62);
            textBoxStartStep_SOA.Name = "textBoxStartStep_SOA";
            textBoxStartStep_SOA.Size = new Size(126, 31);
            textBoxStartStep_SOA.TabIndex = 0;
            // 
            // groupBoxTask_SOA
            // 
            groupBoxTask_SOA.Controls.Add(textBoxTask_SOA);
            groupBoxTask_SOA.Location = new Point(12, 12);
            groupBoxTask_SOA.Name = "groupBoxTask_SOA";
            groupBoxTask_SOA.Size = new Size(576, 296);
            groupBoxTask_SOA.TabIndex = 16;
            groupBoxTask_SOA.TabStop = false;
            groupBoxTask_SOA.Text = "Условие:";
            // 
            // textBoxTask_SOA
            // 
            textBoxTask_SOA.BackColor = SystemColors.Menu;
            textBoxTask_SOA.ForeColor = SystemColors.InfoText;
            textBoxTask_SOA.Location = new Point(16, 37);
            textBoxTask_SOA.Multiline = true;
            textBoxTask_SOA.Name = "textBoxTask_SOA";
            textBoxTask_SOA.ReadOnly = true;
            textBoxTask_SOA.ShortcutsEnabled = false;
            textBoxTask_SOA.Size = new Size(551, 241);
            textBoxTask_SOA.TabIndex = 1;
            textBoxTask_SOA.TabStop = false;
            textBoxTask_SOA.Text = "Программа производит табулирование функции по формуле:\r\nF(x) = ((2x + 6) / (cos(x) + x)) - 3\r\n\r\n\r\n";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 423);
            Controls.Add(formsPlotFunction);
            Controls.Add(buttonDone_SOA);
            Controls.Add(buttonHelp_SOA);
            Controls.Add(groupBoxResult_SOA);
            Controls.Add(groupBoxInput_SOA);
            Controls.Add(groupBoxTask_SOA);
            Name = "FormMain";
            Text = "Form1";
            groupBoxResult_SOA.ResumeLayout(false);
            groupBoxResult_SOA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            groupBoxInput_SOA.ResumeLayout(false);
            groupBoxInput_SOA.PerformLayout();
            groupBoxTask_SOA.ResumeLayout(false);
            groupBoxTask_SOA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlotFunction;
        private Button buttonDone_SOA;
        private Button buttonHelp_SOA;
        private GroupBox groupBoxResult_SOA;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label labelResult_SOA;
        private GroupBox groupBoxInput_SOA;
        private Label labelEndStep_SOA;
        private TextBox textBoxStopStep_SOA;
        private Label labelStartStep_SOA;
        private TextBox textBoxStartStep_SOA;
        private GroupBox groupBoxTask_SOA;
        private TextBox textBoxTask_SOA;
    }
}
