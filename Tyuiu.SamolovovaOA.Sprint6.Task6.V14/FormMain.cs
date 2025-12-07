namespace Tyuiu.SamolovovaOA.Sprint6.Task6.V14
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelIn_SOA;
        private System.Windows.Forms.Label labelOut_SOA;
        private System.Windows.Forms.TextBox textBoxIn_SOA;
        private System.Windows.Forms.TextBox textBoxOut_SOA;
        private System.Windows.Forms.Button buttonOpenFile_SOA;
        private System.Windows.Forms.Button buttonHelp_SOA;
        private System.Windows.Forms.Button buttonSave_SOA;
        private System.Windows.Forms.Label labelFileName_SOA;
        private System.Windows.Forms.Label labelStatus_SOA;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelIn_SOA = new System.Windows.Forms.Label();
            this.labelOut_SOA = new System.Windows.Forms.Label();
            this.textBoxIn_SOA = new System.Windows.Forms.TextBox();
            this.textBoxOut_SOA = new System.Windows.Forms.TextBox();
            this.buttonOpenFile_SOA = new System.Windows.Forms.Button();
            this.buttonHelp_SOA = new System.Windows.Forms.Button();
            this.buttonSave_SOA = new System.Windows.Forms.Button();
            this.labelFileName_SOA = new System.Windows.Forms.Label();
            this.labelStatus_SOA = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // labelIn_SOA
            this.labelIn_SOA.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelIn_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIn_SOA.Location = new System.Drawing.Point(10, 10);
            this.labelIn_SOA.Name = "labelIn_SOA";
            this.labelIn_SOA.Size = new System.Drawing.Size(380, 25);
            this.labelIn_SOA.TabIndex = 0;
            this.labelIn_SOA.Text = "Исходный текст:";
            this.labelIn_SOA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // labelOut_SOA
            this.labelOut_SOA.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOut_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOut_SOA.Location = new System.Drawing.Point(10, 10);
            this.labelOut_SOA.Name = "labelOut_SOA";
            this.labelOut_SOA.Size = new System.Drawing.Size(380, 25);
            this.labelOut_SOA.TabIndex = 1;
            this.labelOut_SOA.Text = "Результат (слова с буквой \'z\'):";
            this.labelOut_SOA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // textBoxIn_SOA
            this.textBoxIn_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIn_SOA.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIn_SOA.Location = new System.Drawing.Point(10, 35);
            this.textBoxIn_SOA.Multiline = true;
            this.textBoxIn_SOA.Name = "textBoxIn_SOA";
            this.textBoxIn_SOA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxIn_SOA.Size = new System.Drawing.Size(380, 315);
            this.textBoxIn_SOA.TabIndex = 2;
            this.textBoxIn_SOA.WordWrap = false;

            // textBoxOut_SOA
            this.textBoxOut_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_SOA.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOut_SOA.Location = new System.Drawing.Point(10, 35);
            this.textBoxOut_SOA.Multiline = true;
            this.textBoxOut_SOA.Name = "textBoxOut_SOA";
            this.textBoxOut_SOA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOut_SOA.Size = new System.Drawing.Size(380, 315);
            this.textBoxOut_SOA.TabIndex = 3;
            this.textBoxOut_SOA.WordWrap = false;

            // buttonOpenFile_SOA
            this.buttonOpenFile_SOA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SOA.Image")));
            this.buttonOpenFile_SOA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenFile_SOA.Location = new System.Drawing.Point(20, 15);
            this.buttonOpenFile_SOA.Name = "buttonOpenFile_SOA";
            this.buttonOpenFile_SOA.Size = new System.Drawing.Size(150, 40);
            this.buttonOpenFile_SOA.TabIndex = 4;
            this.buttonOpenFile_SOA.Text = "Открыть файл";
            this.buttonOpenFile_SOA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SOA.Click += new System.EventHandler(this.buttonOpenFile_SOA_Click);

            // buttonHelp_SOA
            this.buttonHelp_SOA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SOA.Image")));
            this.buttonHelp_SOA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp_SOA.Location = new System.Drawing.Point(180, 15);
            this.buttonHelp_SOA.Name = "buttonHelp_SOA";
            this.buttonHelp_SOA.Size = new System.Drawing.Size(120, 40);
            this.buttonHelp_SOA.TabIndex = 5;
            this.buttonHelp_SOA.Text = "Справка";
            this.buttonHelp_SOA.UseVisualStyleBackColor = true;
            this.buttonHelp_SOA.Click += new System.EventHandler(this.buttonHelp_SOA_Click);

            // buttonSave_SOA
            this.buttonSave_SOA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_SOA.Image")));
            this.buttonSave_SOA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave_SOA.Location = new System.Drawing.Point(310, 15);
            this.buttonSave_SOA.Name = "buttonSave_SOA";
            this.buttonSave_SOA.Size = new System.Drawing.Size(180, 40);
            this.buttonSave_SOA.TabIndex = 6;
            this.buttonSave_SOA.Text = "Сохранить результат";
            this.buttonSave_SOA.UseVisualStyleBackColor = true;
            this.buttonSave_SOA.Click += new System.EventHandler(this.buttonSave_SOA_Click);

            // labelFileName_SOA
            this.labelFileName_SOA.AutoSize = true;
            this.labelFileName_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFileName_SOA.Location = new System.Drawing.Point(20, 70);
            this.labelFileName_SOA.Name = "labelFileName_SOA";
            this.labelFileName_SOA.Size = new System.Drawing.Size(103, 13);
            this.labelFileName_SOA.TabIndex = 7;
            this.labelFileName_SOA.Text = "Файл: не выбран";

            // labelStatus_SOA
            this.labelStatus_SOA.AutoSize = true;
            this.labelStatus_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus_SOA.Location = new System.Drawing.Point(20, 90);
            this.labelStatus_SOA.Name = "labelStatus_SOA";
            this.labelStatus_SOA.Size = new System.Drawing.Size(92, 13);
            this.labelStatus_SOA.TabIndex = 8;
            this.labelStatus_SOA.Text = "Готов к работе";

            // panelButtons
            this.panelButtons.Controls.Add(this.buttonOpenFile_SOA);
            this.panelButtons.Controls.Add(this.buttonHelp_SOA);
            this.panelButtons.Controls.Add(this.buttonSave_SOA);
            this.panelButtons.Controls.Add(this.labelFileName_SOA);
            this.panelButtons.Controls.Add(this.labelStatus_SOA);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(20);
            this.panelButtons.Size = new System.Drawing.Size(800, 120);
            this.panelButtons.TabIndex = 9;

            // panelInput
            this.panelInput.Controls.Add(this.textBoxIn_SOA);
            this.panelInput.Controls.Add(this.labelIn_SOA);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput.Location = new System.Drawing.Point(0, 120);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(10);
            this.panelInput.Size = new System.Drawing.Size(400, 360);
            this.panelInput.TabIndex = 10;

            // panelOutput
            this.panelOutput.Controls.Add(this.textBoxOut_SOA);
            this.panelOutput.Controls.Add(this.labelOut_SOA);
            this.panelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutput.Location = new System.Drawing.Point(400, 120);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Padding = new System.Windows.Forms.Padding(10);
            this.panelOutput.Size = new System.Drawing.Size(400, 360);
            this.panelOutput.TabIndex = 11;

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelButtons);
            this.MinimumSize = new System.Drawing.Size(816, 519);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.panelOutput.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}