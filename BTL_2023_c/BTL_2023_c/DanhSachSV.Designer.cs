﻿
namespace BTL_2023_c
{
    partial class DanhSachSV
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
            this.cryDSSV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryDSSV
            // 
            this.cryDSSV.ActiveViewIndex = -1;
            this.cryDSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryDSSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryDSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryDSSV.Location = new System.Drawing.Point(0, 0);
            this.cryDSSV.Name = "cryDSSV";
            this.cryDSSV.Size = new System.Drawing.Size(1402, 450);
            this.cryDSSV.TabIndex = 0;
            this.cryDSSV.Load += new System.EventHandler(this.cryDSSV_Load);
            // 
            // DanhSachSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 450);
            this.Controls.Add(this.cryDSSV);
            this.Name = "DanhSachSV";
            this.Text = "DanhSachSV";
            this.Load += new System.EventHandler(this.DanhSachSV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryDSSV;
    }
}