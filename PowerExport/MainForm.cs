using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PowerExport
{
    public partial class MainForm : Form
    {

        object[,] officeVersion = {
    {"2013", @"HKEY_CURRENT_USER\Software\Microsoft\Office\15.0\PowerPoint\Options", true},
    {"2010", @"HKEY_CURRENT_USER\Software\Microsoft\Office\14.0\PowerPoint\Options", true},
    {"2007", @"HKEY_CURRENT_USER\Software\Microsoft\Office\12.0\PowerPoint\Options", true},
    {"2003", @"HKEY_CURRENT_USER\Software\Microsoft\Office\11.0\PowerPoint\Options", true}
    
    };

        string[] availableResoltions = { "50", "96", "100", "150", "200", "250", "300", "307" };

        public List<VersionsInfo> versionsList = new List<VersionsInfo>(new[]
            { 
                new VersionsInfo("2013", @"HKEY_CURRENT_USER\Software\Microsoft\Office\15.0\PowerPoint\Options", "", true),
                new VersionsInfo("2010", @"HKEY_CURRENT_USER\Software\Microsoft\Office\14.0\PowerPoint\Options", "", true),
                new VersionsInfo("2007", @"HKEY_CURRENT_USER\Software\Microsoft\Office\12.0\PowerPoint\Options", "", true),
                new VersionsInfo("2003", @"HKEY_CURRENT_USER\Software\Microsoft\Office\11.0\PowerPoint\Options", "", true)
            });


        public MainForm() {
            InitializeComponent();
        }

        private void changeButton_Click(object sender, EventArgs e) {

            string choosenResolution;

            try {
                choosenResolution = resolutionComboBox.SelectedItem.ToString();
            }
            catch (NullReferenceException ex) {
                errorToolTip.Show("Please select the required resolution first!", resolutionComboBox);
                return;
            }
            string choosenVersion;

            try {
                choosenVersion = officeVersionComboBox.SelectedItem.ToString();
            }
            catch (NullReferenceException ex) {
                errorToolTip.Show("Please select the office version you wish to change the resolution for!", officeVersionComboBox);
                return;
            }


            for (int i = 0; i < versionsList.Count; i++) {
                if (versionsList[i].versionName == choosenVersion) {
                    Registry.SetValue(versionsList[i].location, "ExportBitmapResolution", choosenResolution, RegistryValueKind.DWord);

                    object check = Registry.GetValue(versionsList[i].location, "ExportBitmapResolution", "96");

                    if (check == null)
                        MessageBox.Show("Failed");
                    else
                        MessageBox.Show("Resolution Changed Successfully !");
                }
            }


        }

        private void MainForm_Load(object sender, EventArgs e) {
            //Detect installed office versions and add the detected versions to the combo box
            for (int i = 0; i < versionsList.Count; i++) {
                if (Registry.GetValue(versionsList[i].location, "ExportBitmapResolution", "96") == null)
                    versionsList[i].installed = false;
                else
                    versionsList[i].currentResolution = Registry.GetValue(versionsList[i].location, "ExportBitmapResolution", "96").ToString();

                if (versionsList[i].installed)
                    officeVersionComboBox.Items.Add(versionsList[i].versionName);
            }

            //Add available resolutions to the resolution combo box
            for (int i = 0; i < availableResoltions.Length; i++)
                resolutionComboBox.Items.Add(availableResoltions[i]);

        }


    }
}
