using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetShop
{
    public partial class Search_form : Form
    {
        public SqlConnection conn;
        public SqlCommand cmd;

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


        public Search_form()
        {
            InitializeComponent();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            //Tìm theo mã
            if(comboBox_ChonLoaiTK.Text == "Mã Nhân Viên")
            {
                int Ma = int.Parse(textBox_Search.Text);
                string query_nhan_vien = "select * from nhanvien where nv_ma = '" + Ma+"'";
                //show_Datagrid(query_nhan_vien, dataGridView_Search);
                //MessageBox.Show("Tìm nhân viên thành công!");

                connect();
                SqlCommand cmd = new SqlCommand(query_nhan_vien, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                        show_Datagrid(query_nhan_vien, dataGridView_Search);
                       // MessageBox.Show("Tìm nhân viên thành công!");
                }
                else MessageBox.Show("Không tìm thấy nhân viên!");
            }

            else if (comboBox_ChonLoaiTK.Text == "Tên Nhân Viên")
            {
                string Ten = textBox_Search.Text;
                string query_nhan_vien = "select * from nhanvien where nv_ten like  '%" + Ten + "%'";
                //show_Datagrid(query_nhan_vien, dataGridView_Search);
                //MessageBox.Show("Tìm nhân viên thành công!");

                connect();
                SqlCommand cmd = new SqlCommand(query_nhan_vien, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    show_Datagrid(query_nhan_vien, dataGridView_Search);
                   // MessageBox.Show("Tìm nhân viên thành công!");
                }
                else MessageBox.Show("Không tìm thấy nhân viên!");
            }

                    else if (comboBox_ChonLoaiTK.Text == "Số Điện Thoại")
                {
                    string SDT = textBox_Search.Text;
                    string query_nhan_vien = "select * from nhanvien where nv_sdt like '%" + SDT + "%'";
                    //show_Datagrid(query_nhan_vien, dataGridView_Search);
                    //MessageBox.Show("Tìm nhân viên thành công!");

                    connect();
                    SqlCommand cmd = new SqlCommand(query_nhan_vien, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null)
                    {
                        show_Datagrid(query_nhan_vien, dataGridView_Search);
                       // MessageBox.Show("Tìm nhân viên thành công!");
                    }
                    else MessageBox.Show("Không tìm thấy nhân viên!");
                }
                        else if (comboBox_ChonLoaiTK.Text == "Loại Tài Khoản")
                        {
                            int ID_type = int.Parse(textBox_Search.Text);
                            string query_nhan_vien = "select * from nhanvien where id_type = '" + ID_type + "'";
                            //show_Datagrid(query_nhan_vien, dataGridView_Search);
                            //MessageBox.Show("Tìm nhân viên thành công!");

                            connect();
                            SqlCommand cmd = new SqlCommand(query_nhan_vien, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt != null)
                            {
                                show_Datagrid(query_nhan_vien, dataGridView_Search);
                               // MessageBox.Show("Tìm nhân viên thành công!");
                            }
                            else MessageBox.Show("Không tìm thấy nhân viên!");
                        }
                            else MessageBox.Show("Chưa chọn loại tìm kiếm!");
        }

        private void Search_form_Load(object sender, EventArgs e)
        {
            connect();
            string query_NHAN_VIEN = "SELECT * FROM nhanvien";
            show_Datagrid(query_NHAN_VIEN, dataGridView_Search);
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Nút trở về
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLNV Form_QLNV = new QLNV();
            Form_QLNV.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_form login_fr = new Login_form();
            login_fr.Show();
        }

        private void comboBox_ChonLoaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
