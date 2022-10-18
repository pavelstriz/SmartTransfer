
namespace SmartBackupper
{
    partial class ProgressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPercentage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCopySpeed = new System.Windows.Forms.Label();
            this.txtFilePaths = new System.Windows.Forms.Label();
            this.txtOfMax = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPercentage);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtCopySpeed);
            this.panel1.Controls.Add(this.txtFilePaths);
            this.panel1.Controls.Add(this.txtOfMax);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 171);
            this.panel1.TabIndex = 0;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPercentage.AutoSize = true;
            this.txtPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPercentage.Location = new System.Drawing.Point(405, 18);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPercentage.Size = new System.Drawing.Size(30, 17);
            this.txtPercentage.TabIndex = 5;
            this.txtPercentage.Text = "{%}";
            this.txtPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(181, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCopySpeed
            // 
            this.txtCopySpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCopySpeed.AutoSize = true;
            this.txtCopySpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCopySpeed.Location = new System.Drawing.Point(390, 62);
            this.txtCopySpeed.Name = "txtCopySpeed";
            this.txtCopySpeed.Size = new System.Drawing.Size(32, 17);
            this.txtCopySpeed.TabIndex = 3;
            this.txtCopySpeed.Text = "{cs}";
            // 
            // txtFilePaths
            // 
            this.txtFilePaths.AutoSize = true;
            this.txtFilePaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.txtFilePaths.Location = new System.Drawing.Point(12, 62);
            this.txtFilePaths.Name = "txtFilePaths";
            this.txtFilePaths.Size = new System.Drawing.Size(87, 13);
            this.txtFilePaths.TabIndex = 2;
            this.txtFilePaths.Text = "{Current file path}";
            // 
            // txtOfMax
            // 
            this.txtOfMax.AutoSize = true;
            this.txtOfMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtOfMax.Location = new System.Drawing.Point(12, 18);
            this.txtOfMax.Name = "txtOfMax";
            this.txtOfMax.Size = new System.Drawing.Size(96, 17);
            this.txtOfMax.TabIndex = 1;
            this.txtOfMax.Text = "Copying files..";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(15, 38);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(429, 21);
            this.progressBar1.TabIndex = 0;
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 171);
            this.Controls.Add(this.panel1);
            this.Name = "ProgressForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progress";
            this.Load += new System.EventHandler(this.ProgressForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtCopySpeed;
        private System.Windows.Forms.Label txtOfMax;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label txtFilePaths;
        public System.Windows.Forms.Label txtPercentage;
    }
}