using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace BVXE
{
    internal class Function
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
        public void loadcbKH(string query, ComboBox cb, string hienthi, string giatri, SqlConnection conn)
        {
            
            SqlCommand cmd = new SqlCommand(query, conn);
            //cmd = conn.CreateCommand();
            SqlDataReader read = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(read);
            cb.DataSource = table;
            cb.DisplayMember = hienthi;
            cb.ValueMember = giatri;
        }
        public void loadcbNV(string query, ComboBox cb, string hienthi, string giatri, SqlConnection conn)
        {

            SqlCommand cmd = new SqlCommand(query, conn);
            //cmd = conn.CreateCommand();
            SqlDataReader read = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(read);
            cb.DataSource = table;
            cb.DisplayMember = hienthi;
            cb.ValueMember = giatri;
        }
        public void loadcbTX(string query, ComboBox cb, string hienthi, string giatri, SqlConnection conn)
        {

            SqlCommand cmd = new SqlCommand(query, conn);
            //cmd = conn.CreateCommand();
            SqlDataReader read = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(read);
            cb.DataSource = table;
            cb.DisplayMember = hienthi;
            cb.ValueMember = giatri;
        }
        public void loadcbX(string query, ComboBox cb, string hienthi, string giatri, SqlConnection conn)
        {

            SqlCommand cmd = new SqlCommand(query, conn);
            //cmd = conn.CreateCommand();
            SqlDataReader read = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(read);
            cb.DataSource = table;
            cb.DisplayMember = hienthi;
            cb.ValueMember = giatri;
        }
        public void loadcbT(string query, ComboBox cb, string hienthi, string giatri, SqlConnection conn)
        {

            SqlCommand cmd = new SqlCommand(query, conn);
            //cmd = conn.CreateCommand();
            SqlDataReader read = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(read);
            cb.DataSource = table;
            cb.DisplayMember = hienthi;
            cb.ValueMember = giatri;
        }
        /*public void hienthi(string query, DataGridView dtgv)
        {
            connect();
            SqlDataAdapter dt = new SqlDataAdapter(query , conn);
            DataSet ds = new DataSet();
            dt.Fill(ds, "sv");
            dtgv.DataSource = ds;
            dtgv.DataMember = "sv";
        }*/
       
    }
}
