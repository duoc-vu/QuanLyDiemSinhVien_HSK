
namespace BTL_2023_c
{
    partial class QLCTDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridCTDiem = new System.Windows.Forms.DataGridView();
            this.btn_themCTDiem = new System.Windows.Forms.Button();
            this.btn_suaCTDiem = new System.Windows.Forms.Button();
            this.btn_xoaCTDiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mask_diemCC = new System.Windows.Forms.MaskedTextBox();
            this.mask_diemGK = new System.Windows.Forms.MaskedTextBox();
            this.mask_diemCK = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mask_ngayHoc = new System.Windows.Forms.MaskedTextBox();
            this.mask_maMh = new System.Windows.Forms.MaskedTextBox();
            this.mask_maSv = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCTDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã môn học";
            // 
            // dataGridCTDiem
            // 
            this.dataGridCTDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCTDiem.Location = new System.Drawing.Point(486, 48);
            this.dataGridCTDiem.Name = "dataGridCTDiem";
            this.dataGridCTDiem.RowHeadersWidth = 51;
            this.dataGridCTDiem.RowTemplate.Height = 24;
            this.dataGridCTDiem.Size = new System.Drawing.Size(810, 274);
            this.dataGridCTDiem.TabIndex = 12;
            this.dataGridCTDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCTDiem_CellClick);
            this.dataGridCTDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCTDiem_CellContentClick);
            // 
            // btn_themCTDiem
            // 
            this.btn_themCTDiem.Location = new System.Drawing.Point(270, 399);
            this.btn_themCTDiem.Name = "btn_themCTDiem";
            this.btn_themCTDiem.Size = new System.Drawing.Size(79, 30);
            this.btn_themCTDiem.TabIndex = 13;
            this.btn_themCTDiem.Text = "Thêm";
            this.btn_themCTDiem.UseVisualStyleBackColor = true;
            this.btn_themCTDiem.Click += new System.EventHandler(this.btn_themCTDiem_Click);
            // 
            // btn_suaCTDiem
            // 
            this.btn_suaCTDiem.Location = new System.Drawing.Point(603, 399);
            this.btn_suaCTDiem.Name = "btn_suaCTDiem";
            this.btn_suaCTDiem.Size = new System.Drawing.Size(79, 30);
            this.btn_suaCTDiem.TabIndex = 14;
            this.btn_suaCTDiem.Text = "Sửa";
            this.btn_suaCTDiem.UseVisualStyleBackColor = true;
            this.btn_suaCTDiem.Click += new System.EventHandler(this.btn_suaCTDiem_Click);
            // 
            // btn_xoaCTDiem
            // 
            this.btn_xoaCTDiem.Location = new System.Drawing.Point(935, 399);
            this.btn_xoaCTDiem.Name = "btn_xoaCTDiem";
            this.btn_xoaCTDiem.Size = new System.Drawing.Size(79, 30);
            this.btn_xoaCTDiem.TabIndex = 15;
            this.btn_xoaCTDiem.Text = "Xóa";
            this.btn_xoaCTDiem.UseVisualStyleBackColor = true;
            this.btn_xoaCTDiem.Click += new System.EventHandler(this.btn_xoaCTDiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm chuyên cần";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm giữa kì";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm cuối kì";
            // 
            // mask_diemCC
            // 
            this.mask_diemCC.Location = new System.Drawing.Point(214, 192);
            this.mask_diemCC.Name = "mask_diemCC";
            this.mask_diemCC.Size = new System.Drawing.Size(185, 22);
            this.mask_diemCC.TabIndex = 8;
            // 
            // mask_diemGK
            // 
            this.mask_diemGK.Location = new System.Drawing.Point(214, 250);
            this.mask_diemGK.Name = "mask_diemGK";
            this.mask_diemGK.Size = new System.Drawing.Size(185, 22);
            this.mask_diemGK.TabIndex = 9;
            // 
            // mask_diemCK
            // 
            this.mask_diemCK.Location = new System.Drawing.Point(214, 302);
            this.mask_diemCK.Name = "mask_diemCK";
            this.mask_diemCK.Size = new System.Drawing.Size(185, 22);
            this.mask_diemCK.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày học";
            // 
            // mask_ngayHoc
            // 
            this.mask_ngayHoc.Location = new System.Drawing.Point(215, 149);
            this.mask_ngayHoc.Name = "mask_ngayHoc";
            this.mask_ngayHoc.Size = new System.Drawing.Size(185, 22);
            this.mask_ngayHoc.TabIndex = 8;
            // 
            // mask_maMh
            // 
            this.mask_maMh.Location = new System.Drawing.Point(215, 104);
            this.mask_maMh.Name = "mask_maMh";
            this.mask_maMh.Size = new System.Drawing.Size(185, 22);
            this.mask_maMh.TabIndex = 8;
            // 
            // mask_maSv
            // 
            this.mask_maSv.Location = new System.Drawing.Point(215, 45);
            this.mask_maSv.Name = "mask_maSv";
            this.mask_maSv.Size = new System.Drawing.Size(185, 22);
            this.mask_maSv.TabIndex = 8;
            // 
            // QLCTDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 450);
            this.Controls.Add(this.btn_xoaCTDiem);
            this.Controls.Add(this.btn_suaCTDiem);
            this.Controls.Add(this.btn_themCTDiem);
            this.Controls.Add(this.dataGridCTDiem);
            this.Controls.Add(this.mask_diemCK);
            this.Controls.Add(this.mask_diemGK);
            this.Controls.Add(this.mask_maSv);
            this.Controls.Add(this.mask_maMh);
            this.Controls.Add(this.mask_ngayHoc);
            this.Controls.Add(this.mask_diemCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLCTDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "QLCTDiem";
            this.Load += new System.EventHandler(this.QLDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCTDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridCTDiem;
        private System.Windows.Forms.Button btn_themCTDiem;
        private System.Windows.Forms.Button btn_suaCTDiem;
        private System.Windows.Forms.Button btn_xoaCTDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mask_diemCC;
        private System.Windows.Forms.MaskedTextBox mask_diemGK;
        private System.Windows.Forms.MaskedTextBox mask_diemCK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mask_ngayHoc;
        private System.Windows.Forms.MaskedTextBox mask_maMh;
        private System.Windows.Forms.MaskedTextBox mask_maSv;
    }
}