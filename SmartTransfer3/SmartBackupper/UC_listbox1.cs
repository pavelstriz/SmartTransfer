using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace SmartBackupper
{
    public partial class UC_listbox1 : UserControl
    {

        private MainForm main1;
        public UC_listbox1(MainForm _main1)
        {
            InitializeComponent();
            main1 = _main1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customListBox1.SelectedIndex == -1) return;

            try
            {
                //string path = main1.uC_Listboxes[main1.tabControl1.SelectedIndex].customListBox1.SelectedItem.ToString();
                //string lastFolderName = Path.GetFileName(path);


            }
            catch
            {

            }
        }

        private void customListBox1_ControlAdded(object sender, ControlEventArgs e)
        {
            
            
        }

        private void UC_listbox1_Load(object sender, EventArgs e)
        {

        }
    }
}
