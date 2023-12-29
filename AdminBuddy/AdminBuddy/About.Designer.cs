using AdminBuddy.Properties;

namespace AdminBuddy
{
    partial class About
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AboutBG = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)AboutBG).BeginInit();
            SuspendLayout();
            // 
            // AboutBG
            // 
            AboutBG.Dock = DockStyle.Fill;
            AboutBG.Image = Resources.Credits;
            AboutBG.Location = new Point(0, 0);
            AboutBG.Name = "AboutBG";
            AboutBG.Size = new Size(525, 525);
            AboutBG.SizeMode = PictureBoxSizeMode.StretchImage;
            AboutBG.TabIndex = 0;
            AboutBG.TabStop = false;
            AboutBG.Click += AboutBG_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(216, 75);
            label1.Name = "label1";
            label1.Size = new Size(77, 30);
            label1.TabIndex = 1;
            label1.Text = "Credits";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(82, 131);
            label2.Name = "label2";
            label2.Size = new Size(360, 60);
            label2.TabIndex = 2;
            label2.Text = "Encrypt the planet - www.encrypt-the-planet.com\r\nBloatyNosy - www.github.com/builtbybel/Bloatynosy\r\nChris Titus - www.christitus.com/windows-tool\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.Credits;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AboutBG);
            Name = "About";
            Size = new Size(525, 525);
            Load += About_Load;
            ((System.ComponentModel.ISupportInitialize)AboutBG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox AboutBG;
        private Label label1;
        private Label label2;
    }
}
