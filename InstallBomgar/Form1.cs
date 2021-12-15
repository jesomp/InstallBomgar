/*
 * Author       : Jesom Paingi
 * Date Created : 26/06/2014
 * Pre-requisite: .NET Framework 4.0
 * Date Modified: 22/05/2017
 * 
 * This program installs bomgar on remote machines.
 * Added Set IP functionality and better exception handling
 * Added compatibility for Windows 2000 POS
 * Prefill Bomgar File in the app
 * Ok and Cancel functionality from Keyboard
 */

using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace InstallBomgar
{
    public partial class FormInstallBomgar : Form
    {
        private const string BOMGARFILE = "bomgar-scc-w0idc305x656z7ge51ewgd1g7x68xzh7gfhhde6c40jc90.exe";

        public FormInstallBomgar()
        {
            InitializeComponent();
           
            if (File.Exists(BOMGARFILE))
                textBoxBomgar.Text = BOMGARFILE;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Install bomgar on remote Pos
        private void ButtonInstall_Click(object sender, EventArgs e)
        {
            string destination = @"\\" + textBoxDestination.Text;
            string sourceBomgar = textBoxBomgar.Text;
            string sourceHosts = "hosts";

            string bomgarDestination = destination + @"\C\" + sourceBomgar;
            string hostsDestination = null;

            if (Directory.Exists(destination + @"\C\Windows"))
                hostsDestination = destination + @"\C\Windows\System32\Drivers\etc\" + sourceHosts;
            else if (Directory.Exists(destination + @"\C\WINNT"))
                hostsDestination = destination + @"\C\WINNT\System32\Drivers\etc\" + sourceHosts;

            bool wasBomgarFilesCopied = false;

            try
            {
                File.Copy(sourceBomgar, bomgarDestination, true);
                File.Copy(sourceHosts, hostsDestination, true);

                if (File.Exists(bomgarDestination) && File.Exists(hostsDestination))
                    wasBomgarFilesCopied = true;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Dispose();
            }

            if (wasBomgarFilesCopied)
            {
                try
                {
                    if (InstallBomgar(sourceBomgar, destination))
                    {
                        MessageBox.Show("Bomgar install successful !", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    Dispose();
                }
            }
        }

        //Command to install bomgar
        private static bool InstallBomgar(string sourceBomgar, string destination)
        {
            bool wasCommandSuccessful = false;
            string installBomgar = "psexec -i " + destination + @" C:\" + sourceBomgar;

            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.Arguments = "/C " + installBomgar;
            myProcess.Start();
            myProcess.Close();

            wasCommandSuccessful = true;

            return wasCommandSuccessful;
        }

        private void TextBoxDestination_TextChanged(object sender, EventArgs e)
        {
            EnableInstallButton();
        }

        private void TextBoxBomgar_TextChanged(object sender, EventArgs e)
        {
            EnableInstallButton();
        }

        //Enable Install Button
        private void EnableInstallButton()
        {
            if ((!string.IsNullOrEmpty(textBoxBomgar.Text)) && (!string.IsNullOrEmpty(textBoxDestination.Text)))
                buttonInstall.Enabled = true;
            else if ((string.IsNullOrEmpty(textBoxBomgar.Text)) || (string.IsNullOrEmpty(textBoxDestination.Text)))
                buttonInstall.Enabled = false;
        }
    }
}