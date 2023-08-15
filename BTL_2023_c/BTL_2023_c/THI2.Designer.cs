
namespace BTL_2023_c
{
    partial class THI2
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
            this.cryThi2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryThi2
            // 
            this.cryThi2.ActiveViewIndex = -1;
            this.cryThi2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryThi2.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryThi2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryThi2.Location = new System.Drawing.Point(0, 0);
            this.cryThi2.Name = "cryThi2";
            this.cryThi2.Size = new System.Drawing.Size(1334, 450);
            this.cryThi2.TabIndex = 0;
            this.cryThi2.Load += new System.EventHandler(this.cryThi2_Load);
            // 
            // THI2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 450);
            this.Controls.Add(this.cryThi2);
            this.Name = "THI2";
            this.Text = "THI2";
            this.Load += new System.EventHandler(this.THI2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryThi2;
    }
}