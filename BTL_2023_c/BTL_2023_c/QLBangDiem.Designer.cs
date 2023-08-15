namespace BTL_2023_c
{
    partial class QLBangDiem
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
            this.btn_xoaBangDiem = new System.Windows.Forms.Button();
            this.btn_suaBangDiem = new System.Windows.Forms.Button();
            this.btn_themBangDiem = new System.Windows.Forms.Button();
            this.dataGridBangDiem = new System.Windows.Forms.DataGridView();
            this.mask_diemCK = new System.Windows.Forms.MaskedTextBox();
            this.mask_diemGK = new System.Windows.Forms.MaskedTextBox();
            this.mask_diemCC = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mask_maSv = new System.Windows.Forms.MaskedTextBox();
            this.mask_maMH = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mask_ngayHoc = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xoaBangDiem
            // 
            this.btn_xoaBangDiem.Location = new System.Drawing.Point(840, 386);
            this.btn_xoaBangDiem.Name = "btn_xoaBangDiem";
            this.btn_xoaBangDiem.Size = new System.Drawing.Size(79, 30);
            this.btn_xoaBangDiem.TabIndex = 29;
            this.btn_xoaBangDiem.Text = "Xóa";
            this.btn_xoaBangDiem.UseVisualStyleBackColor = true;
            this.btn_xoaBangDiem.Click += new System.EventHandler(this.btn_xoaBangDiem_Click);
            // 
            // btn_suaBangDiem
            // 
            this.btn_suaBangDiem.Location = new System.Drawing.Point(508, 386);
            this.btn_suaBangDiem.Name = "btn_suaBangDiem";
            this.btn_suaBangDiem.Size = new System.Drawing.Size(79, 30);
            this.btn_suaBangDiem.TabIndex = 28;
            this.btn_suaBangDiem.Text = "Sửa";
            this.btn_suaBangDiem.UseVisualStyleBackColor = true;
            this.btn_suaBangDiem.Click += new System.EventHandler(this.btn_suaBangDiem_Click);
            // 
            // btn_themBangDiem
            // 
            this.btn_themBangDiem.Location = new System.Drawing.Point(175, 386);
            this.btn_themBangDiem.Name = "btn_themBangDiem";
            this.btn_themBangDiem.Size = new System.Drawing.Size(79, 30);
            this.btn_themBangDiem.TabIndex = 27;
            this.btn_themBangDiem.Text = "Thêm";
            this.btn_themBangDiem.UseVisualStyleBackColor = true;
            this.btn_themBangDiem.Click += new System.EventHandler(this.btn_themBangDiem_Click);
            // 
            // dataGridBangDiem
            // 
            this.dataGridBangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBangDiem.Location = new System.Drawing.Point(473, 35);
            this.dataGridBangDiem.Name = "dataGridBangDiem";
            this.dataGridBangDiem.RowHeadersWidth = 51;
            this.dataGridBangDiem.RowTemplate.Height = 24;
            this.dataGridBangDiem.Size = new System.Drawing.Size(810, 274);
            this.dataGridBangDiem.TabIndex = 26;
            this.dataGridBangDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBangDiem_CellClick);
            // 
            // mask_diemCK
            // 
            this.mask_diemCK.Location = new System.Drawing.Point(202, 285);
            this.mask_diemCK.Name = "mask_diemCK";
            this.mask_diemCK.Size = new System.Drawing.Size(185, 22);
            this.mask_diemCK.TabIndex = 25;
            // 
            // mask_diemGK
            // 
            this.mask_diemGK.Location = new System.Drawing.Point(202, 233);
            this.mask_diemGK.Name = "mask_diemGK";
            this.mask_diemGK.Size = new System.Drawing.Size(185, 22);
            this.mask_diemGK.TabIndex = 24;
            // 
            // mask_diemCC
            // 
            this.mask_diemCC.Location = new System.Drawing.Point(202, 175);
            this.mask_diemCC.Name = "mask_diemCC";
            this.mask_diemCC.Size = new System.Drawing.Size(185, 22);
            this.mask_diemCC.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Điểm cuối kì";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Điểm giữa kì";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Điểm chuyên cần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã sinh viên";
            // 
            // mask_maSv
            // 
            this.mask_maSv.Location = new System.Drawing.Point(201, 29);
            this.mask_maSv.Name = "mask_maSv";
            this.mask_maSv.Size = new System.Drawing.Size(185, 22);
            this.mask_maSv.TabIndex = 23;
            // 
            // mask_maMH
            // 
            this.mask_maMH.Location = new System.Drawing.Point(201, 90);
            this.mask_maMH.Name = "mask_maMH";
            this.mask_maMH.Size = new System.Drawing.Size(185, 22);
            this.mask_maMH.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ngày học";
            // 
            // mask_ngayHoc
            // 
            this.mask_ngayHoc.Location = new System.Drawing.Point(203, 134);
            this.mask_ngayHoc.Name = "mask_ngayHoc";
            this.mask_ngayHoc.Size = new System.Drawing.Size(183, 22);
            this.mask_ngayHoc.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1046, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 30);
            this.button1.TabIndex = 30;
            this.button1.Text = "In ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QLBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_xoaBangDiem);
            this.Controls.Add(this.btn_suaBangDiem);
            this.Controls.Add(this.btn_themBangDiem);
            this.Controls.Add(this.dataGridBangDiem);
            this.Controls.Add(this.mask_diemCK);
            this.Controls.Add(this.mask_diemGK);
            this.Controls.Add(this.mask_maMH);
            this.Controls.Add(this.mask_maSv);
            this.Controls.Add(this.mask_ngayHoc);
            this.Controls.Add(this.mask_diemCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLBangDiem";
            this.Text = "QLBangDiem";
            this.Load += new System.EventHandler(this.QLBangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBangDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_xoaBangDiem;
        private System.Windows.Forms.Button btn_suaBangDiem;
        private System.Windows.Forms.Button btn_themBangDiem;
        private System.Windows.Forms.DataGridView dataGridBangDiem;
        private System.Windows.Forms.MaskedTextBox mask_diemCK;
        private System.Windows.Forms.MaskedTextBox mask_diemGK;
        private System.Windows.Forms.MaskedTextBox mask_diemCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mask_maSv;
        private System.Windows.Forms.MaskedTextBox mask_maMH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mask_ngayHoc;
        private System.Windows.Forms.Button button1;
    }
}