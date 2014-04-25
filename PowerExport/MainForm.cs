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

       public List<VersionsInfo> versions = new List<VersionsInfo>(new[]
            { 
                new VersionsInfo("2013", @"HKEY_CURRENT_USER\Software\Microsoft\Office\15.0\PowerPoint\Options", "", true),
                new VersionsInfo("2010", @"HKEY_CURRENT_USER\Software\Microsoft\Office\14.0\PowerPoint\Options", "", true),
                new VersionsInfo("2007", @"HKEY_CURRENT_USER\Software\Microsoft\Office\12.0\PowerPoint\Options", "", true),
                new VersionsInfo("2003", @"HKEY_CURRENT_USER\Software\Microsoft\Office\11.0\PowerPoint\Options", "", true)
            });


        public MainForm()
        {
            InitializeComponent();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            
                string requiredResolution;

                try {
                    requiredResolution = resolutionComboBox.SelectedItem.ToString();
                }
                catch (NullReferenceException ex) {
                    errorToolTip.Show("Please select the required resolution first!", resolutionComboBox);
                    return;
                }
            
                int choosenVersion = officeVersionComboBox.SelectedIndex;

                if (choosenVersion == -1) {
                    errorToolTip.Show("Please select the office version you wish to change the resolution for!", officeVersionComboBox);
                    return;
                }
            
            //Registry.SetValue(, 1].ToString(), "ExportBitmapResolution", 200, RegistryValueKind.DWord);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Detect installed office versions and add the detected versions to the combo box
            for (int i = 0; i < versions.Count; i++) {
                if (Registry.GetValue(versions[i].location, "ExportBitmapResolution", "96") == null)
                    versions[i].installed = false;
                else
                    versions[i].currentResolution = Registry.GetValue(versions[i].location, "ExportBitmapResolution", "96").ToString();
                
                if (versions[i].installed)
                    officeVersionComboBox.Items.Add(versions[i].versionName);
            }

            //Add available resolutions to the resolution combo box
            for (int i = 0; i < availableResoltions.Length; i++)
                resolutionComboBox.Items.Add(availableResoltions[i]);

        }


    }
}
