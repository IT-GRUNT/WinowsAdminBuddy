using AdminBuddy.Properties;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using static System.Windows.Forms.LinkLabel;

namespace AdminBuddy
{
    internal class Commands
    {
        public Commands()

        {




        }

        #region "TPM Settings"
        public static void TurnOnTPMBypass(string Setting)
        {
            try
            {
                Registry.LocalMachine.OpenSubKey(@"SYSTEM\Setup\MoSetup", true).SetValue(Setting, "1", RegistryValueKind.DWord);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }
        public static void TurnOffTPMBypass(string Setting)
        {
            try
            {
                Registry.LocalMachine.OpenSubKey(@"SYSTEM\Setup\MoSetup", true).DeleteValue(Setting, true);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }
        #endregion


        #region "SearchSettings"
        public static void TurnOffSearchHighlights(string Setting)
        {
            try //Computer\HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\SearchSettings
            {
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\SearchSettings", true).SetValue(Setting, "1", RegistryValueKind.DWord);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }
        public static void TurnOnSearchHighlights(string Setting)
        {
            try
            {
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\SearchSettings", true).DeleteValue(Setting, true);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }
        #endregion


        #region "BingSearchSettings"
        public static void TurnOffBingSearch(string Setting)
        {
            try
            {
                Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Policies\Microsoft\Windows\Explorer", true).SetValue(Setting, "1", RegistryValueKind.DWord);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }
        public static void TurnOnBingSearch(string Setting)
        {
            try
            {
                Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Policies\Microsoft\Windows\Explorer", true).DeleteValue(Setting, true);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }
        #endregion


        #region "Windows Scripting Settings"
        public static void TurnOffScripting(string Setting)
        {
            try //SOFTWARE\Microsoft\Windows Script Host\Settings
            {
                Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows Script Host\Settings", true).SetValue(Setting, "0");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }
        public static void TurnOnScripting(string Setting)
        {
            try
            {
                Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows Script Host\Settings", true).DeleteValue(Setting, true);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        #endregion



        public static void DisableMSTele()
        {



          File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts"));


            string resource_data = Properties.Resources.MicrosoftTele;
            string[] words = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string lines in words)
            {


                using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts")))
                {
               
                        w.WriteLine(lines);
                   
                   
                }


            }





        }




        public static void EnableMSTele()
        {


            File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts"));

            string resource_data = Properties.Resources.HostDefault;
            string[] words = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string lines in words)
            {


                using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts")))
                {
                    w.WriteLine(lines);
                }


            }



        }
    }
}




