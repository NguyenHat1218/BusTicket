using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetShop
{
    public partial class Login_form : Form
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public static string ID_USER = "";
        public int ID_Type = 99999;

        //tao ham ket noi
        public void connect()
        {
            string chuoikn = "Server=DESKTOP-P7FD0VQ; database = xekhach; integrated security = true";
            conn = new SqlConnection(chuoikn);
            conn.Open();
        }
        public Login_form()
        {
            InitializeComponent();
        }

        //Hàm lấy id người dùng
        private string getID(string username, string pass)
        {
            string id = "";
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("SELECT * FROM nhanvien WHERE nv_ten ='" + username + "' and nv_password='" +pass+ "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["nv_ma"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        private int getID_Type(string username, string pass)
        {
            int id_Type = 99999;
            try
            {
                connect();
                SqlCommand cmd = new SqlCommand("SELECT ID_Type FROM nhanvien WHERE nv_ten ='" + username + "' and nv_password='" + pass + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id_Type = int.Parse(dr["id_Type"].ToString());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                conn.Close();
            }
            return id_Type;
        }

        //Click đăng nhập thì xử lý id và id_type để phân quyền truy cập
        private void submit_login_btn_Click(object sender, EventArgs e)
        {
            ID_USER = getID(username_textbox.Text, pwd_textbox.Text);
            ID_Type = getID_Type(username_textbox.Text, pwd_textbox.Text);
            if (username_textbox.Text == "" || pwd_textbox.Text == "")
            {
                MessageBox.Show("Username và Mật khẩu không được rỗng!");
                username_textbox.Focus();
            }

           /* if (username_textbox.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại chỉ được dài 10 kí tự");
                pwd_textbox.Text = "";
                pwd_textbox.Focus();
            }*/

            if (ID_USER != "" && ID_Type == 1)
            {
                QLNV Form_QLNV = new QLNV();
                Form_QLNV.Show();
                this.Hide();
                MessageBox.Show("Đăng nhập thành công với tư cách Quản trị viên");
            }

            else if (ID_USER != "" && ID_Type == 0)
            {
                Form_Main_QTV Form_Home = new Form_Main_QTV();
                Form_Home.Show();
                this.Hide();
                MessageBox.Show("Đăng nhập thành công với tư cách Nhân viên");
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng!");
                username_textbox.Text = "";
                pwd_textbox.Text = "";
                username_textbox.Focus();
            }
            //QLNV Form_QLNV = new QLNV();
            //Form_QLNV.Show();
            //this.Hide();
            //MessageBox.Show("Đăng nhập thành công với tư cách Nhân viên");

        }

        private void Login_form_Load(object sender, EventArgs e)
        {
            connect();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Ẩn hoặc hiện mật khẩu
        private void checkBox_HTMatKhau_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_HTMatKhau.Checked)
            {
                pwd_textbox.PasswordChar = (char)0;
            }
            else
            {
                pwd_textbox.PasswordChar = '*';
            }
            if (checkBox_HTMatKhau.Checked)
            {
                pwd_textbox.PasswordChar = (char)0;
            }
            else
            {
                pwd_textbox.PasswordChar = '*';
            }
        }

       
    }

    
}

