
namespace BTL_2023_c
{
    partial class QLKhoa
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mask_maKhoa = new System.Windows.Forms.MaskedTextBox();
            this.mask_tenKhoa = new System.Windows.Forms.MaskedTextBox();
            this.mask_sdt = new System.Windows.Forms.MaskedTextBox();
            this.mask_diaChi = new System.Windows.Forms.MaskedTextBox();
            this.dtGridKhoa = new System.Windows.Forms.DataGridView();
            this.btn_themKhoa = new System.Windows.Forms.Button();
            this.btn_suaKhoa = new System.Windows.Forms.Button();
            this.btn_xoaKhoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // mask_maKhoa
            // 
            this.mask_maKhoa.Location = new System.Drawing.Point(213, 63);
            this.mask_maKhoa.Name = "mask_maKhoa";
            this.mask_maKhoa.Size = new System.Drawing.Size(147, 22);
            this.mask_maKhoa.TabIndex = 4;
            // 
            // mask_tenKhoa
            // 
            this.mask_tenKhoa.Location = new System.Drawing.Point(213, 137);
            this.mask_tenKhoa.Name = "mask_tenKhoa";
            this.mask_tenKhoa.Size = new System.Drawing.Size(147, 22);
            this.mask_tenKhoa.TabIndex = 5;
            // 
            // mask_sdt
            // 
            this.mask_sdt.Location = new System.Drawing.Point(213, 209);
            this.mask_sdt.Name = "mask_sdt";
            this.mask_sdt.Size = new System.Drawing.Size(147, 22);
            this.mask_sdt.TabIndex = 6;
            // 
            // mask_diaChi
            // 
            this.mask_diaChi.Location = new System.Drawing.Point(213, 278);
            this.mask_diaChi.Name = "mask_diaChi";
            this.mask_diaChi.Size = new System.Drawing.Size(147, 22);
            this.mask_diaChi.TabIndex = 7;
            // 
            // dtGridKhoa
            // 
            this.dtGridKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridKhoa.Location = new System.Drawing.Point(548, 63);
            this.dtGridKhoa.Name = "dtGridKhoa";
            this.dtGridKhoa.RowHeadersWidth = 51;
            this.dtGridKhoa.RowTemplate.Height = 24;
            this.dtGridKhoa.Size = new System.Drawing.Size(709, 199);
            this.dtGridKhoa.TabIndex = 8;
            this.dtGridKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridKhoa_CellClick);
            // 
            // btn_themKhoa
            // 
            this.btn_themKhoa.Location = new System.Drawing.Point(213, 375);
            this.btn_themKhoa.Name = "btn_themKhoa";
            this.btn_themKhoa.Size = new System.Drawing.Size(79, 30);
            this.btn_themKhoa.TabIndex = 10;
            this.btn_themKhoa.Text = "Thêm";
            this.btn_themKhoa.UseVisualStyleBackColor = true;
            this.btn_themKhoa.Click += new System.EventHandler(this.btn_themKhoa_Click);
            // 
            // btn_suaKhoa
            // 
            this.btn_suaKhoa.Location = new System.Drawing.Point(548, 375);
            this.btn_suaKhoa.Name = "btn_suaKhoa";
            this.btn_suaKhoa.Size = new System.Drawing.Size(79, 30);
            this.btn_suaKhoa.TabIndex = 11;
            this.btn_suaKhoa.Text = "Sửa";
            this.btn_suaKhoa.UseVisualStyleBackColor = true;
            this.btn_suaKhoa.Click += new System.EventHandler(this.btn_suaKhoa_Click);
            // 
            // btn_xoaKhoa
            // 
            this.btn_xoaKhoa.Location = new System.Drawing.Point(863, 375);
            this.btn_xoaKhoa.Name = "btn_xoaKhoa";
            this.btn_xoaKhoa.Size = new System.Drawing.Size(79, 30);
            this.btn_xoaKhoa.TabIndex = 12;
            this.btn_xoaKhoa.Text = "Xóa";
            this.btn_xoaKhoa.UseVisualStyleBackColor = true;
            this.btn_xoaKhoa.Click += new System.EventHandler(this.btn_xoaKhoa_Click);
            // 
            // QLKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 450);
            this.Controls.Add(this.btn_xoaKhoa);
            this.Controls.Add(this.btn_suaKhoa);
            this.Controls.Add(this.btn_themKhoa);
            this.Controls.Add(this.dtGridKhoa);
            this.Controls.Add(this.mask_diaChi);
            this.Controls.Add(this.mask_sdt);
            this.Controls.Add(this.mask_tenKhoa);
            this.Controls.Add(this.mask_maKhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLKhoa";
            this.Text = "QLKhoa";
            this.Load += new System.EventHandler(this.QLKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mask_maKhoa;
        private System.Windows.Forms.MaskedTextBox mask_tenKhoa;
        private System.Windows.Forms.MaskedTextBox mask_sdt;
        private System.Windows.Forms.MaskedTextBox mask_diaChi;
        private System.Windows.Forms.DataGridView dtGridKhoa;
        private System.Windows.Forms.Button btn_themKhoa;
        private System.Windows.Forms.Button btn_suaKhoa;
        private System.Windows.Forms.Button btn_xoaKhoa;
    }
}