using PetShop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BVXE
{
    public partial class FormDatVe : Form
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
        public FormDatVe()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtmachuyen.Text = dtgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //  txtten.Text = dtgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsoghe.Text = dtgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtgiodi.Text = dtgv1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtgioden.Text = dtgv1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtsove.Text = dtgv1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtbanggia.Text = dtgv1.Rows[e.RowIndex].Cells[5].Value.ToString();



            // Lấy giá trị hiện tại của số ghế và số vé


            // Giảm số ghế và số vé khi đặt vé
            /*  if (currentSoGhe > 0 && currentSoVe > 0)
              {
                  currentSoGhe--;
                  currentSoVe--;
              }

              // Cập nhật lại giá trị của số ghế và số vé trong DataGridView
              dtgv1.Rows[e.RowIndex].Cells[0].Value = currentSoGhe.ToString();
              dtgv1.Rows[e.RowIndex].Cells[1].Value = currentSoVe.ToString();

              // Cập nhật lại giá trị trong các TextBox tương ứng
              txtsoghe.Text = currentSoGhe.ToString();
              txtsove.Text = currentSoVe.ToString();*/
        }
        public void show_Datagrid(string query, DataGridView dtgrid)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "DSNV");
            dtgrid.DataSource = ds;
            dtgrid.DataMember = "DSNV";
        }
        private void FormDatVe_Load(object sender, EventArgs e)
        {
            connect();
            Function h = new Function();
            h.loadcbKH("select kh_ma, kh_ten from khachhang", cbmakhach, "kh_ten", "kh_ma", conn);
            h.loadcbNV("select nv_ma, nv_ten from nhanvien", cbmanv, "nv_ten", "nv_ma", conn);
            h.loadcbTX("select tx_ma, tx_ten from taixe", cbmatx, "tx_ten", "tx_ma", conn);
            h.loadcbNV("select * from xe", cbmax, "x_ten", "x_ma", conn);
            h.loadcbNV("select * from tuyen", cbmat, "t_ten", "t_ma", conn);
            // h.hienthi("select cx_ma,cx_soghe, cx_giodi, cx_gioden, cx_banggia from cx_chuyenxe", dtgv);
            string query_NHAN_VIEN = "select cx_ma,cx_soghe, cx_sove, cx_giodi,cx_gioden,cx_gia, t_ma from cx_chuyenxe";
            show_Datagrid(query_NHAN_VIEN, dtgv1);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
         
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            string soghe = txtsoghe.Text;
            string sove = txtsove.Text;

            if (int.Parse(soghe) > 0)
            {
                soghe = (int.Parse(soghe) - int.Parse(sove)).ToString();
            }
            else if (int.Parse(sove) > 0)
            {
                sove = (int.Parse(sove)).ToString();
            }
            else
            {

            }

            //cmd.CommandText = "UPDATE cx_chuyenxe set cx_gia = '" + txtbanggia.Text + "', kh_ma = '" + cbmakhach.SelectedValue.ToString() + "' where cx_ma = '" + txtmachuyen.Text + "'";
            cmd.CommandText = "UPDATE cx_chuyenxe set cx_soghe = '" + soghe + "', cx_giodi = '" + txtgiodi.Text + "', cx_gioden = '" + txtgioden.Text + "', cx_sove = '" + sove + "', cx_gia = '" + txtbanggia.Text + "', kh_ma = '" + cbmakhach.SelectedValue.ToString() + "', nv_ma = '" + cbmanv.SelectedValue.ToString() + "', tx_ma = '" + cbmatx.SelectedValue.ToString() + "',x_ma= '" + cbmax.SelectedValue.ToString() + "', t_ma= '" + cbmat.SelectedValue.ToString() + "' where cx_ma = '" + txtmachuyen.Text + "'";
            cmd.ExecuteNonQuery();
            //string query_NHAN_VIEN = "select * from cx_chuyenxe";
            string query_NHAN_VIEN = "select cx_ma,cx_soghe, cx_sove, cx_giodi,cx_gioden,cx_gia, t_ma from cx_chuyenxe";
            show_Datagrid(query_NHAN_VIEN, dtgv1);
            MessageBox.Show("Đặt chuyến xe thành công!");

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            // Create a new instance of the PrintDocument class
            PrintDocument pd = new PrintDocument();

            // Set the document name for the bill
            pd.DocumentName = "Bill";

            // Add an event handler for the PrintPage event
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);

            // Show the PrintDialog to select the printer and other settings
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                // Set the printer settings for the PrintDocument
                pd.PrinterSettings = printDialog1.PrinterSettings;

                // Print the bill
                pd.Print();
            }
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Define left and top margins
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;

            // Calculate total based on number of tickets and unit price
            int numTickets = int.Parse(txtsove.Text);
            decimal unitPrice = decimal.Parse(txtbanggia.Text);
            decimal total = numTickets * unitPrice;

            // Print bill header
            e.Graphics.DrawString("Bill", font, brush, leftMargin, topMargin);

            // Print line items
            float itemTopMargin = topMargin + 20;
            e.Graphics.DrawString($"Số vé đã đặt: {numTickets}", font, brush, leftMargin, itemTopMargin);
            e.Graphics.DrawString($"Gía vé: {unitPrice:C}", font, brush, leftMargin, itemTopMargin + 20);
            e.Graphics.DrawString($"Tổng tiền: {total:C}", font, brush, leftMargin, itemTopMargin + 40);
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main_QTV main_QTV = new Form_Main_QTV();
            main_QTV.Show();
        }

        private void btntk_Click(object sender, EventArgs e)
        {
        }
    }
}
