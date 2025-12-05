namespace Tyuiu.SamolovovaOA.Sprint6.Task5.V26
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewAll_SOA;
        private System.Windows.Forms.DataGridView dataGridViewDivisible_SOA;
        private System.Windows.Forms.Button buttonOpenFile_SOA;
        private System.Windows.Forms.Button buttonHelp_SOA;
        private System.Windows.Forms.Button buttonSave_SOA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_SOA;
        private System.Windows.Forms.Label labelInfo_SOA;
        private System.Windows.Forms.Label labelAll_SOA;
        private System.Windows.Forms.Label labelDivisible_SOA;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewAll_SOA = new System.Windows.Forms.DataGridView();
            this.dataGridViewDivisible_SOA = new System.Windows.Forms.DataGridView();
            this.buttonOpenFile_SOA = new System.Windows.Forms.Button();
            this.buttonHelp_SOA = new System.Windows.Forms.Button();
            this.buttonSave_SOA = new System.Windows.Forms.Button();
            this.chart_SOA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelInfo_SOA = new System.Windows.Forms.Label();
            this.labelAll_SOA = new System.Windows.Forms.Label();
            this.labelDivisible_SOA = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelChart = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll_SOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDivisible_SOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_SOA)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelChart.SuspendLayout();
            this.SuspendLayout();

            // dataGridViewAll_SOA
            this.dataGridViewAll_SOA.AllowUserToAddRows = false;
            this.dataGridViewAll_SOA.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewAll_SOA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAll_SOA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAll_SOA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAll_SOA.Location = new System.Drawing.Point(10, 30);
            this.dataGridViewAll_SOA.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAll_SOA.Name = "dataGridViewAll_SOA";
            this.dataGridViewAll_SOA.ReadOnly = true;
            this.dataGridViewAll_SOA.RowHeadersWidth = 51;
            this.dataGridViewAll_SOA.Size = new System.Drawing.Size(280, 240);
            this.dataGridViewAll_SOA.TabIndex = 0;

            // dataGridViewDivisible_SOA
            this.dataGridViewDivisible_SOA.AllowUserToAddRows = false;
            this.dataGridViewDivisible_SOA.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            this.dataGridViewDivisible_SOA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDivisible_SOA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDivisible_SOA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDivisible_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDivisible_SOA.Location = new System.Drawing.Point(10, 30);
            this.dataGridViewDivisible_SOA.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDivisible_SOA.Name = "dataGridViewDivisible_SOA";
            this.dataGridViewDivisible_SOA.ReadOnly = true;
            this.dataGridViewDivisible_SOA.RowHeadersWidth = 51;
            this.dataGridViewDivisible_SOA.Size = new System.Drawing.Size(280, 240);
            this.dataGridViewDivisible_SOA.TabIndex = 1;

            // buttonOpenFile_SOA
            this.buttonOpenFile_SOA.Location = new System.Drawing.Point(20, 20);
            this.buttonOpenFile_SOA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenFile_SOA.Name = "buttonOpenFile_SOA";
            this.buttonOpenFile_SOA.Size = new System.Drawing.Size(150, 40);
            this.buttonOpenFile_SOA.TabIndex = 2;
            this.buttonOpenFile_SOA.Text = "Открыть файл";
            this.buttonOpenFile_SOA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SOA.Click += new System.EventHandler(this.buttonOpenFile_SOA_Click);

            // buttonHelp_SOA
            this.buttonHelp_SOA.Location = new System.Drawing.Point(180, 20);
            this.buttonHelp_SOA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHelp_SOA.Name = "buttonHelp_SOA";
            this.buttonHelp_SOA.Size = new System.Drawing.Size(150, 40);
            this.buttonHelp_SOA.TabIndex = 3;
            this.buttonHelp_SOA.Text = "Справка";
            this.buttonHelp_SOA.UseVisualStyleBackColor = true;
            this.buttonHelp_SOA.Click += new System.EventHandler(this.buttonHelp_SOA_Click);

            // buttonSave_SOA
            this.buttonSave_SOA.Location = new System.Drawing.Point(340, 20);
            this.buttonSave_SOA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave_SOA.Name = "buttonSave_SOA";
            this.buttonSave_SOA.Size = new System.Drawing.Size(150, 40);
            this.buttonSave_SOA.TabIndex = 4;
            this.buttonSave_SOA.Text = "Сохранить результат";
            this.buttonSave_SOA.UseVisualStyleBackColor = true;
            this.buttonSave_SOA.Click += new System.EventHandler(this.buttonSave_SOA_Click);

            // chart_SOA
            chartArea1.Name = "ChartArea1";
            this.chart_SOA.ChartAreas.Add(chartArea1);
            this.chart_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_SOA.Legends.Add(legend1);
            this.chart_SOA.Location = new System.Drawing.Point(10, 10);
            this.chart_SOA.Margin = new System.Windows.Forms.Padding(4);
            this.chart_SOA.Name = "chart_SOA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_SOA.Series.Add(series1);
            this.chart_SOA.Size = new System.Drawing.Size(460, 260);
            this.chart_SOA.TabIndex = 5;
            this.chart_SOA.Text = "chart";

            // labelInfo_SOA
            this.labelInfo_SOA.AutoSize = true;
            this.labelInfo_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_SOA.Location = new System.Drawing.Point(20, 70);
            this.labelInfo_SOA.Name = "labelInfo_SOA";
            this.labelInfo_SOA.Size = new System.Drawing.Size(143, 18);
            this.labelInfo_SOA.TabIndex = 6;
            this.labelInfo_SOA.Text = "Всего чисел: 0";

            // labelAll_SOA
            this.labelAll_SOA.AutoSize = true;
            this.labelAll_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAll_SOA.Location = new System.Drawing.Point(10, 10);
            this.labelAll_SOA.Name = "labelAll_SOA";
            this.labelAll_SOA.Size = new System.Drawing.Size(116, 18);
            this.labelAll_SOA.TabIndex = 7;
            this.labelAll_SOA.Text = "Все числа:";

            // labelDivisible_SOA
            this.labelDivisible_SOA.AutoSize = true;
            this.labelDivisible_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDivisible_SOA.Location = new System.Drawing.Point(10, 10);
            this.labelDivisible_SOA.Name = "labelDivisible_SOA";
            this.labelDivisible_SOA.Size = new System.Drawing.Size(147, 18);
            this.labelDivisible_SOA.TabIndex = 8;
            this.labelDivisible_SOA.Text = "Числа кратные 5:";

            // panelButtons
            this.panelButtons.Controls.Add(this.buttonOpenFile_SOA);
            this.panelButtons.Controls.Add(this.buttonHelp_SOA);
            this.panelButtons.Controls.Add(this.buttonSave_SOA);
            this.panelButtons.Controls.Add(this.labelInfo_SOA);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(20);
            this.panelButtons.Size = new System.Drawing.Size(1000, 100);
            this.panelButtons.TabIndex = 9;

            // panelLeft
            this.panelLeft.Controls.Add(this.labelAll_SOA);
            this.panelLeft.Controls.Add(this.dataGridViewAll_SOA);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 100);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(10);
            this.panelLeft.Size = new System.Drawing.Size(300, 280);
            this.panelLeft.TabIndex = 10;

            // panelRight
            this.panelRight.Controls.Add(this.labelDivisible_SOA);
            this.panelRight.Controls.Add(this.dataGridViewDivisible_SOA);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRight.Location = new System.Drawing.Point(300, 100);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.Size = new System.Drawing.Size(300, 280);
            this.panelRight.TabIndex = 11;

            // panelChart
            this.panelChart.Controls.Add(this.chart_SOA);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(600, 100);
            this.panelChart.Name = "panelChart";
            this.panelChart.Padding = new System.Windows.Forms.Padding(10);
            this.panelChart.Size = new System.Drawing.Size(480, 280);
            this.panelChart.TabIndex = 12;

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 380);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelButtons);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1018, 427);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 26 | Самоловова О.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll_SOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDivisible_SOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_SOA)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelChart.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}