using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PetShop
{
    public partial class QLNV : Form
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public string file;
        //tao ham ket noi
        public void connect()
        {
            string chuoikn = "Server=DESKTOP-P7FD0VQ; database = xekhach; integrated security = true";
            conn = new SqlConnection(chuoikn);
            conn.Open();
        }

        //ham hien thi len datagrid
        public void show_Datagrid(string query, DataGridView dtgrid)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "DSNV");
            dtgrid.DataSource = ds;
            dtgrid.DataMember = "DSNV";
        }
        public QLNV()
        {
            InitializeComponent();
        }

        //Thoát chương trình
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            connect();
            string query_NHAN_VIEN = "SELECT * FROM nhanvien";
            show_Datagrid(query_NHAN_VIEN, dataGridView_NV);
        }

        //Hàm hiển thị từ datagridview lên textbox
        private void dataGridView_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaNV.ReadOnly = true;
            textBox_MaNV.Text = dataGridView_NV.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox_hoten.Text = dataGridView_NV.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker_NS.Text = dataGridView_NV.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_SDT.Text = dataGridView_NV.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox_DC.Text = dataGridView_NV.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox_email.Text = dataGridView_NV.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox_MK.Text = dataGridView_NV.Rows[e.RowIndex].Cells[7].Value.ToString();
            //textBox_cmnd.Text = dataGridView_NV.Rows[e.RowIndex].Cells[8].Value.ToString();
            if (dataGridView_NV.Rows[e.RowIndex].Cells[5].Value.ToString() == "Nam")
            {
                radioButton_Nam.Checked = true;
            }
            else radioButton_Nu.Checked = true;

            if (dataGridView_NV.Rows[e.RowIndex].Cells[9].Value.ToString() == "1")
            {
                checkBox_QTV.Checked = true;
                }
            else
                checkBox_QTV.Checked = false;
            txb_Path.Text = dataGridView_NV.Rows[e.RowIndex].Cells[8].Value.ToString();
            string path = dataGridView_NV.Rows[e.RowIndex].Cells[8].Value.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(path);
            }
            catch (FileNotFoundException)
            {
                // Handle the exception by displaying a default image or showing an error message
                //pictureBox1.Image = Properties.Resources.DefaultImage;
              //  pictureBox1.Image = Properties.Resources.chi08;
                MessageBox.Show("Anh khong duoc tim thay.", "Lõi rồi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //Nút đặt lại
        private void button7_Click(object sender, EventArgs e)
        {
            textBox_MaNV.Text = "";
            textBox_hoten.Text = "";
            dateTimePicker_NS.Text = "";
            textBox_SDT.Text = "";
            textBox_DC.Text = "";
            textBox_email.Text = "";
            textBox_MK.Text = "";
            //textBox_cmnd.Text = "";
            radioButton_Nam.Checked = false;
            radioButton_Nu.Checked = false;

        }

        private void textBox_SDT_TextChanged(object sender, EventArgs e)
        {

        }
        public void showImage(PictureBox PictureBox1, string path)
        {
            string file = "";
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Choose Image(*.jpg;*.jpeg;*.tif;*.jfif)|*.jpg;*.jpeg;*.tif;*.jfif";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(op.FileName);
                file = op.FileName;
                txb_Path.Text = file;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showImage(pictureBox1, txb_Path.Text);
        }

        //Nút xóa ảnh
        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        //Nút thêm nhân viên mới
        private void button2_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            string gender;
            gender = "";
            if (radioButton_Nam.Checked == true)
            {
                gender = "Nam";
            }
            else if (radioButton_Nu.Checked == true)
            { gender = "Nu"; }

            int La_QTV = 0;
            if (checkBox_QTV.Checked == true)
            {
                La_QTV = 1;
            }
            else 
            { La_QTV = 0;
            }

            cmd.CommandText = "INSERT INTO nhanvien (nv_ten, nv_ngaysinh,nv_gioitinh , nv_diachi,nv_sdt, nv_email, nv_password, nv_picture,id_type )  values ('" + textBox_hoten.Text + "', '" + DateTime.Parse(dateTimePicker_NS.Text) + "','"+gender+ "','" + textBox_DC.Text + "','" + textBox_SDT.Text + "', '"+textBox_email.Text+"', '"+textBox_MK.Text+ "','"+txb_Path.Text+"','" + La_QTV + "' )";
            cmd.ExecuteNonQuery();

            string query_NHAN_VIEN = "SELECT * FROM nhanvien";
            show_Datagrid(query_NHAN_VIEN, dataGridView_NV);
            MessageBox.Show("Thêm nhân viên thành công!");


        }

        //Nut sua thong tin nhan vien
        private void button3_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();

            string gender;
            gender = "";
            if (radioButton_Nam.Checked == true)
            {
                gender = "Nam";
            }
            else if (radioButton_Nu.Checked == true)
            { gender = "Nu"; }

            int La_QTV = 0;
            if (checkBox_QTV.Checked == true)
            {
                La_QTV = 1;
            }
            else
            {
                La_QTV = 0;
            }

            cmd.CommandText = "UPDATE nhanvien set nv_ten='" + textBox_hoten.Text + "', nv_ngaysinh = '"+ DateTime.Parse(dateTimePicker_NS.Text) + "', nv_gioitinh = '"+gender+ "', nv_diachi = '" + textBox_DC.Text + "', nv_sdt = '" + textBox_SDT.Text + "', nv_email = '"+ textBox_email.Text + "', nv_password = '"+ textBox_MK.Text+ "',nv_picture='"+txb_Path.Text+"', ID_Type = '"+La_QTV+"' where nv_ma = '" + textBox_MaNV.Text+"'";
            cmd.ExecuteNonQuery();
            string query_NHAN_VIEN = "select * from nhanvien";
            show_Datagrid(query_NHAN_VIEN, dataGridView_NV);
            MessageBox.Show("Sửa nhân viên thành công!");

        }

        //Nút xóa nhân viên
        private void button4_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM nhanvien where nv_ma = '" + textBox_MaNV.Text+"'";
            cmd.ExecuteNonQuery();
            string query_NHAN_VIEN = "select * from nhanvien";
            show_Datagrid(query_NHAN_VIEN, dataGridView_NV);
            MessageBox.Show("Xóa nhân viên thành công!");            
        }

        private void btn_back_QTV_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main_QTV main_QTV = new Form_Main_QTV();
            main_QTV.Show();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_form login_fr = new Login_form();
            login_fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_form sf = new Search_form();
            sf.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }
