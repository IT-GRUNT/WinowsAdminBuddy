//https://github.com/IT-GRUNT/WinowsAdminBuddy

using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace AdminBuddy
{
    public partial class AdminBuddy : Form
    {
         public static object Properties { get; internal set; }
         public static object Resources { get; internal set; }

        public AdminBuddy()
        {
            InitializeComponent();
        }

        private void AdminBuddy_Load(object sender, EventArgs e)
        {
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mmc.exe", "lusrmgr.msc");
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mmc.exe", "services.msc");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/ChrisTitusTech/winutil");
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/builtbybel/Bloatynosy");
        }

        private void ApplySettingsBTN_Click(object sender, EventArgs e)
        {
            ApplySettingsBTN.Text = "Applying...";
            ApplySettingsBTN.Enabled = false;
            if (BlockMSTCheckBox.Checked == true)
            {
                Commands.DisableMSTele();
            }
            if (EnableMSTCheckBox.Checked == true)
            {
                Commands.EnableMSTele();
            }
            if (DisableTPMCheckbox.Checked == true)
            {
                Commands.TurnOnTPMBypass("AllowUpgradesWithUnsupportedTPMOrCPU");
            }
            if (DisableSHighLightsCheckbox.Checked == true)
            {
                Commands.TurnOffSearchHighlights("IsDynamicSearchBoxEnabled");
            }
            if (DisableBingSearchCheckBox.Checked == true)
            {
                Commands.TurnOffBingSearch("DisableSearchBoxSuggestions");
            }
            if (DisableWSCRIPTCheckbox.Checked == true)
            {
                Commands.TurnOffScripting("Enabled");
            }
            ApplySettingsBTN.Text = "Apply";
            ApplySettingsBTN.Enabled = true;
            MessageBox.Show("Finished.");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            about1.Visible = true;
            Main_Panel.Visible = false;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about1.Visible = false;
            Main_Panel.Visible = true;
        }

        private void EnableMSTCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BlockMSTCheckBox.Checked == true)
            {
                EnableMSTCheckBox.Checked = false;
            }
        }
        private void BlockMSTCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableMSTCheckBox.Checked == true)
            {
                BlockMSTCheckBox.Checked = false;
            }
        }
    }
}
