namespace Tyuiu.SamolovovaOA.Sprint6.Task7.V10
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewIn_SOA;
        private System.Windows.Forms.DataGridView dataGridViewOut_SOA;
        private System.Windows.Forms.Button buttonOpenFile_SOA;
        private System.Windows.Forms.Button buttonSave_SOA;
        private System.Windows.Forms.Button buttonHelp_SOA;
        private System.Windows.Forms.Label labelIn_SOA;
        private System.Windows.Forms.Label labelOut_SOA;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label labelFileName_SOA;
        private System.Windows.Forms.Label labelStatus_SOA;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewIn_SOA = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_SOA = new System.Windows.Forms.DataGridView();
            this.buttonOpenFile_SOA = new System.Windows.Forms.Button();
            this.buttonSave_SOA = new System.Windows.Forms.Button();
            this.buttonHelp_SOA = new System.Windows.Forms.Button();
            this.labelIn_SOA = new System.Windows.Forms.Label();
            this.labelOut_SOA = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.labelFileName_SOA = new System.Windows.Forms.Label();
            this.labelStatus_SOA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_SOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_SOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // dataGridViewIn_SOA
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewIn_SOA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewIn_SOA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIn_SOA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_SOA.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewIn_SOA.Name = "dataGridViewIn_SOA";
            this.dataGridViewIn_SOA.ReadOnly = true;
            this.dataGridViewIn_SOA.RowHeadersWidth = 51;
            this.dataGridViewIn_SOA.Size = new System.Drawing.Size(400, 320);
            this.dataGridViewIn_SOA.TabIndex = 0;

            // dataGridViewOut_SOA
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            this.dataGridViewOut_SOA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOut_SOA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOut_SOA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_SOA.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewOut_SOA.Name = "dataGridViewOut_SOA";
            this.dataGridViewOut_SOA.ReadOnly = true;
            this.dataGridViewOut_SOA.RowHeadersWidth = 51;
            this.dataGridViewOut_SOA.Size = new System.Drawing.Size(396, 320);
            this.dataGridViewOut_SOA.TabIndex = 1;

            // buttonOpenFile_SOA
            this.buttonOpenFile_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile_SOA.Location = new System.Drawing.Point(20, 20);
            this.buttonOpenFile_SOA.Name = "buttonOpenFile_SOA";
            this.buttonOpenFile_SOA.Size = new System.Drawing.Size(180, 40);
            this.buttonOpenFile_SOA.TabIndex = 2;
            this.buttonOpenFile_SOA.Text = "📂 Открыть файл";
            this.buttonOpenFile_SOA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SOA.Click += new System.EventHandler(this.buttonOpenFile_SOA_Click);

            // buttonSave_SOA
            this.buttonSave_SOA.Enabled = false;
            this.buttonSave_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_SOA.Location = new System.Drawing.Point(210, 20);
            this.buttonSave_SOA.Name = "buttonSave_SOA";
            this.buttonSave_SOA.Size = new System.Drawing.Size(180, 40);
            this.buttonSave_SOA.TabIndex = 3;
            this.buttonSave_SOA.Text = "💾 Сохранить";
            this.buttonSave_SOA.UseVisualStyleBackColor = true;
            this.buttonSave_SOA.Click += new System.EventHandler(this.buttonSave_SOA_Click);

            // buttonHelp_SOA
            this.buttonHelp_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SOA.Location = new System.Drawing.Point(400, 20);
            this.buttonHelp_SOA.Name = "buttonHelp_SOA";
            this.buttonHelp_SOA.Size = new System.Drawing.Size(180, 40);
            this.buttonHelp_SOA.TabIndex = 4;
            this.buttonHelp_SOA.Text = "❓ Справка";
            this.buttonHelp_SOA.UseVisualStyleBackColor = true;
            this.buttonHelp_SOA.Click += new System.EventHandler(this.buttonHelp_SOA_Click);

            // labelIn_SOA
            this.labelIn_SOA.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelIn_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIn_SOA.Location = new System.Drawing.Point(0, 0);
            this.labelIn_SOA.Name = "labelIn_SOA";
            this.labelIn_SOA.Size = new System.Drawing.Size(400, 30);
            this.labelIn_SOA.TabIndex = 5;
            this.labelIn_SOA.Text = "Исходная матрица:";
            this.labelIn_SOA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelOut_SOA
            this.labelOut_SOA.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOut_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOut_SOA.Location = new System.Drawing.Point(0, 0);
            this.labelOut_SOA.Name = "labelOut_SOA";
            this.labelOut_SOA.Size = new System.Drawing.Size(396, 30);
            this.labelOut_SOA.TabIndex = 6;
            this.labelOut_SOA.Text = "Результат (5-я строка изменена):";
            this.labelOut_SOA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // splitContainer1
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 80);
            this.splitContainer1.Name = "splitContainer1";

            // splitContainer1.Panel1
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewIn_SOA);
            this.splitContainer1.Panel1.Controls.Add(this.labelIn_SOA);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);

            // splitContainer1.Panel2
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewOut_SOA);
            this.splitContainer1.Panel2.Controls.Add(this.labelOut_SOA);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);

            this.splitContainer1.Size = new System.Drawing.Size(800, 350);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 7;

            // panelButtons
            this.panelButtons.Controls.Add(this.buttonOpenFile_SOA);
            this.panelButtons.Controls.Add(this.buttonSave_SOA);
            this.panelButtons.Controls.Add(this.buttonHelp_SOA);
            this.panelButtons.Controls.Add(this.labelFileName_SOA);
            this.panelButtons.Controls.Add(this.labelStatus_SOA);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(20);
            this.panelButtons.Size = new System.Drawing.Size(800, 120);
            this.panelButtons.TabIndex = 8;

            // labelFileName_SOA
            this.labelFileName_SOA.AutoSize = true;
            this.labelFileName_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFileName_SOA.Location = new System.Drawing.Point(20, 70);
            this.labelFileName_SOA.Name = "labelFileName_SOA";
            this.labelFileName_SOA.Size = new System.Drawing.Size(103, 13);
            this.labelFileName_SOA.TabIndex = 5;
            this.labelFileName_SOA.Text = "Файл: не выбран";

            // labelStatus_SOA
            this.labelStatus_SOA.AutoSize = true;
            this.labelStatus_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus_SOA.Location = new System.Drawing.Point(20, 90);
            this.labelStatus_SOA.Name = "labelStatus_SOA";
            this.labelStatus_SOA.Size = new System.Drawing.Size(92, 13);
            this.labelStatus_SOA.TabIndex = 6;
            this.labelStatus_SOA.Text = "Готов к работе";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelButtons);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_SOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_SOA)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}