
namespace BTL_2023_c
{
    partial class dsNV
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
            this.dsNvCrys = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // dsNvCrys
            // 
            this.dsNvCrys.ActiveViewIndex = -1;
            this.dsNvCrys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dsNvCrys.Cursor = System.Windows.Forms.Cursors.Default;
            this.dsNvCrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsNvCrys.Location = new System.Drawing.Point(0, 0);
            this.dsNvCrys.Name = "dsNvCrys";
            this.dsNvCrys.Size = new System.Drawing.Size(1501, 474);
            this.dsNvCrys.TabIndex = 0;
            this.dsNvCrys.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // dsNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 474);
            this.Controls.Add(this.dsNvCrys);
            this.Name = "dsNV";
            this.Text = "dsNV";
            this.Load += new System.EventHandler(this.dsNV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer dsNvCrys;
    }
}