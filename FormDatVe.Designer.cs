namespace BVXE
{
    partial class FormDatVe
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
            this.dtgv1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgiodi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgioden = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsove = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmakhach = new System.Windows.Forms.ComboBox();
            this.cbmat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbanggia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsoghe = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntrove = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.txtmachuyen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbmax11 = new System.Windows.Forms.Label();
            this.cbmanv = new System.Windows.Forms.ComboBox();
            this.cbmatx = new System.Windows.Forms.ComboBox();
            this.cbmax = new System.Windows.Forms.ComboBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btntk = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv1
            // 
            this.dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv1.Location = new System.Drawing.Point(46, 329);
            this.dtgv1.Name = "dtgv1";
            this.dtgv1.RowHeadersWidth = 51;
            this.dtgv1.RowTemplate.Height = 24;
            this.dtgv1.Size = new System.Drawing.Size(740, 227);
            this.dtgv1.TabIndex = 0;
            this.dtgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã tuyến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giờ đi:";
            // 
            // txtgiodi
            // 
            this.txtgiodi.Location = new System.Drawing.Point(212, 164);
            this.txtgiodi.Name = "txtgiodi";
            this.txtgiodi.Size = new System.Drawing.Size(206, 22);
            this.txtgiodi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giờ đến:";
            // 
            // txtgioden
            // 
            this.txtgioden.Location = new System.Drawing.Point(212, 204);
            this.txtgioden.Name = "txtgioden";
            this.txtgioden.Size = new System.Drawing.Size(206, 22);
            this.txtgioden.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số vé:";
            // 
            // txtsove
            // 
            this.txtsove.Location = new System.Drawing.Point(212, 239);
            this.txtsove.Name = "txtsove";
            this.txtsove.Size = new System.Drawing.Size(206, 22);
            this.txtsove.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khách hàng:";
            // 
            // cbmakhach
            // 
            this.cbmakhach.FormattingEnabled = true;
            this.cbmakhach.Location = new System.Drawing.Point(697, 87);
            this.cbmakhach.Name = "cbmakhach";
            this.cbmakhach.Size = new System.Drawing.Size(121, 24);
            this.cbmakhach.TabIndex = 3;
            // 
            // cbmat
            // 
            this.cbmat.FormattingEnabled = true;
            this.cbmat.Location = new System.Drawing.Point(697, 234);
            this.cbmat.Name = "cbmat";
            this.cbmat.Size = new System.Drawing.Size(121, 24);
            this.cbmat.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bảng giá:";
            // 
            // txtbanggia
            // 
            this.txtbanggia.Location = new System.Drawing.Point(212, 281);
            this.txtbanggia.Name = "txtbanggia";
            this.txtbanggia.Size = new System.Drawing.Size(206, 22);
            this.txtbanggia.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số ghế:";
            // 
            // txtsoghe
            // 
            this.txtsoghe.Location = new System.Drawing.Point(212, 126);
            this.txtsoghe.Name = "txtsoghe";
            this.txtsoghe.Size = new System.Drawing.Size(206, 22);
            this.txtsoghe.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntk);
            this.groupBox1.Controls.Add(this.btntrove);
            this.groupBox1.Controls.Add(this.btnprint);
            this.groupBox1.Controls.Add(this.btncapnhat);
            this.groupBox1.Location = new System.Drawing.Point(818, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 227);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btntrove
            // 
            this.btntrove.Location = new System.Drawing.Point(53, 168);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(87, 38);
            this.btntrove.TabIndex = 3;
            this.btntrove.Text = "Trở về";
            this.btntrove.UseVisualStyleBackColor = true;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(53, 77);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(87, 44);
            this.btnprint.TabIndex = 2;
            this.btnprint.Text = "In hóa đơn";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(53, 30);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(87, 41);
            this.btncapnhat.TabIndex = 1;
            this.btncapnhat.Text = "Đặt vé";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // txtmachuyen
            // 
            this.txtmachuyen.Location = new System.Drawing.Point(212, 87);
            this.txtmachuyen.Name = "txtmachuyen";
            this.txtmachuyen.Size = new System.Drawing.Size(206, 22);
            this.txtmachuyen.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mã chuyến:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(552, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mã nhân viên:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(552, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mã tài xế:";
            // 
            // cbmax11
            // 
            this.cbmax11.AutoSize = true;
            this.cbmax11.Location = new System.Drawing.Point(552, 204);
            this.cbmax11.Name = "cbmax11";
            this.cbmax11.Size = new System.Drawing.Size(46, 16);
            this.cbmax11.TabIndex = 10;
            this.cbmax11.Text = "Mã xe:";
            // 
            // cbmanv
            // 
            this.cbmanv.FormattingEnabled = true;
            this.cbmanv.Location = new System.Drawing.Point(697, 127);
            this.cbmanv.Name = "cbmanv";
            this.cbmanv.Size = new System.Drawing.Size(121, 24);
            this.cbmanv.TabIndex = 11;
            // 
            // cbmatx
            // 
            this.cbmatx.FormattingEnabled = true;
            this.cbmatx.Location = new System.Drawing.Point(697, 162);
            this.cbmatx.Name = "cbmatx";
            this.cbmatx.Size = new System.Drawing.Size(121, 24);
            this.cbmatx.TabIndex = 12;
            // 
            // cbmax
            // 
            this.cbmax.FormattingEnabled = true;
            this.cbmax.Location = new System.Drawing.Point(697, 196);
            this.cbmax.Name = "cbmax";
            this.cbmax.Size = new System.Drawing.Size(121, 24);
            this.cbmax.TabIndex = 13;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(53, 127);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(87, 35);
            this.btntk.TabIndex = 4;
            this.btntk.Text = "Thống kê";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(442, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 32);
            this.label11.TabIndex = 14;
            this.label11.Text = "ĐẶT VÉ";
            // 
            // FormDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 598);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbmax);
            this.Controls.Add(this.cbmatx);
            this.Controls.Add(this.cbmanv);
            this.Controls.Add(this.cbmax11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmachuyen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtsoghe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbmat);
            this.Controls.Add(this.cbmakhach);
            this.Controls.Add(this.txtbanggia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtgioden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtgiodi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv1);
            this.Name = "FormDatVe";
            this.Text = "FormDatVe";
            this.Load += new System.EventHandler(this.FormDatVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgiodi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtgioden;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmakhach;
        private System.Windows.Forms.ComboBox cbmat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbanggia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsoghe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.TextBox txtmachuyen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label cbmax11;
        private System.Windows.Forms.ComboBox cbmanv;
        private System.Windows.Forms.ComboBox cbmatx;
        private System.Windows.Forms.ComboBox cbmax;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.Label label11;
    }
}