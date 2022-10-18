using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartBackupper
{
    public partial class AddPath : Form
    {
        private MainForm mainForm;
        
        public AddPath(MainForm _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.Title = "Choose path";
            folderBrowser.InitialDirectory = @"C:\Users\" + Environment.UserName;
            // Set validate names and check file exists to false otherwise windows will
            // not let you select "Folder Selection."
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            // Always default to Folder Selection.
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                //MessageBox.Show(folderPath);
                txtAddPath.Text = folderPath;
               // DirectoryInfo parentDir = Directory.GetParent(folderPath.EndsWith("\\") ? folderPath : string.Concat(folderPath, "\\"));

                // The result is available here
               // var myParentDir = parentDir.Parent.FullName;
                //MessageBox.Show(folderPath);
            }
        }
        //ArrayList[] arrayLists = new ArrayList[8];

        private void PathSettings(string path1)
        {
            //if(path1 == )
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string lastFolderName = Path.GetFileName(txtAddPath.Text);

            if (mainForm.buttonName == "btnFromAddPath")
            {
                
                //txtAddPath.Text = @"C:\Users\" + Environment.UserName;
                mainForm.uC_Listboxes[mainForm.tabControl1.SelectedIndex].customListBox1.Items.Add(txtAddPath.Text);
                mainForm.uC_Listboxes[mainForm.tabControl1.SelectedIndex].customListBox1.SelectedIndex
                    = mainForm.uC_Listboxes[mainForm.tabControl1.SelectedIndex].customListBox1.Items.Count - 1;
            }else if(mainForm.buttonName == "btnToAddPath")
            {
                //txtAddPath.Text = @"C:\Users\" + Environment.UserName;
                mainForm.uC_destination.customListBox1.Items.Add(txtAddPath.Text);
                mainForm.uC_destination.customListBox1.SelectedIndex
                    = mainForm.uC_destination.customListBox1.Items.Count - 1;
            }



           /* for(int activeTab = 0; activeTab < mainForm.tabControl1.TabCount; activeTab++)
            {
                MessageBox.Show(activeTab.ToString());
                //var newList = new ArrayList();
                foreach (object item in mainForm.uC_Listboxes[mainForm.tabControl1.SelectedIndex].customListBox1.Items)
                {
                    arrayLists[activeTab] = new ArrayList();
                    arrayLists[activeTab].Add(item);

                    Properties.Settings.Default.listboxItems1[activeTab].Add(item);
                    Properties.Settings.Default.Save();
                }
                //MessageBox.Show(activeTab.ToString());
                //Properties.Settings.Default.listboxItems1[activeTab]. = arrayLists[activeTab]; //ADD TO SETTINGS XML System.Collections.ArrayList[] BRACKETS
                //Properties.Settings.Default.Save();
            }*/



            /*
            var newList = new ArrayList();
            foreach (object item in mainForm.uC_Listboxes[0].customListBox1.Items)
            {
                newList.Add(item);
            }
            Properties.Settings.Default.listboxItems1 = newList; //ADD TO SETTINGS XML System.Collections.ArrayList[] BRACKETS
            Properties.Settings.Default.Save();
            */
            this.Close();
        }
        private void btnStorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPath_Load(object sender, EventArgs e)
        {
            //txtAddPath.Text = @"C:\Users\" + Environment.UserName;
            
        }
    }
}
