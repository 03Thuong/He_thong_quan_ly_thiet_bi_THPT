using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//thu vien
using System.Data.SqlClient;

namespace QLTB
{
    public partial class danhsachNV : Form
    {
        public danhsachNV()
        {
            InitializeComponent();
        }
        // Khai bao doi tuong
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangnv = new DataTable();
        int donghh;
        // hien thi du lieu
        void HienThiDuLieu()
        {
            string sql = "select* from NHAN_VIEN";
            bangnv = ketnoi.DocDuLieu(sql); // goi ham trong lop
            bodocghi = ketnoi.docghi;   // gan gia tri
            dgvnhanvien.DataSource = bangnv;

        }
        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {
            string sql = "select* from NHAN_VIEN where tennv like N'%" + txttimkiem.Text + "%'";
            DataTable dt = ketnoi.DocDuLieu(sql);
            dgvnhanvien.DataSource = dt;
        }

        private void btnhaplai_Click(object sender, EventArgs e)
        {
            txtmanv.Clear();
            txtmanv.Enabled = true;
            txttennv.Clear();
            txttennv.Enabled = true;
            txtdiachi.Clear();
            txtdiachi.Enabled = true;
            txtsdt.Clear();
            txtsdt.Enabled = true;
            txtcccd.Clear();
            txtcccd.Enabled = true;
            txttaikhoan.Clear();
            txttaikhoan.Enabled = true;
            txtmatkhau.Clear();
            txtmatkhau.Enabled = true;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text != "") // thong tin cho cac truong con lai
            {
                DataRow dongmoi = bangnv.NewRow();
                dongmoi["manv"] = txtmanv.Text;
                dongmoi["tennv"] = txttennv.Text;
                dongmoi["ngaysinh"] = dtpngay.Text;
                dongmoi["gioitinh"] = cmbgioitinh.Text;
                dongmoi["diachi"] = txtdiachi.Text;
                dongmoi["sdt_nv"] = txtsdt.Text;
                dongmoi["CCCD"] = txtcccd.Text;
                dongmoi["taikhoan"] = txttaikhoan.Text;
                dongmoi["matkhau"] = txtmatkhau.Text;
                dongmoi["quyen"] = cmbquyen.Text;
                bangnv.Rows.Add(dongmoi);
                // cap nhat csdl
                ketnoi.CapNhatDuLieu(bodocghi, bangnv); // goi ham cap nhat
                bangnv.Clear();
                HienThiDuLieu();
            }
        }

        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            donghh = e.RowIndex;
            if (donghh >= 0)
            {
                txtmanv.Text = bangnv.Rows[donghh][0].ToString();
                txttennv.Text = bangnv.Rows[donghh][1].ToString();
                dtpngay.Text = bangnv.Rows[donghh][2].ToString();
                cmbgioitinh.Text = bangnv.Rows[donghh][3].ToString();
                txtdiachi.Text = bangnv.Rows[donghh][4].ToString();
                txtsdt.Text = bangnv.Rows[donghh][5].ToString();
                txtcccd.Text = bangnv.Rows[donghh][6].ToString();
                txttaikhoan.Text = bangnv.Rows[donghh][7].ToString();
                txtmatkhau.Text = bangnv.Rows[donghh][8].ToString();
                cmbquyen.Text = bangnv.Rows[donghh][9].ToString();
                txtmanv.Enabled = false;
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                bangnv.Rows[donghh].Delete();
                //cap nhat CSDL
                ketnoi.CapNhatDuLieu(bodocghi, bangnv); // goiham cap nhat
                bangnv.Clear();
                HienThiDuLieu();
            }
            catch (Exception)
            {
                MessageBox.Show("Khong the xoa");
            }
        }

        private void btchinhsua_Click(object sender, EventArgs e)
        {
            bangnv.Rows[donghh][0] = txtmanv.Text;
            bangnv.Rows[donghh][1] = txttennv.Text;
            bangnv.Rows[donghh][2] = dtpngay.Text;
            bangnv.Rows[donghh][3] = cmbgioitinh.Text;
            bangnv.Rows[donghh][4] = txtdiachi.Text;
            bangnv.Rows[donghh][5] = txtsdt.Text;
            bangnv.Rows[donghh][6] = txtcccd.Text;
            bangnv.Rows[donghh][7] = txttaikhoan.Text;
            bangnv.Rows[donghh][8] = txtmatkhau.Text;
            bangnv.Rows[donghh][9] = cmbquyen.Text;
            //cap nhat CSDL;
            ketnoi.CapNhatDuLieu(bodocghi, bangnv); // goiham cap nhat
            bangnv.Clear();
            HienThiDuLieu();
        }

        private void danhsachNV_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void bttb_Click(object sender, EventArgs e)
        {
            Giaodien tb = new Giaodien();
            this.Hide();
            tb.ShowDialog();
            this.Show();
            this.Close();
        }

        private void btmuontb_Click(object sender, EventArgs e)
        {
            Muontb muon = new Muontb();
            this.Hide();
            muon.ShowDialog();
            this.Show();
            this.Close();
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
