namespace Tyuiu.SamolovovaOA.Sprint6.Task1.V26
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
            buttonDone_SOA = new Button();
            buttonHelp_SOA = new Button();
            groupBoxResult_SOA = new GroupBox();
            labelResult_SOA = new Label();
            textBoxResult_SOA = new TextBox();
            groupBoxInput_SOA = new GroupBox();
            labelEndStep_SOA = new Label();
            textBoxStopStep_SOA = new TextBox();
            labelStartStep_SOA = new Label();
            textBoxStartStep_SOA = new TextBox();
            groupBoxTask_SOA = new GroupBox();
            textBoxTask_SOA = new TextBox();
            groupBoxResult_SOA.SuspendLayout();
            groupBoxInput_SOA.SuspendLayout();
            groupBoxTask_SOA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_SOA
            // 
            buttonDone_SOA.BackColor = SystemColors.MenuHighlight;
            buttonDone_SOA.Location = new Point(573, 358);
            buttonDone_SOA.Name = "buttonDone_SOA";
            buttonDone_SOA.Size = new Size(159, 84);
            buttonDone_SOA.TabIndex = 14;
            buttonDone_SOA.Text = "Выполнить";
            buttonDone_SOA.UseVisualStyleBackColor = false;
            buttonDone_SOA.Click += buttonDone_SOA_Click;
            // 
            // buttonHelp_SOA
            // 
            buttonHelp_SOA.BackColor = Color.Green;
            buttonHelp_SOA.Location = new Point(422, 358);
            buttonHelp_SOA.Name = "buttonHelp_SOA";
            buttonHelp_SOA.Size = new Size(145, 84);
            buttonHelp_SOA.TabIndex = 13;
            buttonHelp_SOA.Text = "Справка";
            buttonHelp_SOA.UseVisualStyleBackColor = false;
            buttonHelp_SOA.Click += buttonHelp_SOA_Click;
            // 
            // groupBoxResult_SOA
            // 
            groupBoxResult_SOA.Controls.Add(labelResult_SOA);
            groupBoxResult_SOA.Controls.Add(textBoxResult_SOA);
            groupBoxResult_SOA.Location = new Point(738, 34);
            groupBoxResult_SOA.Name = "groupBoxResult_SOA";
            groupBoxResult_SOA.Size = new Size(264, 408);
            groupBoxResult_SOA.TabIndex = 12;
            groupBoxResult_SOA.TabStop = false;
            groupBoxResult_SOA.Text = "Вывод данных:";
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
            // textBoxResult_SOA
            // 
            textBoxResult_SOA.BackColor = SystemColors.Menu;
            textBoxResult_SOA.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_SOA.Location = new Point(14, 63);
            textBoxResult_SOA.Multiline = true;
            textBoxResult_SOA.Name = "textBoxResult_SOA";
            textBoxResult_SOA.ReadOnly = true;
            textBoxResult_SOA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SOA.ShortcutsEnabled = false;
            textBoxResult_SOA.Size = new Size(233, 332);
            textBoxResult_SOA.TabIndex = 0;
            textBoxResult_SOA.TabStop = false;
            // 
            // groupBoxInput_SOA
            // 
            groupBoxInput_SOA.Controls.Add(labelEndStep_SOA);
            groupBoxInput_SOA.Controls.Add(textBoxStopStep_SOA);
            groupBoxInput_SOA.Controls.Add(labelStartStep_SOA);
            groupBoxInput_SOA.Controls.Add(textBoxStartStep_SOA);
            groupBoxInput_SOA.Location = new Point(8, 346);
            groupBoxInput_SOA.Name = "groupBoxInput_SOA";
            groupBoxInput_SOA.Size = new Size(408, 96);
            groupBoxInput_SOA.TabIndex = 11;
            groupBoxInput_SOA.TabStop = false;
            groupBoxInput_SOA.Text = "Ввод данных:";
            // 
            // labelEndStep_SOA
            // 
            labelEndStep_SOA.AutoSize = true;
            labelEndStep_SOA.Location = new Point(230, 27);
            labelEndStep_SOA.Name = "labelEndStep_SOA";
            labelEndStep_SOA.Size = new Size(111, 25);
            labelEndStep_SOA.TabIndex = 5;
            labelEndStep_SOA.Text = "Конец шага:";
            // 
            // textBoxStopStep_SOA
            // 
            textBoxStopStep_SOA.Location = new Point(230, 62);
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
            groupBoxTask_SOA.Location = new Point(8, 34);
            groupBoxTask_SOA.Name = "groupBoxTask_SOA";
            groupBoxTask_SOA.Size = new Size(724, 296);
            groupBoxTask_SOA.TabIndex = 10;
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
            textBoxTask_SOA.Size = new Size(688, 241);
            textBoxTask_SOA.TabIndex = 1;
            textBoxTask_SOA.TabStop = false;
            textBoxTask_SOA.Text = "Программа производит табулирование функции по формуле:\r\nF(x) = ((2cos(x) + 2) /( 2x - 1)) + cos(x) - 5x + 3;\r\n\r\n";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 476);
            Controls.Add(buttonDone_SOA);
            Controls.Add(buttonHelp_SOA);
            Controls.Add(groupBoxResult_SOA);
            Controls.Add(groupBoxInput_SOA);
            Controls.Add(groupBoxTask_SOA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 26 | Самоловова О.А.";
            groupBoxResult_SOA.ResumeLayout(false);
            groupBoxResult_SOA.PerformLayout();
            groupBoxInput_SOA.ResumeLayout(false);
            groupBoxInput_SOA.PerformLayout();
            groupBoxTask_SOA.ResumeLayout(false);
            groupBoxTask_SOA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_SOA;
        private Button buttonHelp_SOA;
        private GroupBox groupBoxResult_SOA;
        private Label labelResult_SOA;
        private TextBox textBoxResult_SOA;
        private GroupBox groupBoxInput_SOA;
        private Label labelEndStep_SOA;
        private TextBox textBoxStopStep_SOA;
        private Label labelStartStep_SOA;
        private TextBox textBoxStartStep_SOA;
        private GroupBox groupBoxTask_SOA;
        private TextBox textBoxTask_SOA;
    }
}
