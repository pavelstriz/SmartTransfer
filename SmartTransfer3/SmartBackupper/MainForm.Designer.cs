namespace SmartBackupper
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpUp = new System.Windows.Forms.TableLayoutPanel();
            this.pToUp = new System.Windows.Forms.Panel();
            this.txtAvailableSpaceTo = new System.Windows.Forms.Label();
            this.cbDestinationDrive = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pFromUp = new System.Windows.Forms.Panel();
            this.txtAvailableSpaceFrom = new System.Windows.Forms.Label();
            this.cbExternalDrive = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tlpMid = new System.Windows.Forms.TableLayoutPanel();
            this.pToMid = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pFromMid = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tlpBottomAll = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTransferData = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnToAddPath = new System.Windows.Forms.Button();
            this.btnToRemovePath = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFromAddPath = new System.Windows.Forms.Button();
            this.btnFromRemovePath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tlpMain.SuspendLayout();
            this.tlpUp.SuspendLayout();
            this.pToUp.SuspendLayout();
            this.pFromUp.SuspendLayout();
            this.tlpMid.SuspendLayout();
            this.pToMid.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.pFromMid.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tlpBottomAll.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose paths";
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpMain.Controls.Add(this.tlpUp, 1, 1);
            this.tlpMain.Controls.Add(this.tlpMid, 1, 2);
            this.tlpMain.Controls.Add(this.tlpBottomAll, 1, 3);
            this.tlpMain.Controls.Add(this.label1, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.15929F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.11209F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.5F));
            this.tlpMain.Size = new System.Drawing.Size(777, 375);
            this.tlpMain.TabIndex = 3;
            // 
            // tlpUp
            // 
            this.tlpUp.ColumnCount = 2;
            this.tlpUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUp.Controls.Add(this.pToUp, 1, 0);
            this.tlpUp.Controls.Add(this.pFromUp, 0, 0);
            this.tlpUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUp.Location = new System.Drawing.Point(15, 36);
            this.tlpUp.Margin = new System.Windows.Forms.Padding(0);
            this.tlpUp.Name = "tlpUp";
            this.tlpUp.RowCount = 1;
            this.tlpUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUp.Size = new System.Drawing.Size(747, 48);
            this.tlpUp.TabIndex = 23;
            // 
            // pToUp
            // 
            this.pToUp.Controls.Add(this.txtAvailableSpaceTo);
            this.pToUp.Controls.Add(this.cbDestinationDrive);
            this.pToUp.Controls.Add(this.label5);
            this.pToUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pToUp.Location = new System.Drawing.Point(375, 2);
            this.pToUp.Margin = new System.Windows.Forms.Padding(2);
            this.pToUp.Name = "pToUp";
            this.pToUp.Size = new System.Drawing.Size(370, 44);
            this.pToUp.TabIndex = 1;
            // 
            // txtAvailableSpaceTo
            // 
            this.txtAvailableSpaceTo.AutoSize = true;
            this.txtAvailableSpaceTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtAvailableSpaceTo.Location = new System.Drawing.Point(225, 24);
            this.txtAvailableSpaceTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAvailableSpaceTo.Name = "txtAvailableSpaceTo";
            this.txtAvailableSpaceTo.Size = new System.Drawing.Size(46, 13);
            this.txtAvailableSpaceTo.TabIndex = 21;
            this.txtAvailableSpaceTo.Text = "{Space}";
            // 
            // cbDestinationDrive
            // 
            this.cbDestinationDrive.AllowDrop = true;
            this.cbDestinationDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinationDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbDestinationDrive.FormattingEnabled = true;
            this.cbDestinationDrive.Location = new System.Drawing.Point(2, 18);
            this.cbDestinationDrive.Margin = new System.Windows.Forms.Padding(2);
            this.cbDestinationDrive.Name = "cbDestinationDrive";
            this.cbDestinationDrive.Size = new System.Drawing.Size(219, 24);
            this.cbDestinationDrive.Sorted = true;
            this.cbDestinationDrive.TabIndex = 22;
            this.cbDestinationDrive.SelectedIndexChanged += new System.EventHandler(this.cbDestinationDrive_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(2, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Destination";
            // 
            // pFromUp
            // 
            this.pFromUp.Controls.Add(this.txtAvailableSpaceFrom);
            this.pFromUp.Controls.Add(this.cbExternalDrive);
            this.pFromUp.Controls.Add(this.label2);
            this.pFromUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFromUp.Location = new System.Drawing.Point(2, 2);
            this.pFromUp.Margin = new System.Windows.Forms.Padding(2);
            this.pFromUp.Name = "pFromUp";
            this.pFromUp.Size = new System.Drawing.Size(369, 44);
            this.pFromUp.TabIndex = 0;
            // 
            // txtAvailableSpaceFrom
            // 
            this.txtAvailableSpaceFrom.AutoSize = true;
            this.txtAvailableSpaceFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtAvailableSpaceFrom.Location = new System.Drawing.Point(225, 24);
            this.txtAvailableSpaceFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAvailableSpaceFrom.Name = "txtAvailableSpaceFrom";
            this.txtAvailableSpaceFrom.Size = new System.Drawing.Size(46, 13);
            this.txtAvailableSpaceFrom.TabIndex = 21;
            this.txtAvailableSpaceFrom.Text = "{Space}";
            // 
            // cbExternalDrive
            // 
            this.cbExternalDrive.AllowDrop = true;
            this.cbExternalDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExternalDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbExternalDrive.FormattingEnabled = true;
            this.cbExternalDrive.Location = new System.Drawing.Point(2, 18);
            this.cbExternalDrive.Margin = new System.Windows.Forms.Padding(2);
            this.cbExternalDrive.Name = "cbExternalDrive";
            this.cbExternalDrive.Size = new System.Drawing.Size(219, 24);
            this.cbExternalDrive.Sorted = true;
            this.cbExternalDrive.TabIndex = 22;
            this.cbExternalDrive.SelectedIndexChanged += new System.EventHandler(this.cbExternalDrive_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Source";
            // 
            // tlpMid
            // 
            this.tlpMid.ColumnCount = 2;
            this.tlpMid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMid.Controls.Add(this.pToMid, 1, 0);
            this.tlpMid.Controls.Add(this.pFromMid, 0, 0);
            this.tlpMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMid.Location = new System.Drawing.Point(15, 84);
            this.tlpMid.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMid.Name = "tlpMid";
            this.tlpMid.RowCount = 1;
            this.tlpMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMid.Size = new System.Drawing.Size(747, 197);
            this.tlpMid.TabIndex = 3;
            // 
            // pToMid
            // 
            this.pToMid.Controls.Add(this.tabControl2);
            this.pToMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pToMid.Location = new System.Drawing.Point(375, 2);
            this.pToMid.Margin = new System.Windows.Forms.Padding(2);
            this.pToMid.Name = "pToMid";
            this.pToMid.Size = new System.Drawing.Size(370, 193);
            this.pToMid.TabIndex = 4;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(370, 193);
            this.tabControl2.TabIndex = 3;
            this.tabControl2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl2_DrawItem);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(362, 167);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Preset 1";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pFromMid
            // 
            this.pFromMid.Controls.Add(this.tabControl1);
            this.pFromMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFromMid.Location = new System.Drawing.Point(2, 2);
            this.pFromMid.Margin = new System.Windows.Forms.Padding(2);
            this.pFromMid.Name = "pFromMid";
            this.pFromMid.Size = new System.Drawing.Size(369, 193);
            this.pFromMid.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(369, 193);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            this.tabControl1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabControl1_ControlAdded);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(361, 167);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Preset 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(361, 167);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "+";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tlpBottomAll
            // 
            this.tlpBottomAll.ColumnCount = 1;
            this.tlpBottomAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBottomAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBottomAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBottomAll.Controls.Add(this.panel3, 0, 1);
            this.tlpBottomAll.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpBottomAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBottomAll.Location = new System.Drawing.Point(15, 281);
            this.tlpBottomAll.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBottomAll.Name = "tlpBottomAll";
            this.tlpBottomAll.RowCount = 2;
            this.tlpBottomAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBottomAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlpBottomAll.Size = new System.Drawing.Size(747, 94);
            this.tlpBottomAll.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTransferData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 56);
            this.panel3.TabIndex = 1;
            // 
            // btnTransferData
            // 
            this.btnTransferData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTransferData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTransferData.Location = new System.Drawing.Point(309, 4);
            this.btnTransferData.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransferData.Name = "btnTransferData";
            this.btnTransferData.Size = new System.Drawing.Size(129, 47);
            this.btnTransferData.TabIndex = 1;
            this.btnTransferData.Text = "Compare";
            this.btnTransferData.UseVisualStyleBackColor = true;
            this.btnTransferData.Click += new System.EventHandler(this.btnTransferData_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(741, 32);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnToAddPath);
            this.panel2.Controls.Add(this.btnToRemovePath);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(370, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 32);
            this.panel2.TabIndex = 1;
            // 
            // btnToAddPath
            // 
            this.btnToAddPath.Location = new System.Drawing.Point(246, 2);
            this.btnToAddPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnToAddPath.Name = "btnToAddPath";
            this.btnToAddPath.Size = new System.Drawing.Size(59, 21);
            this.btnToAddPath.TabIndex = 2;
            this.btnToAddPath.Text = "Add";
            this.btnToAddPath.UseVisualStyleBackColor = true;
            this.btnToAddPath.Click += new System.EventHandler(this.btnToAddPath_Click);
            // 
            // btnToRemovePath
            // 
            this.btnToRemovePath.Location = new System.Drawing.Point(309, 2);
            this.btnToRemovePath.Margin = new System.Windows.Forms.Padding(2);
            this.btnToRemovePath.Name = "btnToRemovePath";
            this.btnToRemovePath.Size = new System.Drawing.Size(56, 21);
            this.btnToRemovePath.TabIndex = 3;
            this.btnToRemovePath.Text = "Remove";
            this.btnToRemovePath.UseVisualStyleBackColor = true;
            this.btnToRemovePath.Click += new System.EventHandler(this.btnToRemovePath_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFromAddPath);
            this.panel1.Controls.Add(this.btnFromRemovePath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 32);
            this.panel1.TabIndex = 0;
            // 
            // btnFromAddPath
            // 
            this.btnFromAddPath.Location = new System.Drawing.Point(245, 2);
            this.btnFromAddPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnFromAddPath.Name = "btnFromAddPath";
            this.btnFromAddPath.Size = new System.Drawing.Size(59, 21);
            this.btnFromAddPath.TabIndex = 0;
            this.btnFromAddPath.Text = "Add";
            this.btnFromAddPath.UseVisualStyleBackColor = true;
            this.btnFromAddPath.Click += new System.EventHandler(this.btnFromAddPath_Click);
            // 
            // btnFromRemovePath
            // 
            this.btnFromRemovePath.Location = new System.Drawing.Point(308, 2);
            this.btnFromRemovePath.Margin = new System.Windows.Forms.Padding(2);
            this.btnFromRemovePath.Name = "btnFromRemovePath";
            this.btnFromRemovePath.Size = new System.Drawing.Size(56, 21);
            this.btnFromRemovePath.TabIndex = 1;
            this.btnFromRemovePath.Text = "Remove";
            this.btnFromRemovePath.UseVisualStyleBackColor = true;
            this.btnFromRemovePath.Click += new System.EventHandler(this.btnFromRemovePath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 375);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartTransfer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpUp.ResumeLayout(false);
            this.pToUp.ResumeLayout(false);
            this.pToUp.PerformLayout();
            this.pFromUp.ResumeLayout(false);
            this.pFromUp.PerformLayout();
            this.tlpMid.ResumeLayout(false);
            this.pToMid.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.pFromMid.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tlpBottomAll.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpBottomAll;
        private System.Windows.Forms.Button btnTransferData;
        private System.Windows.Forms.Button btnFromAddPath;
        private System.Windows.Forms.Button btnFromRemovePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pFromUp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel pFromMid;
        private System.Windows.Forms.Label txtAvailableSpaceFrom;
        public System.Windows.Forms.ComboBox cbExternalDrive;
        private System.Windows.Forms.TableLayoutPanel tlpMid;
        private System.Windows.Forms.TableLayoutPanel tlpUp;
        private System.Windows.Forms.Panel pToUp;
        private System.Windows.Forms.Label txtAvailableSpaceTo;
        public System.Windows.Forms.ComboBox cbDestinationDrive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pToMid;
        public System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnToAddPath;
        private System.Windows.Forms.Button btnToRemovePath;
        private System.Windows.Forms.Panel panel1;
    }
}

