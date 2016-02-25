namespace Adaptive_Security
{
    partial class frmScanConnectedDevices
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
            this.btnStartScan = new System.Windows.Forms.Button();
            this.gvActiveClients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvActiveClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(246, 12);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(231, 30);
            this.btnStartScan.TabIndex = 0;
            this.btnStartScan.Text = "Scan Attached Active Clients";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // gvActiveClients
            // 
            this.gvActiveClients.AllowUserToAddRows = false;
            this.gvActiveClients.AllowUserToDeleteRows = false;
            this.gvActiveClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvActiveClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvActiveClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvActiveClients.Location = new System.Drawing.Point(12, 59);
            this.gvActiveClients.Name = "gvActiveClients";
            this.gvActiveClients.Size = new System.Drawing.Size(704, 204);
            this.gvActiveClients.TabIndex = 1;
            // 
            // frmScanConnectedDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 288);
            this.Controls.Add(this.gvActiveClients);
            this.Controls.Add(this.btnStartScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmScanConnectedDevices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scan Connected Devices";
            ((System.ComponentModel.ISupportInitialize)(this.gvActiveClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.DataGridView gvActiveClients;
    }
}