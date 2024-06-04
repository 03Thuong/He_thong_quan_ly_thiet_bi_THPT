using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// thu vien
using System.Data.SqlClient;

namespace QLTB
{
    public partial class Giaodien : Form
    {
        public Giaodien()
        {
            InitializeComponent();
        }
        // Khai bao doi tuong
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangtb = new DataTable();
        int donghh;

        // hien thi du lieu
        void HienThiDuLieu()
        {
            string sql = "select* from THIET_BI";
            bangtb = ketnoi.DocDuLieu(sql); // goi ham trong lop
            bodocghi = ketnoi.docghi; //gan gia tri
            dgvthietbi.DataSource = bangtb;
        }
        private void Giaodien_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void guna2Chip1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnhaplai_Click(object sender, EventArgs e)
        {
            txtmatb.Clear();
            txtmatb.Enabled = true;
            txttentb.Clear();
            txttentb.Enabled = true;
            txtsoluong.Clear();
            txtsoluong.Enabled = true;
            txtncc.Clear();
            txtncc.Enabled = true;
            txtbaohanh.Clear();
            txtbaohanh.Enabled = true;
            txtgia.Clear();
            txtgia.Enabled = true;
            txttinhtrang.Clear();
            txttinhtrang.Enabled = true;
            txtghichu.Clear();
            txtghichu.Enabled = true;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (txtmatb.Text != "") // thong tin cho cac truong con lai
            {
                DataRow dongmoi = bangtb.NewRow();
                dongmoi["Matb"] = txtmatb.Text;
                dongmoi["Tentb"] = txttentb.Text;
                dongmoi["Ngaynhap"] = dtpngaynhap.Text;
                dongmoi["Soluongmua"] = txtsoluong.Text;
                dongmoi["NCC"] = txtncc.Text;
                dongmoi["Baohanh"] = txtbaohanh.Text;
                dongmoi["Giamua"] = txtgia.Text;
                dongmoi["Tinhtrang"] = txttinhtrang.Text;
                dongmoi["Ghichu"] = txtghichu.Text;
                bangtb.Rows.Add(dongmoi);
                // cap nhat CSDL
                ketnoi.CapNhatDuLieu(bodocghi, bangtb); // goiham cap nhat
                bangtb.Clear();
                HienThiDuLieu();
            }
        }

        private void dgvthietbi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            donghh = e.RowIndex;
            if (donghh >= 0)
            {
                txtmatb.Text = bangtb.Rows[donghh][0].ToString();
                txttentb.Text = bangtb.Rows[donghh][1].ToString();
                dtpngaynhap.Text = bangtb.Rows[donghh][2].ToString();
                txtsoluong.Text = bangtb.Rows[donghh][3].ToString();
                txtncc.Text = bangtb.Rows[donghh][4].ToString();
                txtbaohanh.Text = bangtb.Rows[donghh][5].ToString();
                txtgia.Text = bangtb.Rows[donghh][6].ToString();
                txttinhtrang.Text = bangtb.Rows[donghh][7].ToString();
                txtghichu.Text = bangtb.Rows[donghh][8].ToString();
                txtmatb.Enabled = false;

            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                bangtb.Rows[donghh].Delete();
                //cap nhat CSDL
                ketnoi.CapNhatDuLieu(bodocghi, bangtb); // goiham cap nhat
                bangtb.Clear();
                HienThiDuLieu();
            }
            catch (Exception)
            {
                MessageBox.Show("Khong the xoa");
            }
        }

        private void btchinhsua_Click(object sender, EventArgs e)
        {
            bangtb.Rows[donghh][0] = txtmatb.Text;
            bangtb.Rows[donghh][1] = txttentb.Text;
            bangtb.Rows[donghh][2] = dtpngaynhap.Text;
            bangtb.Rows[donghh][3] = txtsoluong.Text;
            bangtb.Rows[donghh][4] = txtncc.Text;
            bangtb.Rows[donghh][5] = txtbaohanh.Text;
            bangtb.Rows[donghh][6] = txttinhtrang.Text;
            bangtb.Rows[donghh][7] = txtghichu.Text;
            //cap nhat CSDL;
            ketnoi.CapNhatDuLieu(bodocghi, bangtb); // goiham cap nhat
            bangtb.Clear();
            HienThiDuLieu();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Muontb muon = new Muontb();
            this.Hide();
            muon.ShowDialog();
            this.Show();
            this.Close();
        }

        private void txtghichu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string sql = "select* from THIET_BI where Tentb like N'%" + txttimkiem.Text + "%'";
            DataTable dt = ketnoi.DocDuLieu(sql);
            dgvthietbi.DataSource = dt;
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void bttratb_Click(object sender, EventArgs e)
        {
            Tratb tra = new Tratb();
            this.Hide();
            tra.ShowDialog();
            this.Show();
            this.Close();
        }

        private void btnhaptb_Click(object sender, EventArgs e)
        {
            Nhaptb nhap = new Nhaptb();
            this.Hide();
            nhap.ShowDialog();
            this.Show();
            this.Close();
        }

        private void btnv_Click(object sender, EventArgs e)
        {
            danhsachNV nv = new danhsachNV();
            this.Hide();
            nv.ShowDialog();
            this.Show();
            this.Close();
        }

        private void btinpn_Click(object sender, EventArgs e)
        {
            INPNHAP i = new INPNHAP();
            this.Hide();
            i.ShowDialog();
            this.Show();
            this.Close();
        }

        private void btdangxuat_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            this.Hide();
            x.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
