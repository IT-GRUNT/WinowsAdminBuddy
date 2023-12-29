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


        private void button1_Click(object sender, EventArgs e)
        {


            if (checkBox1.Checked == true)
            {
                Commands.DisableMSTele();

            }


            if (checkBox4.Checked == true)
            {
                Commands.EnableMSTele();
            }

            if (checkBox6.Checked == true)
            {
                Commands.TurnOnTPMBypass("AllowUpgradesWithUnsupportedTPMOrCPU");
            }

            if (checkBox8.Checked == true)
            {
                Commands.TurnOffSearchHighlights("IsDynamicSearchBoxEnabled");
            }

            if (checkBox7.Checked == true)
            {
                Commands.TurnOffBingSearch("DisableSearchBoxSuggestions");
            }

            if (checkBox3.Checked == true)
            {
                Commands.TurnOffScripting("Enabled");
            }




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

        private void Main_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
