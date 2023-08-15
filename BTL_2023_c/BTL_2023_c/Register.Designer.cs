
namespace BTL_2023_c
{
    partial class Register
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
            this.btn_Dk = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.tb_mk = new System.Windows.Forms.TextBox();
            this.tb_TK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NhapLai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Dk
            // 
            this.btn_Dk.Location = new System.Drawing.Point(199, 295);
            this.btn_Dk.Name = "btn_Dk";
            this.btn_Dk.Size = new System.Drawing.Size(168, 32);
            this.btn_Dk.TabIndex = 17;
            this.btn_Dk.Text = "Đăng ký";
            this.btn_Dk.UseVisualStyleBackColor = true;
            this.btn_Dk.Click += new System.EventHandler(this.btn_Dk_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(413, 295);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(168, 32);
            this.btn_Back.TabIndex = 18;
            this.btn_Back.Text = "Trở lại";
            this.btn_Back.UseVisualStyleBackColor = true;
            // 
            // tb_mk
            // 
            this.tb_mk.Location = new System.Drawing.Point(336, 125);
            this.tb_mk.Name = "tb_mk";
            this.tb_mk.Size = new System.Drawing.Size(226, 22);
            this.tb_mk.TabIndex = 14;
            // 
            // tb_TK
            // 
            this.tb_TK.Location = new System.Drawing.Point(336, 66);
            this.tb_TK.Name = "tb_TK";
            this.tb_TK.Size = new System.Drawing.Size(226, 22);
            this.tb_TK.TabIndex = 13;
            this.tb_TK.TextChanged += new System.EventHandler(this.tb_TK_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên đăng nhập";
            // 
            // tb_NhapLai
            // 
            this.tb_NhapLai.Location = new System.Drawing.Point(336, 186);
            this.tb_NhapLai.Name = "tb_NhapLai";
            this.tb_NhapLai.Size = new System.Drawing.Size(226, 22);
            this.tb_NhapLai.TabIndex = 15;
            this.tb_NhapLai.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Chức vụ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Giảng viên",
            "Sinh viên"});
            this.comboBox1.Location = new System.Drawing.Point(336, 236);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_NhapLai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Dk);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.tb_mk);
            this.Controls.Add(this.tb_TK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Dk;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox tb_mk;
        private System.Windows.Forms.TextBox tb_TK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NhapLai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}