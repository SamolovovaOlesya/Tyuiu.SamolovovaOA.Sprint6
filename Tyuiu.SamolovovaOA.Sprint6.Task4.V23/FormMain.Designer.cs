namespace Tyuiu.SamolovovaOA.Sprint6.Task4.V23
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
            splitter1 = new Splitter();
            panel4 = new Panel();
            formsPlotFunction_SOA = new ScottPlot.WinForms.FormsPlot();
            panel3 = new Panel();
            groupBoxResult_SOA = new GroupBox();
            textBoxResult_SOA = new TextBox();
            panel2 = new Panel();
            buttonSave_SOA = new Button();
            buttonHelp_SOA = new Button();
            buttonDone_SOA = new Button();
            groupBoxInput_SOA = new GroupBox();
            labelStop_SOA = new Label();
            labelStart_SOA = new Label();
            textBoxStop_SOA = new TextBox();
            textBoxStart_SOA = new TextBox();
            groupBoxCondition_SOA = new GroupBox();
            textBoxCondition_SOA = new TextBox();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxResult_SOA.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxInput_SOA.SuspendLayout();
            groupBoxCondition_SOA.SuspendLayout();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Location = new Point(528, 150);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 728);
            splitter1.TabIndex = 8;
            splitter1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(formsPlotFunction_SOA);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(528, 150);
            panel4.Name = "panel4";
            panel4.Size = new Size(1103, 728);
            panel4.TabIndex = 7;
            // 
            // formsPlotFunction_SOA
            // 
            formsPlotFunction_SOA.DisplayScale = 1.5F;
            formsPlotFunction_SOA.Dock = DockStyle.Fill;
            formsPlotFunction_SOA.Location = new Point(0, 0);
            formsPlotFunction_SOA.Name = "formsPlotFunction_SOA";
            formsPlotFunction_SOA.Size = new Size(1103, 728);
            formsPlotFunction_SOA.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(groupBoxResult_SOA);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(528, 728);
            panel3.TabIndex = 6;
            // 
            // groupBoxResult_SOA
            // 
            groupBoxResult_SOA.Controls.Add(textBoxResult_SOA);
            groupBoxResult_SOA.Dock = DockStyle.Fill;
            groupBoxResult_SOA.Location = new Point(0, 0);
            groupBoxResult_SOA.Name = "groupBoxResult_SOA";
            groupBoxResult_SOA.Size = new Size(528, 728);
            groupBoxResult_SOA.TabIndex = 0;
            groupBoxResult_SOA.TabStop = false;
            groupBoxResult_SOA.Text = "Вывод:";
            // 
            // textBoxResult_SOA
            // 
            textBoxResult_SOA.Dock = DockStyle.Fill;
            textBoxResult_SOA.Location = new Point(3, 27);
            textBoxResult_SOA.Multiline = true;
            textBoxResult_SOA.Name = "textBoxResult_SOA";
            textBoxResult_SOA.ReadOnly = true;
            textBoxResult_SOA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SOA.Size = new Size(522, 698);
            textBoxResult_SOA.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(buttonSave_SOA);
            panel2.Controls.Add(buttonHelp_SOA);
            panel2.Controls.Add(buttonDone_SOA);
            panel2.Controls.Add(groupBoxInput_SOA);
            panel2.Controls.Add(groupBoxCondition_SOA);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1631, 150);
            panel2.TabIndex = 5;
            // 
            // buttonSave_SOA
            // 
            buttonSave_SOA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave_SOA.BackColor = Color.Green;
            buttonSave_SOA.Location = new Point(1245, 36);
            buttonSave_SOA.Name = "buttonSave_SOA";
            buttonSave_SOA.Size = new Size(151, 98);
            buttonSave_SOA.TabIndex = 7;
            buttonSave_SOA.Text = "Сохранить";
            buttonSave_SOA.UseVisualStyleBackColor = false;
            buttonSave_SOA.Click += buttonSave_SOA_Click;
            // 
            // buttonHelp_SOA
            // 
            buttonHelp_SOA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SOA.BackColor = Color.SteelBlue;
            buttonHelp_SOA.Location = new Point(1468, 36);
            buttonHelp_SOA.Name = "buttonHelp_SOA";
            buttonHelp_SOA.Size = new Size(151, 98);
            buttonHelp_SOA.TabIndex = 6;
            buttonHelp_SOA.Text = "Справка";
            buttonHelp_SOA.UseVisualStyleBackColor = false;
            buttonHelp_SOA.Click += buttonHelp_SOA_Click;
            // 
            // buttonDone_SOA
            // 
            buttonDone_SOA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_SOA.BackColor = Color.Green;
            buttonDone_SOA.Location = new Point(1088, 36);
            buttonDone_SOA.Name = "buttonDone_SOA";
            buttonDone_SOA.Size = new Size(151, 98);
            buttonDone_SOA.TabIndex = 5;
            buttonDone_SOA.Text = "Выполнить";
            buttonDone_SOA.UseVisualStyleBackColor = false;
            buttonDone_SOA.Click += buttonDone_SOA_Click;
            // 
            // groupBoxInput_SOA
            // 
            groupBoxInput_SOA.Controls.Add(labelStop_SOA);
            groupBoxInput_SOA.Controls.Add(labelStart_SOA);
            groupBoxInput_SOA.Controls.Add(textBoxStop_SOA);
            groupBoxInput_SOA.Controls.Add(textBoxStart_SOA);
            groupBoxInput_SOA.Location = new Point(644, 13);
            groupBoxInput_SOA.Name = "groupBoxInput_SOA";
            groupBoxInput_SOA.Size = new Size(438, 131);
            groupBoxInput_SOA.TabIndex = 1;
            groupBoxInput_SOA.TabStop = false;
            groupBoxInput_SOA.Text = "Ввод данных:";
            // 
            // labelStop_SOA
            // 
            labelStop_SOA.AutoSize = true;
            labelStop_SOA.Location = new Point(263, 45);
            labelStop_SOA.Name = "labelStop_SOA";
            labelStop_SOA.Size = new Size(111, 25);
            labelStop_SOA.TabIndex = 3;
            labelStop_SOA.Text = "Конец шага:";
            // 
            // labelStart_SOA
            // 
            labelStart_SOA.AutoSize = true;
            labelStart_SOA.Location = new Point(35, 45);
            labelStart_SOA.Name = "labelStart_SOA";
            labelStart_SOA.Size = new Size(105, 25);
            labelStart_SOA.TabIndex = 2;
            labelStart_SOA.Text = "Старт шага:";
            // 
            // textBoxStop_SOA
            // 
            textBoxStop_SOA.Location = new Point(263, 77);
            textBoxStop_SOA.Name = "textBoxStop_SOA";
            textBoxStop_SOA.Size = new Size(160, 31);
            textBoxStop_SOA.TabIndex = 1;
            // 
            // textBoxStart_SOA
            // 
            textBoxStart_SOA.Location = new Point(35, 77);
            textBoxStart_SOA.Name = "textBoxStart_SOA";
            textBoxStart_SOA.Size = new Size(160, 31);
            textBoxStart_SOA.TabIndex = 0;
            // 
            // groupBoxCondition_SOA
            // 
            groupBoxCondition_SOA.Controls.Add(textBoxCondition_SOA);
            groupBoxCondition_SOA.Location = new Point(6, 9);
            groupBoxCondition_SOA.Name = "groupBoxCondition_SOA";
            groupBoxCondition_SOA.Size = new Size(625, 131);
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
            textBoxCondition_SOA.Size = new Size(619, 101);
            textBoxCondition_SOA.TabIndex = 0;
            textBoxCondition_SOA.TabStop = false;
            textBoxCondition_SOA.Text = "Написать программу, которая выводит таблицу значений функции:\r\nF(x) = 4 - 2x + 2+cos(x) / 2x-2\r\n(произвести табулирование) f(x) на заданном диапазоне [-5; 5]\r\nс шагом 1. \r\n";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1631, 878);
            Controls.Add(splitter1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 23 | Самоловова О.А.";
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBoxResult_SOA.ResumeLayout(false);
            groupBoxResult_SOA.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxInput_SOA.ResumeLayout(false);
            groupBoxInput_SOA.PerformLayout();
            groupBoxCondition_SOA.ResumeLayout(false);
            groupBoxCondition_SOA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Splitter splitter1;
        private Panel panel4;
        private ScottPlot.WinForms.FormsPlot formsPlotFunction_SOA;
        private Panel panel3;
        private GroupBox groupBoxResult_SOA;
        private TextBox textBoxResult_SOA;
        private Panel panel2;
        private GroupBox groupBoxInput_SOA;
        private Label labelStop_SOA;
        private Label labelStart_SOA;
        private TextBox textBoxStop_SOA;
        private TextBox textBoxStart_SOA;
        private GroupBox groupBoxCondition_SOA;
        private TextBox textBoxCondition_SOA;
        private Button buttonSave_SOA;
        private Button buttonHelp_SOA;
        private Button buttonDone_SOA;
    }
}
