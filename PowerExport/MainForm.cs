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

            int Version = officeVersionComboBox.SelectedIndex;

            if (Version == -1) {
                errorToolTip.Show("Please select the office version you wish to change the resolution for!", officeVersionComboBox);
                return;
            }

            MessageBox.Show("Changing version: " + Version.ToString() + " at " + officeVersion[Version, 1] + " with " + requiredResolution);


            //Registry.SetValue(, 1].ToString(), "ExportBitmapResolution", 200, RegistryValueKind.DWord);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++) {
                if (Registry.GetValue(officeVersion[i, 1].ToString(), "ExportBitmapResolution", "96") == null) {
                    officeVersion[i, 2] = false;
                }
                else {
                    officeVersionComboBox.Items.Add(officeVersion[i, 0].ToString());
                }
            }
        }


    }
}
