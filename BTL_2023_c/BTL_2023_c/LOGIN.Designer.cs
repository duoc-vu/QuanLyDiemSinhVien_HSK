
namespace BTL_2023_c
{
    partial class LOGIN
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
            this.btn_Dn = new System.Windows.Forms.Button();
            this.tb_mk = new System.Windows.Forms.TextBox();
            this.tb_TK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Dk
            // 
            this.btn_Dk.Location = new System.Drawing.Point(420, 190);
            this.btn_Dk.Name = "btn_Dk";
            this.btn_Dk.Size = new System.Drawing.Size(168, 32);
            this.btn_Dk.TabIndex = 10;
            this.btn_Dk.Text = "Đăng ký";
            this.btn_Dk.UseVisualStyleBackColor = true;
            this.btn_Dk.Click += new System.EventHandler(this.btn_Dk_Click);
            // 
            // btn_Dn
            // 
            this.btn_Dn.Location = new System.Drawing.Point(196, 190);
            this.btn_Dn.Name = "btn_Dn";
            this.btn_Dn.Size = new System.Drawing.Size(168, 32);
            this.btn_Dn.TabIndex = 9;
            this.btn_Dn.Text = "Đăng nhập";
            this.btn_Dn.UseVisualStyleBackColor = true;
            this.btn_Dn.Click += new System.EventHandler(this.btn_Dn_Click);
            // 
            // tb_mk
            // 
            this.tb_mk.Location = new System.Drawing.Point(313, 119);
            this.tb_mk.Name = "tb_mk";
            this.tb_mk.Size = new System.Drawing.Size(226, 22);
            this.tb_mk.TabIndex = 8;
            // 
            // tb_TK
            // 
            this.tb_TK.Location = new System.Drawing.Point(313, 55);
            this.tb_TK.Name = "tb_TK";
            this.tb_TK.Size = new System.Drawing.Size(226, 22);
            this.tb_TK.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên đăng nhập";
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Dk);
            this.Controls.Add(this.btn_Dn);
            this.Controls.Add(this.tb_mk);
            this.Controls.Add(this.tb_TK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Dk;
        private System.Windows.Forms.Button btn_Dn;
        private System.Windows.Forms.TextBox tb_mk;
        private System.Windows.Forms.TextBox tb_TK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}