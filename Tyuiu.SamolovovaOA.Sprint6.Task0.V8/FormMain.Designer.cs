namespace Tyuiu.SamolovovaOA.Sprint6.Task0.V8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDone_SOA = new Button();
            buttonHelp_SOA = new Button();
            groupBoxResult_SOA = new GroupBox();
            textBoxResult_SOA = new TextBox();
            groupBoxInput_SOA = new GroupBox();
            labelVarX_SOA = new Label();
            textBoxVarX_SOA = new TextBox();
            groupBoxTask_SOA = new GroupBox();
            textBoxTask_SOA = new TextBox();
            pictureBoxFormula_SOA = new PictureBox();
            groupBoxResult_SOA.SuspendLayout();
            groupBoxInput_SOA.SuspendLayout();
            groupBoxTask_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SOA).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_SOA
            // 
            buttonDone_SOA.BackColor = SystemColors.ButtonHighlight;
            buttonDone_SOA.Location = new Point(646, 390);
            buttonDone_SOA.Name = "buttonDone_SOA";
            buttonDone_SOA.Size = new Size(138, 38);
            buttonDone_SOA.TabIndex = 9;
            buttonDone_SOA.Text = "Выполнить";
            buttonDone_SOA.UseVisualStyleBackColor = false;
            buttonDone_SOA.Click += buttonDone_SOA_Click;
            // 
            // buttonHelp_SOA
            // 
            buttonHelp_SOA.Location = new Point(573, 390);
            buttonHelp_SOA.Name = "buttonHelp_SOA";
            buttonHelp_SOA.Size = new Size(54, 38);
            buttonHelp_SOA.TabIndex = 8;
            buttonHelp_SOA.Text = "?";
            buttonHelp_SOA.UseVisualStyleBackColor = true;
            buttonHelp_SOA.Click += buttonHelp_SOA_Click;
            // 
            // groupBoxResult_SOA
            // 
            groupBoxResult_SOA.Controls.Add(textBoxResult_SOA);
            groupBoxResult_SOA.Location = new Point(533, 235);
            groupBoxResult_SOA.Name = "groupBoxResult_SOA";
            groupBoxResult_SOA.Size = new Size(251, 108);
            groupBoxResult_SOA.TabIndex = 7;
            groupBoxResult_SOA.TabStop = false;
            groupBoxResult_SOA.Text = "Вывод данных:";
            // 
            // textBoxResult_SOA
            // 
            textBoxResult_SOA.BackColor = SystemColors.Menu;
            textBoxResult_SOA.Location = new Point(19, 62);
            textBoxResult_SOA.Name = "textBoxResult_SOA";
            textBoxResult_SOA.ReadOnly = true;
            textBoxResult_SOA.ShortcutsEnabled = false;
            textBoxResult_SOA.Size = new Size(217, 31);
            textBoxResult_SOA.TabIndex = 0;
            textBoxResult_SOA.TabStop = false;
            // 
            // groupBoxInput_SOA
            // 
            groupBoxInput_SOA.Controls.Add(labelVarX_SOA);
            groupBoxInput_SOA.Controls.Add(textBoxVarX_SOA);
            groupBoxInput_SOA.Location = new Point(16, 235);
            groupBoxInput_SOA.Name = "groupBoxInput_SOA";
            groupBoxInput_SOA.Size = new Size(490, 108);
            groupBoxInput_SOA.TabIndex = 6;
            groupBoxInput_SOA.TabStop = false;
            groupBoxInput_SOA.Text = "Ввод данных:";
            // 
            // labelVarX_SOA
            // 
            labelVarX_SOA.AutoSize = true;
            labelVarX_SOA.Location = new Point(16, 27);
            labelVarX_SOA.Name = "labelVarX_SOA";
            labelVarX_SOA.Size = new Size(134, 25);
            labelVarX_SOA.TabIndex = 3;
            labelVarX_SOA.Text = "Переменная X:";
            // 
            // textBoxVarX_SOA
            // 
            textBoxVarX_SOA.Location = new Point(16, 62);
            textBoxVarX_SOA.Name = "textBoxVarX_SOA";
            textBoxVarX_SOA.Size = new Size(126, 31);
            textBoxVarX_SOA.TabIndex = 0;
            textBoxVarX_SOA.KeyPress += textBoxVarX_SOA_KeyPress;
            // 
            // groupBoxTask_SOA
            // 
            groupBoxTask_SOA.Controls.Add(textBoxTask_SOA);
            groupBoxTask_SOA.Controls.Add(pictureBoxFormula_SOA);
            groupBoxTask_SOA.Location = new Point(16, 23);
            groupBoxTask_SOA.Name = "groupBoxTask_SOA";
            groupBoxTask_SOA.Size = new Size(768, 206);
            groupBoxTask_SOA.TabIndex = 5;
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
            textBoxTask_SOA.Size = new Size(522, 147);
            textBoxTask_SOA.TabIndex = 1;
            textBoxTask_SOA.TabStop = false;
            textBoxTask_SOA.Text = "Вычислить выражение по формуле:\r\n";
            // 
            // pictureBoxFormula_SOA
            // 
            pictureBoxFormula_SOA.Image = (Image)resources.GetObject("pictureBoxFormula_SOA.Image");
            pictureBoxFormula_SOA.Location = new Point(544, 37);
            pictureBoxFormula_SOA.Name = "pictureBoxFormula_SOA";
            pictureBoxFormula_SOA.Size = new Size(218, 118);
            pictureBoxFormula_SOA.TabIndex = 0;
            pictureBoxFormula_SOA.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_SOA);
            Controls.Add(buttonHelp_SOA);
            Controls.Add(groupBoxResult_SOA);
            Controls.Add(groupBoxInput_SOA);
            Controls.Add(groupBoxTask_SOA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 8 | Самоловова О.А.";
            groupBoxResult_SOA.ResumeLayout(false);
            groupBoxResult_SOA.PerformLayout();
            groupBoxInput_SOA.ResumeLayout(false);
            groupBoxInput_SOA.PerformLayout();
            groupBoxTask_SOA.ResumeLayout(false);
            groupBoxTask_SOA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SOA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_SOA;
        private Button buttonHelp_SOA;
        private GroupBox groupBoxResult_SOA;
        private TextBox textBoxResult_SOA;
        private GroupBox groupBoxInput_SOA;
        private Label labelVarX_SOA;
        private TextBox textBoxVarX_SOA;
        private GroupBox groupBoxTask_SOA;
        private TextBox textBoxTask_SOA;
        private PictureBox pictureBoxFormula_SOA;
    }
}
