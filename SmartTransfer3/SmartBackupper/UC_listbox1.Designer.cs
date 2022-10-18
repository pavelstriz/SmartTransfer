namespace SmartBackupper
{
    partial class UC_listbox1
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

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.customListBox1 = new SmartBackupper.CustomListBox();
            this.SuspendLayout();
            // 
            // customListBox1
            // 
            this.customListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customListBox1.FormattingEnabled = true;
            this.customListBox1.Location = new System.Drawing.Point(0, 0);
            this.customListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.customListBox1.Name = "customListBox1";
            this.customListBox1.ReadOnly = false;
            this.customListBox1.Size = new System.Drawing.Size(379, 275);
            this.customListBox1.TabIndex = 1;
            this.customListBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.customListBox1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.customListBox1_ControlAdded);
            // 
            // UC_listbox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customListBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_listbox1";
            this.Size = new System.Drawing.Size(379, 275);
            this.Load += new System.EventHandler(this.UC_listbox1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CustomListBox customListBox1;
    }
}
