using PetShop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BVXE
{
    public partial class TaoChuyenXecs : Form
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
        public TaoChuyenXecs()
        {
            InitializeComponent();
        }
        public void show_Datagrid(string query, DataGridView dtgrid)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "DSNV");
            dtgrid.DataSource = ds;
            dtgrid.DataMember = "DSNV";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO cx_chuyenxe (cx_soghe, cx_giodi, cx_gioden, cx_gia, kh_ma, nv_ma, tx_ma, x_ma, t_ma)  values ('" +txtsoghe.Text + "','" + txtgiodi.Text + "','" + txtgioden.Text + "','" + txtbanggia.Text + "', '" + cbmakhach.SelectedValue.ToString() + "', '" + cbmanv.SelectedValue.ToString()+ "','" + cbmatx.SelectedValue.ToString() + "', '"+cbmax.SelectedValue.ToString()+"', '"+cbmat.SelectedValue.ToString()+"' )";
            cmd.ExecuteNonQuery();

            string query_NHAN_VIEN = "SELECT * FROM cx_chuyenxe";
            show_Datagrid(query_NHAN_VIEN, dtgv);
          //  Function h = new Function();
           // h.hienthi();
            MessageBox.Show("Thêm chuyến xe thành công!");
        }

        private void TaoChuyenXecs_Load(object sender, EventArgs e)
        {
            connect();
            Function h = new Function();
            h.loadcbKH("select kh_ma, kh_ten from khachhang", cbmakhach, "kh_ten", "kh_ma", conn);
            h.loadcbNV("select nv_ma, nv_ten from nhanvien", cbmanv, "nv_ten", "nv_ma", conn);
            h.loadcbTX("select tx_ma, tx_ten from taixe", cbmatx, "tx_ten", "tx_ma", conn);
            h.loadcbNV("select * from xe", cbmax, "x_ten", "x_ma", conn);
            h.loadcbNV("select * from tuyen", cbmat, "t_ten", "t_ma", conn);
            // h.hienthi("select cx_ma,cx_soghe, cx_giodi, cx_gioden, cx_banggia from cx_chuyenxe", dtgv);
            string query_NHAN_VIEN = "select cx_ma, cx_soghe, cx_giodi,cx_gioden,cx_gia, t_ma from cx_chuyenxe";
            show_Datagrid(query_NHAN_VIEN, dtgv);
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmachuyen.Text = dtgv.Rows[e.RowIndex].Cells[0].Value.ToString();
          //  txtten.Text = dtgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsoghe.Text = dtgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtgiodi.Text = dtgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtgioden.Text = dtgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtbanggia.Text = dtgv.Rows[e.RowIndex].Cells[4].Value.ToString();

       /*     cbmakhach.Text = dtgv.Rows[e.RowIndex].Cells[6].Value.ToString();
           cbmanv.Text = dtgv.Rows[e.RowIndex].Cells[7].Value.ToString();
            cbmatx.Text = dtgv.Rows[e.RowIndex].Cells[8].Value.ToString();
            cbmax.Text = dtgv.Rows[e.RowIndex].Cells[9].Value.ToString();
            cbmat.Text = dtgv.Rows[e.RowIndex].Cells[10].Value.ToString();*/
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE cx_chuyenxe set cx_soghe = '" + txtsoghe.Text + "', cx_giodi = '" + txtgiodi.Text + "', cx_gioden = '" + txtgioden.Text + "', cx_gia = '" + txtbanggia.Text + "', kh_ma = '" + cbmakhach.SelectedValue.ToString() + "', nv_ma = '" + cbmanv.SelectedValue.ToString() + "', tx_ma = '" + cbmatx.SelectedValue.ToString() + "',x_ma= '"+cbmax.SelectedValue.ToString()+"', t_ma= '"+cbmat.SelectedValue.ToString()+"' where cx_ma = '" + txtmachuyen.Text + "'";
            cmd.ExecuteNonQuery();
            string query_NHAN_VIEN = "select * from cx_chuyenxe";
            show_Datagrid(query_NHAN_VIEN, dtgv);
            MessageBox.Show("Sửa chuyến xe thành công!");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM cx_chuyenxe where cx_ma = '" + txtmachuyen.Text + "'";
            cmd.ExecuteNonQuery();
            string query_NHAN_VIEN = "select * from cx_chuyenxe";
            show_Datagrid(query_NHAN_VIEN, dtgv);
            MessageBox.Show("Xóa chuyến xe thành công!");
        }

        private void btndl_Click(object sender, EventArgs e)
        {
            txtmachuyen.Text = " ";
            //txtten.Text = "";
            txtsoghe.Text = "";
            txtgiodi.Text = "";
            txtgioden.Text = "";
            txtbanggia.Text = "";
            
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main_QTV main_QTV = new Form_Main_QTV();
            main_QTV.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
