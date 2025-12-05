namespace Tyuiu.SamolovovaOA.Sprint6.Task2.V12
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_SOA = new System.Windows.Forms.Panel();
            this.groupBoxTask_SOA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SOA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SOA = new System.Windows.Forms.GroupBox();
            this.textBoxStop_SOA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SOA = new System.Windows.Forms.TextBox();
            this.labelStop_SOA = new System.Windows.Forms.Label();
            this.labelStart_SOA = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxOutput_SOA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SOA = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxChart_SOA = new System.Windows.Forms.GroupBox();
            this.chartFunction_SOA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelBottom_SOA = new System.Windows.Forms.Panel();
            this.labelInfo_SOA = new System.Windows.Forms.Label();
            this.buttonHelp_SOA = new System.Windows.Forms.Button();
            this.buttonDone_SOA = new System.Windows.Forms.Button();
            this.panelTop_SOA.SuspendLayout();
            this.groupBoxTask_SOA.SuspendLayout();
            this.groupBoxInput_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxOutput_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SOA)).BeginInit();
            this.groupBoxChart_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SOA)).BeginInit();
            this.panelBottom_SOA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_SOA
            // 
            this.panelTop_SOA.Controls.Add(this.groupBoxTask_SOA);
            this.panelTop_SOA.Controls.Add(this.groupBoxInput_SOA);
            this.panelTop_SOA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SOA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SOA.Name = "panelTop_SOA";
            this.panelTop_SOA.Size = new System.Drawing.Size(984, 150);
            this.panelTop_SOA.TabIndex = 0;
            // 
            // groupBoxTask_SOA
            // 
            this.groupBoxTask_SOA.Controls.Add(this.textBoxTask_SOA);
            this.groupBoxTask_SOA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SOA.Name = "groupBoxTask_SOA";
            this.groupBoxTask_SOA.Size = new System.Drawing.Size(600, 80);
            this.groupBoxTask_SOA.TabIndex = 0;
            this.groupBoxTask_SOA.TabStop = false;
            this.groupBoxTask_SOA.Text = "Условие";
            // 
            // textBoxTask_SOA
            // 
            this.textBoxTask_SOA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_SOA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SOA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_SOA.Multiline = true;
            this.textBoxTask_SOA.Name = "textBoxTask_SOA";
            this.textBoxTask_SOA.ReadOnly = true;
            this.textBoxTask_SOA.Size = new System.Drawing.Size(594, 61);
            this.textBoxTask_SOA.TabIndex = 0;
            this.textBoxTask_SOA.Text = "Табулировать функцию F(x) = (2x+6)/(cos(x)+x) - 3 на диапазоне [-5; 5] с шагом 1." +
    "\r\nПроизвести проверку деления на ноль. При делении на ноль вернуть значение 0.\r\n" +
    "Результат вывести в таблицу и построить график.";
            // 
            // groupBoxInput_SOA
            // 
            this.groupBoxInput_SOA.Controls.Add(this.textBoxStop_SOA);
            this.groupBoxInput_SOA.Controls.Add(this.textBoxStart_SOA);
            this.groupBoxInput_SOA.Controls.Add(this.labelStop_SOA);
            this.groupBoxInput_SOA.Controls.Add(this.labelStart_SOA);
            this.groupBoxInput_SOA.Location = new System.Drawing.Point(618, 12);
            this.groupBoxInput_SOA.Name = "groupBoxInput_SOA";
            this.groupBoxInput_SOA.Size = new System.Drawing.Size(354, 80);
            this.groupBoxInput_SOA.TabIndex = 1;
            this.groupBoxInput_SOA.TabStop = false;
            this.groupBoxInput_SOA.Text = "Ввод данных";
            // 
            // textBoxStop_SOA
            // 
            this.textBoxStop_SOA.Location = new System.Drawing.Point(220, 35);
            this.textBoxStop_SOA.Name = "textBoxStop_SOA";
            this.textBoxStop_SOA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_SOA.TabIndex = 3;
            this.textBoxStop_SOA.Text = "5";
            this.textBoxStop_SOA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStop_SOA_KeyPress);
            // 
            // textBoxStart_SOA
            // 
            this.textBoxStart_SOA.Location = new System.Drawing.Point(70, 35);
            this.textBoxStart_SOA.Name = "textBoxStart_SOA";
            this.textBoxStart_SOA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_SOA.TabIndex = 2;
            this.textBoxStart_SOA.Text = "-5";
            this.textBoxStart_SOA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStart_SOA_KeyPress);
            // 
            // labelStop_SOA
            // 
            this.labelStop_SOA.AutoSize = true;
            this.labelStop_SOA.Location = new System.Drawing.Point(180, 38);
            this.labelStop_SOA.Name = "labelStop_SOA";
            this.labelStop_SOA.Size = new System.Drawing.Size(34, 13);
            this.labelStop_SOA.TabIndex = 1;
            this.labelStop_SOA.Text = "Конец:";
            // 
            // labelStart_SOA
            // 
            this.labelStart_SOA.AutoSize = true;
            this.labelStart_SOA.Location = new System.Drawing.Point(20, 38);
            this.labelStart_SOA.Name = "labelStart_SOA";
            this.labelStart_SOA.Size = new System.Drawing.Size(44, 13);
            this.labelStart_SOA.TabIndex = 0;
            this.labelStart_SOA.Text = "Начало:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 150);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxOutput_SOA);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxChart_SOA);
            this.splitContainer1.Size = new System.Drawing.Size(984, 411);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBoxOutput_SOA
            // 
            this.groupBoxOutput_SOA.Controls.Add(this.dataGridViewResult_SOA);
            this.groupBoxOutput_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_SOA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_SOA.Size = new System.Drawing.Size(450, 411);
            this.groupBoxOutput_SOA.TabIndex = 0;
            this.groupBoxOutput_SOA.TabStop = false;
            this.groupBoxOutput_SOA.Text = "Таблица значений";
            // 
            // dataGridViewResult_SOA
            // 
            this.dataGridViewResult_SOA.AllowUserToAddRows = false;
            this.dataGridViewResult_SOA.AllowUserToDeleteRows = false;
            this.dataGridViewResult_SOA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SOA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnFx});
            this.dataGridViewResult_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_SOA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_SOA.Name = "dataGridViewResult_SOA";
            this.dataGridViewResult_SOA.ReadOnly = true;
            this.dataGridViewResult_SOA.RowHeadersVisible = false;
            this.dataGridViewResult_SOA.Size = new System.Drawing.Size(444, 392);
            this.dataGridViewResult_SOA.TabIndex = 0;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.Width = 150;
            // 
            // ColumnFx
            // 
            this.ColumnFx.HeaderText = "F(x)";
            this.ColumnFx.Name = "ColumnFx";
            this.ColumnFx.ReadOnly = true;
            this.ColumnFx.Width = 150;
            // 
            // groupBoxChart_SOA
            // 
            this.groupBoxChart_SOA.Controls.Add(this.chartFunction_SOA);
            this.groupBoxChart_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxChart_SOA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxChart_SOA.Name = "groupBoxChart_SOA";
            this.groupBoxChart_SOA.Size = new System.Drawing.Size(530, 411);
            this.groupBoxChart_SOA.TabIndex = 0;
            this.groupBoxChart_SOA.TabStop = false;
            this.groupBoxChart_SOA.Text = "График функции";
            // 
            // chartFunction_SOA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SOA.ChartAreas.Add(chartArea1);
            this.chartFunction_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_SOA.Legends.Add(legend1);
            this.chartFunction_SOA.Location = new System.Drawing.Point(3, 16);
            this.chartFunction_SOA.Name = "chartFunction_SOA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "F(x)";
            this.chartFunction_SOA.Series.Add(series1);
            this.chartFunction_SOA.Size = new System.Drawing.Size(524, 392);
            this.chartFunction_SOA.TabIndex = 0;
            this.chartFunction_SOA.Text = "chart1";
            // 
            // panelBottom_SOA
            // 
            this.panelBottom_SOA.Controls.Add(this.labelInfo_SOA);
            this.panelBottom_SOA.Controls.Add(this.buttonHelp_SOA);
            this.panelBottom_SOA.Controls.Add(this.buttonDone_SOA);
            this.panelBottom_SOA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom_SOA.Location = new System.Drawing.Point(0, 561);
            this.panelBottom_SOA.Name = "panelBottom_SOA";
            this.panelBottom_SOA.Size = new System.Drawing.Size(984, 50);
            this.panelBottom_SOA.TabIndex = 2;
            // 
            // labelInfo_SOA
            // 
            this.labelInfo_SOA.AutoSize = true;
            this.labelInfo_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_SOA.Location = new System.Drawing.Point(15, 17);
            this.labelInfo_SOA.Name = "labelInfo_SOA";
            this.labelInfo_SOA.Size = new System.Drawing.Size(110, 16);
            this.labelInfo_SOA.TabIndex = 2;
            this.labelInfo_SOA.Text = "Количество точек:";
            // 
            // buttonHelp_SOA
            // 
            this.buttonHelp_SOA.Location = new System.Drawing.Point(798, 15);
            this.buttonHelp_SOA.Name = "buttonHelp_SOA";
            this.buttonHelp_SOA.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp_SOA.TabIndex = 1;
            this.buttonHelp_SOA.Text = "Справка";
            this.buttonHelp_SOA.UseVisualStyleBackColor = true;
            this.buttonHelp_SOA.Click += new System.EventHandler(this.buttonHelp_SOA_Click);
            // 
            // buttonDone_SOA
            // 
            this.buttonDone_SOA.Location = new System.Drawing.Point(879, 15);
            this.buttonDone_SOA.Name = "buttonDone_SOA";
            this.buttonDone_SOA.Size = new System.Drawing.Size(93, 23);
            this.buttonDone_SOA.TabIndex = 0;
            this.buttonDone_SOA.Text = "Выполнить";
            this.buttonDone_SOA.UseVisualStyleBackColor = true;
            this.buttonDone_SOA.Click += new System.EventHandler(this.buttonDone_SOA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelBottom_SOA);
            this.Controls.Add(this.panelTop_SOA);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 12 | Самоловова О. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_SOA.ResumeLayout(false);
            this.groupBoxTask_SOA.ResumeLayout(false);
            this.groupBoxTask_SOA.PerformLayout();
            this.groupBoxInput_SOA.ResumeLayout(false);
            this.groupBoxInput_SOA.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxOutput_SOA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SOA)).EndInit();
            this.groupBoxChart_SOA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SOA)).EndInit();
            this.panelBottom_SOA.ResumeLayout(false);
            this.panelBottom_SOA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SOA;
        private System.Windows.Forms.GroupBox groupBoxTask_SOA;
        private System.Windows.Forms.TextBox textBoxTask_SOA;
        private System.Windows.Forms.GroupBox groupBoxInput_SOA;
        private System.Windows.Forms.TextBox textBoxStop_SOA;
        private System.Windows.Forms.TextBox textBoxStart_SOA;
        private System.Windows.Forms.Label labelStop_SOA;
        private System.Windows.Forms.Label labelStart_SOA;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxOutput_SOA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SOA;
        private System.Windows.Forms.GroupBox groupBoxChart_SOA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SOA;
        private System.Windows.Forms.Panel panelBottom_SOA;
        private System.Windows.Forms.Button buttonHelp_SOA;
        private System.Windows.Forms.Button buttonDone_SOA;
        private System.Windows.Forms.Label labelInfo_SOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFx;
    }
}