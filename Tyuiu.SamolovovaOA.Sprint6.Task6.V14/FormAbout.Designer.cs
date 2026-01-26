namespace Tyuiu.SamolovovaOA.Sprint6.Task6.V14
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonDone_SOA = new Button();
            textBoxInfo_SOA = new TextBox();
            pictureBoxPhoto_SOA = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_SOA).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_SOA
            // 
            buttonDone_SOA.Location = new Point(608, 390);
            buttonDone_SOA.Name = "buttonDone_SOA";
            buttonDone_SOA.Size = new Size(151, 37);
            buttonDone_SOA.TabIndex = 5;
            buttonDone_SOA.Text = "Okey";
            buttonDone_SOA.UseVisualStyleBackColor = true;
            buttonDone_SOA.Click += buttonDone_SOA_Click;
            // 
            // textBoxInfo_SOA
            // 
            textBoxInfo_SOA.Location = new Point(341, 24);
            textBoxInfo_SOA.Multiline = true;
            textBoxInfo_SOA.Name = "textBoxInfo_SOA";
            textBoxInfo_SOA.ReadOnly = true;
            textBoxInfo_SOA.Size = new Size(439, 332);
            textBoxInfo_SOA.TabIndex = 4;
            textBoxInfo_SOA.TabStop = false;
            textBoxInfo_SOA.Text = resources.GetString("textBoxInfo_SOA.Text");
            // 
            // pictureBoxPhoto_SOA
            // 
            pictureBoxPhoto_SOA.Image = (Image)resources.GetObject("pictureBoxPhoto_SOA.Image");
            pictureBoxPhoto_SOA.Location = new Point(20, 24);
            pictureBoxPhoto_SOA.Name = "pictureBoxPhoto_SOA";
            pictureBoxPhoto_SOA.Size = new Size(300, 392);
            pictureBoxPhoto_SOA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto_SOA.TabIndex = 3;
            pictureBoxPhoto_SOA.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_SOA);
            Controls.Add(textBoxInfo_SOA);
            Controls.Add(pictureBoxPhoto_SOA);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_SOA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone_SOA;
        private TextBox textBoxInfo_SOA;
        private PictureBox pictureBoxPhoto_SOA;
    }
}