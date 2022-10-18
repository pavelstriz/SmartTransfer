using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SmartBackupper
{
    public partial class ComparePaths : Form
    {

        public TransferData transferDataMethod;
        private MainForm mainForm;
        private ProgressForm progressForm;
        
        public ComparePaths(MainForm _mainForm, ProgressForm _progressForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
            progressForm = _progressForm;
            transferDataMethod = new TransferData(mainForm, progressForm);
            
            

        }

        public ListViewItem item;
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            //Taxes: Remote Desktop Connection and painting
            //http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo aProp =
                  typeof(System.Windows.Forms.Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            aProp.SetValue(c, true, null);
        }
        private void DataGridViewSettings()
        {
            SetDoubleBuffered(dgv);
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Control;

            this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ColumnHeadersHeight = 25;
            this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.Columns["Column2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv.Columns["Column2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.MinimumSize = new Size(240, 0); //minimalni velikost okna
            this.dgv.Columns["Column2"].MinimumWidth = dgv.Columns["Column2"].Width; // minimalni velikost druheho sloupce
            this.dgv.Columns["Column1"].SortMode = DataGridViewColumnSortMode.NotSortable;

            this.dgv.Enabled = true;
        }

        private void LoadPathsToList()
        {
            //int index = 0;
            foreach (object listBoxItem2 in mainForm.uC_destination.customListBox1.Items)
            {
                int index = dgv.Rows.Add();
                dgv.Rows[index].Cells["Column1"].Value = mainForm.uC_destination.customListBox1.Items[index].ToString();
                

            }

        }
        private void ComparePaths_Load(object sender, EventArgs e)
        {
            DataGridViewSettings();
            LoadPathsToList();

            transferDataMethod.TransferToDestination(true, false, dgv);

            if (dgv.Controls.OfType<VScrollBar>().First().Visible)
            {
                this.dgv.Columns[0].Width = 255;
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            ProgressForm progressForm = new ProgressForm(mainForm, dgv);
            progressForm.ShowDialog(this);
            
        }

    }
}
