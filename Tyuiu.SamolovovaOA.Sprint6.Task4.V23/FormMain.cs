namespace Tyuiu.SamolovovaOA.Sprint6.Task4.V23
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxStart_SOA = new System.Windows.Forms.TextBox();
            this.textBoxStop_SOA = new System.Windows.Forms.TextBox();
            this.textBoxResult_SOA = new System.Windows.Forms.TextBox();
            this.buttonResult_SOA = new System.Windows.Forms.Button();
            this.buttonSave_SOA = new System.Windows.Forms.Button();
            this.buttonHelp_SOA = new System.Windows.Forms.Button();
            this.chartFunction_SOA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelStart_SOA = new System.Windows.Forms.Label();
            this.labelStop_SOA = new System.Windows.Forms.Label();
            this.labelInfo_SOA = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SOA)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStart_SOA
            // 
            this.textBoxStart_SOA.Location = new System.Drawing.Point(120, 15);
            this.textBoxStart_SOA.Name = "textBoxStart_SOA";
            this.textBoxStart_SOA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_SOA.TabIndex = 0;
            this.textBoxStart_SOA.Text = "-5";
            this.textBoxStart_SOA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStart_SOA_KeyPress);
            // 
            // textBoxStop_SOA
            // 
            this.textBoxStop_SOA.Location = new System.Drawing.Point(120, 45);
            this.textBoxStop_SOA.Name = "textBoxStop_SOA";
            this.textBoxStop_SOA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_SOA.TabIndex = 1;
            this.textBoxStop_SOA.Text = "5";
            this.textBoxStop_SOA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStop_SOA_KeyPress);
            // 
            // textBoxResult_SOA
            // 
            this.textBoxResult_SOA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SOA.Location = new System.Drawing.Point(12, 100);
            this.textBoxResult_SOA.Multiline = true;
            this.textBoxResult_SOA.Name = "textBoxResult_SOA";
            this.textBoxResult_SOA.ReadOnly = true;
            this.textBoxResult_SOA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SOA.Size = new System.Drawing.Size(350, 338);
            this.textBoxResult_SOA.TabIndex = 2;
            // 
            // buttonResult_SOA
            // 
            this.buttonResult_SOA.BackColor = System.Drawing.Color.LightBlue;
            this.buttonResult_SOA.Location = new System.Drawing.Point(240, 10);
            this.buttonResult_SOA.Name = "buttonResult_SOA";
            this.buttonResult_SOA.Size = new System.Drawing.Size(120, 40);
            this.buttonResult_SOA.TabIndex = 3;
            this.buttonResult_SOA.Text = "Выполнить";
            this.buttonResult_SOA.UseVisualStyleBackColor = false;
            this.buttonResult_SOA.Click += new System.EventHandler(this.buttonResult_SOA_Click);
            // 
            // buttonSave_SOA
            // 
            this.buttonSave_SOA.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSave_SOA.Location = new System.Drawing.Point(380, 10);
            this.buttonSave_SOA.Name = "buttonSave_SOA";
            this.buttonSave_SOA.Size = new System.Drawing.Size(120, 40);
            this.buttonSave_SOA.TabIndex = 4;
            this.buttonSave_SOA.Text = "Сохранить в файл";
            this.buttonSave_SOA.UseVisualStyleBackColor = false;
            this.buttonSave_SOA.Click += new System.EventHandler(this.buttonSave_SOA_Click);
            // 
            // buttonHelp_SOA
            // 
            this.buttonHelp_SOA.BackColor = System.Drawing.Color.LightYellow;
            this.buttonHelp_SOA.Location = new System.Drawing.Point(520, 10);
            this.buttonHelp_SOA.Name = "buttonHelp_SOA";
            this.buttonHelp_SOA.Size = new System.Drawing.Size(120, 40);
            this.buttonHelp_SOA.TabIndex = 5;
            this.buttonHelp_SOA.Text = "Справка";
            this.buttonHelp_SOA.UseVisualStyleBackColor = false;
            this.buttonHelp_SOA.Click += new System.EventHandler(this.buttonHelp_SOA_Click);
            // 
            // chartFunction_SOA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SOA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_SOA.Legends.Add(legend1);
            this.chartFunction_SOA.Location = new System.Drawing.Point(370, 100);
            this.chartFunction_SOA.Name = "chartFunction_SOA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "F(x)";
            this.chartFunction_SOA.Series.Add(series1);
            this.chartFunction_SOA.Size = new System.Drawing.Size(450, 338);
            this.chartFunction_SOA.TabIndex = 6;
            this.chartFunction_SOA.Text = "График функции";
            // 
            // labelStart_SOA
            // 
            this.labelStart_SOA.AutoSize = true;
            this.labelStart_SOA.Location = new System.Drawing.Point(30, 18);
            this.labelStart_SOA.Name = "labelStart_SOA";
            this.labelStart_SOA.Size = new System.Drawing.Size(81, 13);
            this.labelStart_SOA.TabIndex = 7;
            this.labelStart_SOA.Text = "Старт шага:";
            // 
            // labelStop_SOA
            // 
            this.labelStop_SOA.AutoSize = true;
            this.labelStop_SOA.Location = new System.Drawing.Point(30, 48);
            this.labelStop_SOA.Name = "labelStop_SOA";
            this.labelStop_SOA.Size = new System.Drawing.Size(84, 13);
            this.labelStop_SOA.TabIndex = 8;
            this.labelStop_SOA.Text = "Конец шага:";
            // 
            // labelInfo_SOA
            // 
            this.labelInfo_SOA.AutoSize = true;
            this.labelInfo_SOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_SOA.Location = new System.Drawing.Point(120, 70);
            this.labelInfo_SOA.Name = "labelInfo_SOA";
            this.labelInfo_SOA.Size = new System.Drawing.Size(96, 13);
            this.labelInfo_SOA.TabIndex = 9;
            this.labelInfo_SOA.Text = "Диапазон: [-5;5]";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCondition.Location = new System.Drawing.Point(12, 80);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(101, 13);
            this.labelCondition.TabIndex = 10;
            this.labelCondition.Text = "F(x) = 4 - 2x + (2 + cos(x)) / (2x - 2)";
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.labelInfo_SOA);
            this.Controls.Add(this.labelStop_SOA);
            this.Controls.Add(this.labelStart_SOA);
            this.Controls.Add(this.chartFunction_SOA);
            this.Controls.Add(this.buttonHelp_SOA);
            this.Controls.Add(this.buttonSave_SOA);
            this.Controls.Add(this.buttonResult_SOA);
            this.Controls.Add(this.textBoxResult_SOA);
            this.Controls.Add(this.textBoxStop_SOA);
            this.Controls.Add(this.textBoxStart_SOA);
            this.MinimumSize = new System.Drawing.Size(850, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 23 | Самоловова О.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SOA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxStart_SOA;
        private System.Windows.Forms.TextBox textBoxStop_SOA;
        private System.Windows.Forms.TextBox textBoxResult_SOA;
        private System.Windows.Forms.Button buttonResult_SOA;
        private System.Windows.Forms.Button buttonSave_SOA;
        private System.Windows.Forms.Button buttonHelp_SOA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SOA;
        private System.Windows.Forms.Label labelStart_SOA;
        private System.Windows.Forms.Label labelStop_SOA;
        private System.Windows.Forms.Label labelInfo_SOA;
        private System.Windows.Forms.Label labelCondition;
    }
}