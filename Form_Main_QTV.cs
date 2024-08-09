using BVXE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class Form_Main_QTV : Form
    {
        public Form_Main_QTV()
        {
            InitializeComponent();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Đến form quản lý nhân viên
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLNV Form_QLNV = new QLNV();
            Form_QLNV.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDatVe Form_QLNV = new FormDatVe();
            Form_QLNV.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaoChuyenXecs Form_QLNV = new TaoChuyenXecs();
            Form_QLNV.Show();
        }
    }
}
