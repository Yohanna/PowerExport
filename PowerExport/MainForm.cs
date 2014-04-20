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
        public MainForm()
        {
            InitializeComponent();
            resolutionComboBox.SelectedIndex = 0;
            officeVersionComboBox.SelectedIndex = 0;

        //    RegistryKey key = Registry.CurrentUser.OpenSubKey("test");
        //    key.SetValue()
        //Registry.

            
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //tAblelAYOutPanel1.

        }


    }
}
