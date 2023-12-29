namespace AdminBuddy
{
    partial class AdminBuddy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBuddy));
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox4 = new CheckBox();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            checkBox6 = new CheckBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            linkLabel4 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            groupBox4 = new GroupBox();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            Main_Panel = new Panel();
            about1 = new About();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            Main_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(163, 34);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Block Microsoft Telemetry\r\n(Via Host File)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox7);
            groupBox1.Controls.Add(checkBox8);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 157);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Privacy";
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(6, 87);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(224, 34);
            checkBox7.TabIndex = 3;
            checkBox7.Text = "Disable Bing Search From Start Menu \r\n(Win 11)";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(6, 62);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(207, 19);
            checkBox8.TabIndex = 3;
            checkBox8.Text = "Disable Search Highlights (Win 11)";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 127);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(147, 19);
            checkBox4.TabIndex = 2;
            checkBox4.Text = "Set Host File To Default";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, aboutToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(526, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(52, 20);
            aboutToolStripMenuItem1.Text = "About";
            aboutToolStripMenuItem1.Click += aboutToolStripMenuItem1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox6);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Location = new Point(264, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(246, 157);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Security";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(6, 46);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(180, 19);
            checkBox6.TabIndex = 2;
            checkBox6.Text = "Disable TPM 2.0 Requirement";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 22);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(170, 19);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "Block VBS, VBE, && Scripting";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 321);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(linkLabel4);
            groupBox3.Controls.Add(linkLabel1);
            groupBox3.Location = new Point(12, 190);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(246, 125);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Admin Shortcuts";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.LinkColor = Color.RoyalBlue;
            linkLabel4.Location = new Point(6, 44);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(147, 15);
            linkLabel4.TabIndex = 1;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Manage Services (services)";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.RoyalBlue;
            linkLabel1.Location = new Point(6, 19);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(187, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Manage Users && Groups (lusrmgr)";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(linkLabel3);
            groupBox4.Controls.Add(linkLabel2);
            groupBox4.Location = new Point(264, 190);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(246, 125);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Recommended Tools";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.LinkColor = Color.RoyalBlue;
            linkLabel3.Location = new Point(6, 44);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(158, 15);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "BloatyNosy - Debloat Win 11";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.RoyalBlue;
            linkLabel2.Location = new Point(6, 19);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(111, 15);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Winutil - Chris Titus";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Main_Panel
            // 
            Main_Panel.Controls.Add(groupBox4);
            Main_Panel.Controls.Add(groupBox3);
            Main_Panel.Controls.Add(button1);
            Main_Panel.Controls.Add(groupBox2);
            Main_Panel.Controls.Add(groupBox1);
            Main_Panel.Dock = DockStyle.Fill;
            Main_Panel.Location = new Point(0, 0);
            Main_Panel.Name = "Main_Panel";
            Main_Panel.Size = new Size(526, 360);
            Main_Panel.TabIndex = 9;
            Main_Panel.Paint += Main_Panel_Paint;
            // 
            // about1
            // 
            about1.BackgroundImage = (Image)resources.GetObject("about1.BackgroundImage");
            about1.Dock = DockStyle.Fill;
            about1.Location = new Point(0, 0);
            about1.Name = "about1";
            about1.Size = new Size(526, 360);
            about1.TabIndex = 10;
            // 
            // AdminBuddy
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(526, 360);
            Controls.Add(menuStrip1);
            Controls.Add(Main_Panel);
            Controls.Add(about1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "AdminBuddy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows AB";
            TopMost = true;
            Load += AdminBuddy_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            Main_Panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private GroupBox groupBox2;
        private CheckBox checkBox3;
        private Button button1;
        private GroupBox groupBox3;
        private LinkLabel linkLabel1;
        private GroupBox groupBox4;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private About about1;
        private LinkLabel linkLabel4;
        private CheckBox checkBox4;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        public Panel Main_Panel;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
    }
}
