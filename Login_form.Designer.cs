namespace PetShop
{
    partial class Login_form
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
            this.panel_Top = new System.Windows.Forms.Panel();
            this.PetShop_name = new System.Windows.Forms.Label();
            this.groupBox_Login = new System.Windows.Forms.GroupBox();
            this.checkBox_HTMatKhau = new System.Windows.Forms.CheckBox();
            this.submit_login_btn = new System.Windows.Forms.Button();
            this.pwd_textbox = new System.Windows.Forms.TextBox();
            this.pwd_label = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.Login_name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_Top.SuspendLayout();
            this.groupBox_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Top.BackColor = System.Drawing.SystemColors.Info;
            this.panel_Top.Controls.Add(this.PetShop_name);
            this.panel_Top.Location = new System.Drawing.Point(2, 3);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(641, 98);
            this.panel_Top.TabIndex = 1;
            // 
            // PetShop_name
            // 
            this.PetShop_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PetShop_name.AutoSize = true;
            this.PetShop_name.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetShop_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PetShop_name.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PetShop_name.Location = new System.Drawing.Point(112, 31);
            this.PetShop_name.Name = "PetShop_name";
            this.PetShop_name.Size = new System.Drawing.Size(426, 38);
            this.PetShop_name.TabIndex = 0;
            this.PetShop_name.Text = "QUẢN LÝ VÉ XE KHÁCH";
            this.PetShop_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Login
            // 
            this.groupBox_Login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox_Login.BackColor = System.Drawing.Color.MintCream;
            this.groupBox_Login.Controls.Add(this.checkBox_HTMatKhau);
            this.groupBox_Login.Controls.Add(this.submit_login_btn);
            this.groupBox_Login.Controls.Add(this.pwd_textbox);
            this.groupBox_Login.Controls.Add(this.pwd_label);
            this.groupBox_Login.Controls.Add(this.username_textbox);
            this.groupBox_Login.Controls.Add(this.username_label);
            this.groupBox_Login.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Login.Location = new System.Drawing.Point(64, 191);
            this.groupBox_Login.Name = "groupBox_Login";
            this.groupBox_Login.Size = new System.Drawing.Size(506, 436);
            this.groupBox_Login.TabIndex = 10;
            this.groupBox_Login.TabStop = false;
            // 
            // checkBox_HTMatKhau
            // 
            this.checkBox_HTMatKhau.AutoSize = true;
            this.checkBox_HTMatKhau.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_HTMatKhau.Location = new System.Drawing.Point(167, 251);
            this.checkBox_HTMatKhau.Name = "checkBox_HTMatKhau";
            this.checkBox_HTMatKhau.Size = new System.Drawing.Size(181, 28);
            this.checkBox_HTMatKhau.TabIndex = 7;
            this.checkBox_HTMatKhau.Text = "Hiển thị mật khẩu";
            this.checkBox_HTMatKhau.UseVisualStyleBackColor = true;
            this.checkBox_HTMatKhau.CheckedChanged += new System.EventHandler(this.checkBox_HTMatKhau_CheckedChanged_1);
            // 
            // submit_login_btn
            // 
            this.submit_login_btn.BackColor = System.Drawing.Color.Green;
            this.submit_login_btn.Font = new System.Drawing.Font("Candara", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_login_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.submit_login_btn.Location = new System.Drawing.Point(323, 333);
            this.submit_login_btn.Name = "submit_login_btn";
            this.submit_login_btn.Size = new System.Drawing.Size(107, 45);
            this.submit_login_btn.TabIndex = 6;
            this.submit_login_btn.Text = "SUBMIT";
            this.submit_login_btn.UseVisualStyleBackColor = false;
            this.submit_login_btn.Click += new System.EventHandler(this.submit_login_btn_Click);
            // 
            // pwd_textbox
            // 
            this.pwd_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pwd_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_textbox.Location = new System.Drawing.Point(167, 169);
            this.pwd_textbox.Name = "pwd_textbox";
            this.pwd_textbox.PasswordChar = '*';
            this.pwd_textbox.Size = new System.Drawing.Size(263, 34);
            this.pwd_textbox.TabIndex = 5;
            // 
            // pwd_label
            // 
            this.pwd_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pwd_label.AutoSize = true;
            this.pwd_label.Font = new System.Drawing.Font("Candara", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pwd_label.Location = new System.Drawing.Point(11, 164);
            this.pwd_label.Name = "pwd_label";
            this.pwd_label.Size = new System.Drawing.Size(127, 35);
            this.pwd_label.TabIndex = 4;
            this.pwd_label.Text = "Password";
            // 
            // username_textbox
            // 
            this.username_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.username_textbox.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.Location = new System.Drawing.Point(167, 76);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(263, 32);
            this.username_textbox.TabIndex = 3;
            // 
            // username_label
            // 
            this.username_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Candara", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.username_label.Location = new System.Drawing.Point(11, 76);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(132, 35);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "Username";
            // 
            // Login_name
            // 
            this.Login_name.AutoSize = true;
            this.Login_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_name.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Login_name.Location = new System.Drawing.Point(257, 120);
            this.Login_name.Name = "Login_name";
            this.Login_name.Size = new System.Drawing.Size(112, 36);
            this.Login_name.TabIndex = 11;
            this.Login_name.Text = "LOGIN";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(537, 686);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(642, 728);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Login_name);
            this.Controls.Add(this.groupBox_Login);
            this.Controls.Add(this.panel_Top);
            this.Name = "Login_form";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Login_form_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.groupBox_Login.ResumeLayout(false);
            this.groupBox_Login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label PetShop_name;
        private System.Windows.Forms.GroupBox groupBox_Login;
        private System.Windows.Forms.Button submit_login_btn;
        private System.Windows.Forms.TextBox pwd_textbox;
        private System.Windows.Forms.Label pwd_label;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label Login_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_HTMatKhau;
    }
}