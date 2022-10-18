using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Collections;
using System.Reflection;

namespace SmartBackupper
{

    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            this.tabControl1.HandleCreated += new System.EventHandler(TabControl_HandleCreated);
            


        }
        public GetDrivesMethod getDrivesMethod;

        void TabControl_HandleCreated(object sender, System.EventArgs e)
        {
            // Send TCM_SETMINTABWIDTH
            SendMessage((sender as TabControl).Handle, 0x1300 + 49, IntPtr.Zero, (IntPtr)15);
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        int lastTabIndex;
        bool isReachedMax = false;

        int i = 1;

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            
            lastTabIndex = this.tabControl1.TabCount - 1;
            if (this.tabControl1.GetTabRect(lastTabIndex).Contains(e.Location) && isReachedMax != true)
            {
                if (tabControl1.Controls.Count <= 8)
                {
                    this.tabControl1.TabPages.Insert(lastTabIndex, "Preset " + tabControl1.TabPages.Count.ToString() + "   ");
                    this.tabControl1.SelectedIndex = lastTabIndex;

                    uC_Listboxes[i] = new UC_listbox1(this);
                    uC_Listboxes[i].Dock = DockStyle.Fill;
                    tabControl1.TabPages[i].BackColor = Color.White;
                    tabControl1.TabPages[i].Controls.Add(uC_Listboxes[i]);

                                                                               //}
                        i++;
                   

                    if (tabControl1.Controls.Count == 9)
                    {
                        isReachedMax = true;
                        this.tabControl1.Controls.RemoveAt(lastTabIndex + 1);

                        MessageBox.Show("You have reached the maximum number of tabs.", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                }
            }

            if (closeX.Contains(e.Location))
            {
                int selectedTabIndex = tabControl1.SelectedIndex - 1;
                //textBox1.Text = selectedTabIndex.ToString();

                tabControl1.TabPages.Remove(tabControl1.SelectedTab);

                if(tabControl1.Controls.Count > 1)
                    tabControl1.SelectTab(selectedTabIndex);
                i--;
                if (tabControl1.Controls.Count <= 8 && isReachedMax == true)
                {
                    isReachedMax = false;
                    lastTabIndex = this.tabControl1.TabCount;
                    this.tabControl1.TabPages.Insert(lastTabIndex, " + ");
                    MessageBox.Show(isReachedMax.ToString());
                    //isReachedMax = true;
                }

            }
        }
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == this.tabControl1.TabCount - 1 && isReachedMax != true)
                e.Cancel = true;
        }
        
        public UC_listbox1[] uC_Listboxes = new UC_listbox1[9];
        public UC_listbox1 uC_destination;

        public PropertyInfo[] props = Properties.Settings.Default.GetType().GetProperties();
        public SettingsProperty[] setProps = new SettingsProperty[9];

        private void LoadDestinationPaths()
        {
            uC_destination = new UC_listbox1(this);
            uC_destination.customListBox1.DrawItem += new DrawItemEventHandler(uC_Destination_customListBox1_DrawItem);
            uC_destination.customListBox1.Items.Add(@"C:\Users\" + Environment.UserName + "\\Desktop");
            uC_destination.customListBox1.Items.Add(@"C:\Users\" + Environment.UserName + "\\Documents");
            uC_destination.customListBox1.Items.Add(@"C:\Users\" + Environment.UserName + "\\AppData\\Roaming\\Thunderbird");
            uC_destination.customListBox1.Items.Add(@"C:\Users\" + Environment.UserName + "\\Documents\\TestFolder");
            tabControl2.TabPages[0].Controls.Add(uC_destination);
            
            

        }
        private void uC_Destination_customListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //if (e.Index == -1)
            //    return;
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            var rect = new Rectangle(e.Bounds.X, e.Bounds.Y, 10, 10);
            //assuming the icon is already added to project resources
            e.Graphics.DrawIconUnstretched(Properties.Resources.pbOk2, rect);
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDestinationPaths();

            tabControl1.SelectedIndex = 0;
            getDrivesMethod = new GetDrivesMethod(this);
            getDrivesMethod.LoadExternalDrives();

            
            uC_Listboxes[0] = new UC_listbox1(this);
            uC_Listboxes[0].Dock = DockStyle.Fill;

            
            tabControl1.TabPages[0].BackColor = Color.White;
            uC_Listboxes[0].customListBox1.Items.Add(@"D:\TestFolder");
            tabControl1.TabPages[0].Controls.Add(uC_Listboxes[0]);

            for (int a = 1; a <= 8;a++)
            {
                //objProps = new object[a];
                setProps[a] = Properties.Settings.Default.Properties["listboxItems" + a.ToString()];
                //MessageBox.Show(a.ToString());
            }

            if (Properties.Settings.Default.listboxItems1 == null)
            {
                Properties.Settings.Default.listboxItems1 = new ArrayList();

            }
            else
            {
                uC_Listboxes[0].customListBox1.Items.AddRange(Properties.Settings.Default.listboxItems1.ToArray());
            }



            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl2.DrawMode = TabDrawMode.OwnerDrawFixed;
            foreach (TabPage tp in tabControl1.TabPages) tp.Text += "   ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (SettingsProperty settingsProperty in Properties.Settings.Default.Properties)
            {
                if (settingsProperty != null)
                {
                    tabControl1.TabPages.Add("Preset " + tabControl1.TabPages.Count.ToString());

                }
            }
        }

        private void SaveProperties(ArrayList arrayList)
        {
            
                for (int tabIndex = 0; tabIndex < tabControl1.TabCount - 1; tabIndex++)
                {

                    for (int itemIndex = 0; itemIndex < uC_Listboxes[tabIndex].customListBox1.Items.Count; itemIndex++)
                    {

                        arrayList.Add(uC_Listboxes[tabIndex].customListBox1.Items[itemIndex].ToString());

                    }
                }
            
        }

        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.listboxItems1.Clear();
            //SaveProperties(Properties.Settings.Default.listboxItems1);
            Properties.Settings.Default.Save();

            //Properties.Settings.Default.listboxItems2.Clear();
            //SaveProperties(Properties.Settings.Default.listboxItems2);

        }

        private void tabControl1_ControlAdded(object sender, ControlEventArgs e)
        {
           


        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == -1 || tabControl1.SelectedIndex == null)
            {
                return;
            }
            else
            {
                
            }

        }

        Rectangle closeX = Rectangle.Empty;
        
        private void DrawTabControlItems(TabControl tabControl, DrawItemEventArgs args)
        {
            //Get the working area of the TabControl main control
            Size xSize = new Size(13, 13);

            Rectangle rec = tabControl.ClientRectangle;
            //Create a StringFormat object to set the layout of the label text
            StringFormat StrFormat = new StringFormat();
            StrFormat.LineAlignment = StringAlignment.Center;// Set the text to be centered vertically
            StrFormat.Alignment = StringAlignment.Center;// Set the text to be centered horizontally

            // The background fill color of the label, it can also be a picture (e.Graphics.DrawImage)
            SolidBrush backColor = new SolidBrush(Color.White);
            SolidBrush fontColor;// Label font color
                                 //Draw the background of the main control
            args.Graphics.FillRectangle(backColor, rec);

            Font fntTab = args.Font;


            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {

                bool bSelected = (tabControl.SelectedIndex == i);
                Rectangle recBounds = tabControl.GetTabRect(i);


                RectangleF tabTextArea = (RectangleF)tabControl.GetTabRect(i);



                if (bSelected && tabControl.Name == "tabControl1")
                {
                    args.Graphics.FillRectangle(new SolidBrush(Color.White), recBounds);

                    fontColor = new SolidBrush(Color.Black);
                    args.Graphics.DrawString(tabControl.TabPages[i].Text + "   ", fntTab, fontColor, args.Bounds.Left + 5, args.Bounds.Y + 4);

                    closeX = new Rectangle(
                    args.Bounds.Right - xSize.Width, args.Bounds.Top, xSize.Width, xSize.Height);
                    using (SolidBrush brush = new SolidBrush(Color.Black))
                        args.Graphics.DrawString("x", fntTab, brush,
                                               args.Bounds.Right - xSize.Width, args.Bounds.Y + 4);


                }
                else
                {
                    fontColor = new SolidBrush(Color.Black);
                    args.Graphics.DrawString(tabControl.TabPages[i].Text + "   ", fntTab, fontColor, tabTextArea, StrFormat);
                }
            }
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawTabControlItems(tabControl1, e);
        }
        private void tabControl2_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawTabControlItems(tabControl2, e);
        }
        string myComputerPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
        
        private void btnOpenDestination_Click(object sender, EventArgs e)
        {
            

        }
        public String buttonName;
        private void btnFromAddPath_Click(object sender, EventArgs e)
        {
            buttonName = ((Button)sender).Name;

            AddPath addSourcePath = new AddPath(this);
            addSourcePath.Text = "Add Source Path";
            addSourcePath.ShowDialog();
        }
        private void btnToAddPath_Click(object sender, EventArgs e)
        {
            buttonName = ((Button)sender).Name;

            AddPath addDestinationPath = new AddPath(this);
            addDestinationPath.Text = "Add Destination Path";
            addDestinationPath.ShowDialog();
        }
        private void btnFromRemovePath_Click(object sender, EventArgs e)
        {
           uC_Listboxes[tabControl1.SelectedIndex].customListBox1.Items.Remove(uC_Listboxes[tabControl1.SelectedIndex].customListBox1.SelectedItem);
            
        }
        private void btnToRemovePath_Click(object sender, EventArgs e)
        {
           uC_destination.customListBox1.Items.Remove(uC_destination.customListBox1.SelectedItem);

        }


        private void btnTransferData_Click(object sender, EventArgs e)
        {
            ComparePaths comparePaths = new ComparePaths(this, null);
            comparePaths.ShowDialog();
        }


        private void cbExternalDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbExternalDrive.SelectedIndex + 1;
            txtAvailableSpaceFrom.Text = getDrivesMethod.FormatBytes(getDrivesMethod.diskInfos[index + 1].TotalFreeSize, getDrivesMethod.diskInfos[index + 1].TotalSize);
        }
        private void cbDestinationDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbDestinationDrive.SelectedIndex + 1;
            txtAvailableSpaceTo.Text = getDrivesMethod.FormatBytes(getDrivesMethod.diskInfos[index].TotalFreeSize, getDrivesMethod.diskInfos[index].TotalSize);
        }

    }
}
