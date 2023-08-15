
namespace BTL_2023_c
{
    partial class hienDSDiem
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
            this.tb_diemA = new System.Windows.Forms.TextBox();
            this.tb_DiemB = new System.Windows.Forms.TextBox();
            this.btnHien = new System.Windows.Forms.Button();
            this.hienbangDiemCrys = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_diemA
            // 
            this.tb_diemA.Location = new System.Drawing.Point(585, 15);
            this.tb_diemA.Name = "tb_diemA";
            this.tb_diemA.Size = new System.Drawing.Size(100, 22);
            this.tb_diemA.TabIndex = 0;
            // 
            // tb_DiemB
            // 
            this.tb_DiemB.Location = new System.Drawing.Point(729, 13);
            this.tb_DiemB.Name = "tb_DiemB";
            this.tb_DiemB.Size = new System.Drawing.Size(100, 22);
            this.tb_DiemB.TabIndex = 0;
            // 
            // btnHien
            // 
            this.btnHien.Location = new System.Drawing.Point(835, 15);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(75, 23);
            this.btnHien.TabIndex = 1;
            this.btnHien.Text = "In";
            this.btnHien.UseVisualStyleBackColor = true;
            this.btnHien.Click += new System.EventHandler(this.btnHien_Click);
            // 
            // hienbangDiemCrys
            // 
            this.hienbangDiemCrys.ActiveViewIndex = -1;
            this.hienbangDiemCrys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hienbangDiemCrys.Cursor = System.Windows.Forms.Cursors.Default;
            this.hienbangDiemCrys.Location = new System.Drawing.Point(98, 58);
            this.hienbangDiemCrys.Name = "hienbangDiemCrys";
            this.hienbangDiemCrys.Size = new System.Drawing.Size(1143, 463);
            this.hienbangDiemCrys.TabIndex = 2;
            this.hienbangDiemCrys.Load += new System.EventHandler(this.hienbangDiemCrys_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "In danh sách chi tiết điểm có điểm tổng kết từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "đến";
            // 
            // hienDSDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hienbangDiemCrys);
            this.Controls.Add(this.btnHien);
            this.Controls.Add(this.tb_DiemB);
            this.Controls.Add(this.tb_diemA);
            this.Name = "hienDSDiem";
            this.Text = "hienDSDiem";
            this.Load += new System.EventHandler(this.hienDSDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_diemA;
        private System.Windows.Forms.TextBox tb_DiemB;
        private System.Windows.Forms.Button btnHien;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer hienbangDiemCrys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}