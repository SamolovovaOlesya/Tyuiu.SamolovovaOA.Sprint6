namespace Tyuiu.SamolovovaOA.Sprint6.Task3.V20
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxCondition_SOA;
        private System.Windows.Forms.TextBox textBoxResult_SOA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SOA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SOA;
        private System.Windows.Forms.Button buttonExecute_SOA;
        private System.Windows.Forms.Button buttonHelp_SOA;
        private System.Windows.Forms.Panel panelCondition;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelMatrix;
        private System.Windows.Forms.Label labelResultMatrix;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();

            this.labelCondition = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxCondition_SOA = new System.Windows.Forms.TextBox();
            this.textBoxResult_SOA = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_SOA = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult_SOA = new System.Windows.Forms.DataGridView();
            this.buttonExecute_SOA = new System.Windows.Forms.Button();
            this.buttonHelp_SOA = new System.Windows.Forms.Button();
            this.panelCondition = new System.Windows.Forms.Panel();
            this.labelMatrix = new System.Windows.Forms.Label();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.labelResultMatrix = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SOA)).BeginInit();
            this.panelCondition.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.SuspendLayout();

            // labelCondition
            this.labelCondition.AutoSize = true;
            this.labelCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCondition.Location = new System.Drawing.Point(40, 38);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(86, 20);
            this.labelCondition.TabIndex = 0;
            this.labelCondition.Text = "Условие";

            // labelOutput
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutput.Location = new System.Drawing.Point(440, 38);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(144, 20);
            this.labelOutput.TabIndex = 1;
            this.labelOutput.Text = "Вывод данных";

            // textBoxCondition_SOA
            this.textBoxCondition_SOA.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCondition_SOA.Location = new System.Drawing.Point(15, 13);
            this.textBoxCondition_SOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCondition_SOA.Multiline = true;
            this.textBoxCondition_SOA.Name = "textBoxCondition_SOA";
            this.textBoxCondition_SOA.ReadOnly = true;
            this.textBoxCondition_SOA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCondition_SOA.Size = new System.Drawing.Size(280, 180);
            this.textBoxCondition_SOA.TabIndex = 2;

            // textBoxResult_SOA
            this.textBoxResult_SOA.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SOA.Location = new System.Drawing.Point(17, 13);
            this.textBoxResult_SOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResult_SOA.Multiline = true;
            this.textBoxResult_SOA.Name = "textBoxResult_SOA";
            this.textBoxResult_SOA.ReadOnly = true;
            this.textBoxResult_SOA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SOA.Size = new System.Drawing.Size(287, 180);
            this.textBoxResult_SOA.TabIndex = 3;

            // dataGridViewMatrix_SOA
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMatrix_SOA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMatrix_SOA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatrix_SOA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMatrix_SOA.Location = new System.Drawing.Point(15, 220);
            this.dataGridViewMatrix_SOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewMatrix_SOA.Name = "dataGridViewMatrix_SOA";
            this.dataGridViewMatrix_SOA.ReadOnly = true;
            this.dataGridViewMatrix_SOA.RowHeadersVisible = true;
            this.dataGridViewMatrix_SOA.RowHeadersWidth = 80;
            this.dataGridViewMatrix_SOA.RowTemplate.Height = 24;
            this.dataGridViewMatrix_SOA.Size = new System.Drawing.Size(280, 180);
            this.dataGridViewMatrix_SOA.TabIndex = 4;
            this.dataGridViewMatrix_SOA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrix_SOA_CellContentClick);

            // dataGridViewResult_SOA
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult_SOA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewResult_SOA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult_SOA.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewResult_SOA.Location = new System.Drawing.Point(17, 220);
            this.dataGridViewResult_SOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewResult_SOA.Name = "dataGridViewResult_SOA";
            this.dataGridViewResult_SOA.ReadOnly = true;
            this.dataGridViewResult_SOA.RowHeadersVisible = true;
            this.dataGridViewResult_SOA.RowHeadersWidth = 80;
            this.dataGridViewResult_SOA.RowTemplate.Height = 24;
            this.dataGridViewResult_SOA.Size = new System.Drawing.Size(287, 180);
            this.dataGridViewResult_SOA.TabIndex = 5;
            this.dataGridViewResult_SOA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResult_SOA_CellContentClick);

            // buttonExecute_SOA
            this.buttonExecute_SOA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonExecute_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExecute_SOA.ForeColor = System.Drawing.Color.White;
            this.buttonExecute_SOA.Location = new System.Drawing.Point(151, 13);
            this.buttonExecute_SOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExecute_SOA.Name = "buttonExecute_SOA";
            this.buttonExecute_SOA.Size = new System.Drawing.Size(115, 50);
            this.buttonExecute_SOA.TabIndex = 6;
            this.buttonExecute_SOA.Text = "Выполнить";
            this.buttonExecute_SOA.UseVisualStyleBackColor = false;
            this.buttonExecute_SOA.Click += new System.EventHandler(this.buttonExecute_SOA_Click);

            // buttonHelp_SOA
            this.buttonHelp_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SOA.Location = new System.Drawing.Point(272, 13);
            this.buttonHelp_SOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHelp_SOA.Name = "buttonHelp_SOA";
            this.buttonHelp_SOA.Size = new System.Drawing.Size(40, 50);
            this.buttonHelp_SOA.TabIndex = 7;
            this.buttonHelp_SOA.Text = "?";
            this.buttonHelp_SOA.UseVisualStyleBackColor = true;
            this.buttonHelp_SOA.Click += new System.EventHandler(this.buttonHelp_SOA_Click);

            // panelCondition
            this.panelCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCondition.Controls.Add(this.labelMatrix);
            this.panelCondition.Controls.Add(this.dataGridViewMatrix_SOA);
            this.panelCondition.Controls.Add(this.textBoxCondition_SOA);
            this.panelCondition.Location = new System.Drawing.Point(40, 75);
            this.panelCondition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCondition.Name = "panelCondition";
            this.panelCondition.Size = new System.Drawing.Size(307, 420);
            this.panelCondition.TabIndex = 8;

            // labelMatrix
            this.labelMatrix.AutoSize = true;
            this.labelMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMatrix.Location = new System.Drawing.Point(12, 200);
            this.labelMatrix.Name = "labelMatrix";
            this.labelMatrix.Size = new System.Drawing.Size(118, 18);
            this.labelMatrix.TabIndex = 5;
            this.labelMatrix.Text = "Исходная матрица";

            // panelOutput
            this.panelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOutput.Controls.Add(this.labelResultMatrix);
            this.panelOutput.Controls.Add(this.dataGridViewResult_SOA);
            this.panelOutput.Controls.Add(this.textBoxResult_SOA);
            this.panelOutput.Location = new System.Drawing.Point(440, 75);
            this.panelOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(320, 420);
            this.panelOutput.TabIndex = 9;

            // labelResultMatrix
            this.labelResultMatrix.AutoSize = true;
            this.labelResultMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultMatrix.Location = new System.Drawing.Point(14, 200);
            this.labelResultMatrix.Name = "labelResultMatrix";
            this.labelResultMatrix.Size = new System.Drawing.Size(168, 18);
            this.labelResultMatrix.TabIndex = 6;
            this.labelResultMatrix.Text = "Результат (матрица)";

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelCondition);
            this.Controls.Add(this.buttonHelp_SOA);
            this.Controls.Add(this.buttonExecute_SOA);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelCondition);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 20 | Самоловова О.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SOA)).EndInit();
            this.panelCondition.ResumeLayout(false);
            this.panelCondition.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.panelOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}