namespace PetShop
{
    partial class Search_form
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
            this.button_Search = new System.Windows.Forms.Button();
            this.comboBox_ChonLoaiTK = new System.Windows.Forms.ComboBox();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.dataGridView_Search = new System.Windows.Forms.DataGridView();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Search)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.LightPink;
            this.button_Search.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Search.Location = new System.Drawing.Point(457, 214);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(79, 37);
            this.button_Search.TabIndex = 0;
            this.button_Search.Text = "Tìm";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // comboBox_ChonLoaiTK
            // 
            this.comboBox_ChonLoaiTK.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ChonLoaiTK.FormattingEnabled = true;
            this.comboBox_ChonLoaiTK.Items.AddRange(new object[] {
            "Mã Nhân Viên",
            "Tên Nhân Viên",
            "Số Điện Thoại",
            "Loại Tài Khoản"});
            this.comboBox_ChonLoaiTK.Location = new System.Drawing.Point(158, 147);
            this.comboBox_ChonLoaiTK.Name = "comboBox_ChonLoaiTK";
            this.comboBox_ChonLoaiTK.Size = new System.Drawing.Size(191, 32);
            this.comboBox_ChonLoaiTK.TabIndex = 1;
            this.comboBox_ChonLoaiTK.Text = "Tìm theo";
            this.comboBox_ChonLoaiTK.SelectedIndexChanged += new System.EventHandler(this.comboBox_ChonLoaiTK_SelectedIndexChanged);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("Cascadia Code", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.Location = new System.Drawing.Point(396, 151);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(283, 28);
            this.textBox_Search.TabIndex = 2;
            // 
            // dataGridView_Search
            // 
            this.dataGridView_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Search.Location = new System.Drawing.Point(33, 257);
            this.dataGridView_Search.Name = "dataGridView_Search";
            this.dataGridView_Search.RowHeadersWidth = 51;
            this.dataGridView_Search.RowTemplate.Height = 24;
            this.dataGridView_Search.Size = new System.Drawing.Size(739, 219);
            this.dataGridView_Search.TabIndex = 3;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Exit.Font = new System.Drawing.Font("Cascadia Code", 10.8F);
            this.button_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Exit.Location = new System.Drawing.Point(674, 503);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(98, 40);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "Thoát";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Cascadia Code", 10.8F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(33, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(244, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "TÌM KIẾM NHÂN VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.button_Logout);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 95);
            this.panel1.TabIndex = 8;
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.Color.Transparent;
            this.button_Logout.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.Location = new System.Drawing.Point(675, 10);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(138, 31);
            this.button_Logout.TabIndex = 20;
            this.button_Logout.Text = "Đăng xuất";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "XE KHÁCH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(824, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.dataGridView_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.comboBox_ChonLoaiTK);
            this.Controls.Add(this.button_Search);
            this.Name = "Search_form";
            this.Text = "Search_form";
            this.Load += new System.EventHandler(this.Search_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Search)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.ComboBox comboBox_ChonLoaiTK;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.DataGridView dataGridView_Search;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Logout;
    }
}