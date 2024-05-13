namespace GUI_KhachSan
{
    partial class GUI_InHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_InHoaDon));
            this.frmInHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // frmInHoaDon
            // 
            this.frmInHoaDon.ActiveViewIndex = -1;
            this.frmInHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmInHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.frmInHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmInHoaDon.Location = new System.Drawing.Point(0, 0);
            this.frmInHoaDon.Name = "frmInHoaDon";
            this.frmInHoaDon.Size = new System.Drawing.Size(1223, 749);
            this.frmInHoaDon.TabIndex = 0;
            // 
            // GUI_InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 749);
            this.Controls.Add(this.frmInHoaDon);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GUI_InHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer frmInHoaDon;
    }
}