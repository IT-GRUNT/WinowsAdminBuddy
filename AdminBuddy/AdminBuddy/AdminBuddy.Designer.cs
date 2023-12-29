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
            BlockMSTCheckBox = new CheckBox();
            groupBox1 = new GroupBox();
            DisableBingSearchCheckBox = new CheckBox();
            DisableSHighLightsCheckbox = new CheckBox();
            EnableMSTCheckBox = new CheckBox();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            DisableTPMCheckbox = new CheckBox();
            DisableWSCRIPTCheckbox = new CheckBox();
            ApplySettingsBTN = new Button();
            groupBox3 = new GroupBox();
            Services_Label = new LinkLabel();
            LUSRMGR_Label = new LinkLabel();
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
            // BlockMSTCheckBox
            // 
            BlockMSTCheckBox.AutoSize = true;
            BlockMSTCheckBox.Location = new Point(8, 28);
            BlockMSTCheckBox.Margin = new Padding(4);
            BlockMSTCheckBox.Name = "BlockMSTCheckBox";
            BlockMSTCheckBox.Size = new Size(203, 44);
            BlockMSTCheckBox.TabIndex = 0;
            BlockMSTCheckBox.Text = "Block Microsoft Telemetry\r\n(Via Host File)";
            BlockMSTCheckBox.UseVisualStyleBackColor = true;
            BlockMSTCheckBox.CheckedChanged += BlockMSTCheckBox_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DisableBingSearchCheckBox);
            groupBox1.Controls.Add(DisableSHighLightsCheckbox);
            groupBox1.Controls.Add(EnableMSTCheckBox);
            groupBox1.Controls.Add(BlockMSTCheckBox);
            groupBox1.Location = new Point(15, 34);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(308, 196);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Privacy";
            // 
            // DisableBingSearchCheckBox
            // 
            DisableBingSearchCheckBox.AutoSize = true;
            DisableBingSearchCheckBox.Location = new Point(8, 109);
            DisableBingSearchCheckBox.Margin = new Padding(4);
            DisableBingSearchCheckBox.Name = "DisableBingSearchCheckBox";
            DisableBingSearchCheckBox.Size = new Size(281, 44);
            DisableBingSearchCheckBox.TabIndex = 3;
            DisableBingSearchCheckBox.Text = "Disable Bing Search From Start Menu \r\n(Win 11)";
            DisableBingSearchCheckBox.UseVisualStyleBackColor = true;
            // 
            // DisableSHighLightsCheckbox
            // 
            DisableSHighLightsCheckbox.AutoSize = true;
            DisableSHighLightsCheckbox.Location = new Point(8, 78);
            DisableSHighLightsCheckbox.Margin = new Padding(4);
            DisableSHighLightsCheckbox.Name = "DisableSHighLightsCheckbox";
            DisableSHighLightsCheckbox.Size = new Size(261, 24);
            DisableSHighLightsCheckbox.TabIndex = 3;
            DisableSHighLightsCheckbox.Text = "Disable Search Highlights (Win 11)";
            DisableSHighLightsCheckbox.UseVisualStyleBackColor = true;
            // 
            // EnableMSTCheckBox
            // 
            EnableMSTCheckBox.AutoSize = true;
            EnableMSTCheckBox.Location = new Point(8, 159);
            EnableMSTCheckBox.Margin = new Padding(4);
            EnableMSTCheckBox.Name = "EnableMSTCheckBox";
            EnableMSTCheckBox.Size = new Size(187, 24);
            EnableMSTCheckBox.TabIndex = 2;
            EnableMSTCheckBox.Text = "Set Host File To Default";
            EnableMSTCheckBox.UseVisualStyleBackColor = true;
            EnableMSTCheckBox.CheckedChanged += EnableMSTCheckBox_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, aboutToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(658, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(64, 24);
            aboutToolStripMenuItem1.Text = "About";
            aboutToolStripMenuItem1.Click += aboutToolStripMenuItem1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DisableTPMCheckbox);
            groupBox2.Controls.Add(DisableWSCRIPTCheckbox);
            groupBox2.Location = new Point(330, 34);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(308, 196);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Security";
            // 
            // DisableTPMCheckbox
            // 
            DisableTPMCheckbox.AutoSize = true;
            DisableTPMCheckbox.Location = new Point(8, 58);
            DisableTPMCheckbox.Margin = new Padding(4);
            DisableTPMCheckbox.Name = "DisableTPMCheckbox";
            DisableTPMCheckbox.Size = new Size(226, 24);
            DisableTPMCheckbox.TabIndex = 2;
            DisableTPMCheckbox.Text = "Disable TPM 2.0 Requirement";
            DisableTPMCheckbox.UseVisualStyleBackColor = true;
            // 
            // DisableWSCRIPTCheckbox
            // 
            DisableWSCRIPTCheckbox.AutoSize = true;
            DisableWSCRIPTCheckbox.Location = new Point(8, 28);
            DisableWSCRIPTCheckbox.Margin = new Padding(4);
            DisableWSCRIPTCheckbox.Name = "DisableWSCRIPTCheckbox";
            DisableWSCRIPTCheckbox.Size = new Size(212, 24);
            DisableWSCRIPTCheckbox.TabIndex = 0;
            DisableWSCRIPTCheckbox.Text = "Block VBS, VBE, && Scripting";
            DisableWSCRIPTCheckbox.UseVisualStyleBackColor = true;
            // 
            // ApplySettingsBTN
            // 
            ApplySettingsBTN.Location = new Point(15, 401);
            ApplySettingsBTN.Margin = new Padding(4);
            ApplySettingsBTN.Name = "ApplySettingsBTN";
            ApplySettingsBTN.Size = new Size(94, 29);
            ApplySettingsBTN.TabIndex = 5;
            ApplySettingsBTN.Text = "Apply";
            ApplySettingsBTN.UseVisualStyleBackColor = true;
            ApplySettingsBTN.Click += ApplySettingsBTN_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Services_Label);
            groupBox3.Controls.Add(LUSRMGR_Label);
            groupBox3.Location = new Point(15, 238);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(308, 156);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Admin Shortcuts";
            // 
            // Services_Label
            // 
            Services_Label.AutoSize = true;
            Services_Label.LinkColor = Color.RoyalBlue;
            Services_Label.Location = new Point(8, 55);
            Services_Label.Margin = new Padding(4, 0, 4, 0);
            Services_Label.Name = "Services_Label";
            Services_Label.Size = new Size(185, 20);
            Services_Label.TabIndex = 1;
            Services_Label.TabStop = true;
            Services_Label.Text = "Manage Services (services)";
            Services_Label.LinkClicked += linkLabel4_LinkClicked;
            // 
            // LUSRMGR_Label
            // 
            LUSRMGR_Label.AutoSize = true;
            LUSRMGR_Label.LinkColor = Color.RoyalBlue;
            LUSRMGR_Label.Location = new Point(8, 24);
            LUSRMGR_Label.Margin = new Padding(4, 0, 4, 0);
            LUSRMGR_Label.Name = "LUSRMGR_Label";
            LUSRMGR_Label.Size = new Size(233, 20);
            LUSRMGR_Label.TabIndex = 0;
            LUSRMGR_Label.TabStop = true;
            LUSRMGR_Label.Text = "Manage Users && Groups (lusrmgr)";
            LUSRMGR_Label.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(linkLabel3);
            groupBox4.Controls.Add(linkLabel2);
            groupBox4.Location = new Point(330, 238);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(308, 156);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Recommended Tools";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.LinkColor = Color.RoyalBlue;
            linkLabel3.Location = new Point(8, 55);
            linkLabel3.Margin = new Padding(4, 0, 4, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(202, 20);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "BloatyNosy - Debloat Win 11";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.RoyalBlue;
            linkLabel2.Location = new Point(8, 24);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(137, 20);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Winutil - Chris Titus";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Main_Panel
            // 
            Main_Panel.Controls.Add(groupBox4);
            Main_Panel.Controls.Add(groupBox3);
            Main_Panel.Controls.Add(ApplySettingsBTN);
            Main_Panel.Controls.Add(groupBox2);
            Main_Panel.Controls.Add(groupBox1);
            Main_Panel.Dock = DockStyle.Fill;
            Main_Panel.Location = new Point(0, 0);
            Main_Panel.Margin = new Padding(4);
            Main_Panel.Name = "Main_Panel";
            Main_Panel.Size = new Size(658, 450);
            Main_Panel.TabIndex = 9;
            // 
            // about1
            // 
            about1.BackgroundImage = (Image)resources.GetObject("about1.BackgroundImage");
            about1.Dock = DockStyle.Fill;
            about1.Location = new Point(0, 0);
            about1.Margin = new Padding(4, 5, 4, 5);
            about1.Name = "about1";
            about1.Size = new Size(658, 450);
            about1.TabIndex = 10;
            // 
            // AdminBuddy
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(658, 450);
            Controls.Add(menuStrip1);
            Controls.Add(Main_Panel);
            Controls.Add(about1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
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

        private CheckBox BlockMSTCheckBox;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private GroupBox groupBox2;
        private CheckBox DisableWSCRIPTCheckbox;
        private Button ApplySettingsBTN;
        private GroupBox groupBox3;
        private LinkLabel LUSRMGR_Label;
        private GroupBox groupBox4;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private About about1;
        private LinkLabel Services_Label;
        private CheckBox EnableMSTCheckBox;
        private CheckBox DisableTPMCheckbox;
        private CheckBox DisableBingSearchCheckBox;
        private CheckBox DisableSHighLightsCheckbox;
        public Panel Main_Panel;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
    }
}
