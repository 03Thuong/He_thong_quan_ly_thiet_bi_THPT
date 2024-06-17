using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//thuvien
using System.Data.SqlClient;

namespace QLTB
{
    public partial class Nhaptb : Form
    {
        public Nhaptb()
        {
            InitializeComponent();
        }
        // Khai bao doi tuong
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangpn = new DataTable();
        int donghh;
        // hien thi du lieu
        void HienThiDuLieu()
        {
            string sql = "select* from PHIEU_NHAP";
            bangpn = ketnoi.DocDuLieu(sql); // goi ham trong lop
            bodocghi = ketnoi.docghi;   // gan gia tri
            dgvpn.DataSource = bangpn;

        }

        void HienTHINhanVien()
        {
            string sql = "SELECT manv AS 'manv' from NHAN_VIEN";
            cmbmanv.DataSource = ketnoi.DocDuLieu(sql);
            cmbmanv.ValueMember = "manv";
            cmbmanv.DisplayMember = "manv";
        }
        private void Nhaptb_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            HienTHINhanVien();
        }

        private void btnhaplai_Click(object sender, EventArgs e)
        {
            txtmapn.Clear();
            txtmapn.Enabled = true;
            txttentb.Clear();
            txttentb.Enabled = true;
            txtsoluong.Clear();
            txtsoluong.Enabled = true;
            txtncc.Clear();
            txtncc.Enabled = true;
            txtgianhap.Clear();
            txtgianhap.Enabled = true;
            txtghichu.Clear();
            txtghichu.Enabled = true;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (txtmapn.Text != "") // thong tin cho cac truong con lai
            {
                DataRow dongmoi = bangpn.NewRow();
                dongmoi["Mapn"] = txtmapn.Text;
                dongmoi["Tentbm"] = txttentb.Text;
                dongmoi["Soluongnhap"] = txtsoluong.Text;
                dongmoi["NCC"] = txtncc.Text;
                dongmoi["Gianhap"] = txtgianhap.Text;
                dongmoi["Ngaynhap"] = dtpngaynhap.Text;
                dongmoi["manv"] = cmbmanv.Text;
                dongmoi["Ghichu"] = txtghichu.Text;
                bangpn.Rows.Add(dongmoi);
                // cap nhat csdl
                ketnoi.CapNhatDuLieu(bodocghi, bangpn); // goi ham cap nhat
                bangpn.Clear();
                HienThiDuLieu();
            }
        }

        private void dgvpn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            donghh = e.RowIndex;
            if (donghh >= 0)
            {
                txtmapn.Text = bangpn.Rows[donghh][0].ToString();
                txttentb.Text = bangpn.Rows[donghh][1].ToString();
                txtsoluong.Text = bangpn.Rows[donghh][2].ToString();
                txtncc.Text = bangpn.Rows[donghh][3].ToString();
                txtgianhap.Text = bangpn.Rows[donghh][4].ToString();
                dtpngaynhap.Text = bangpn.Rows[donghh][5].ToString();
                cmbmanv.Text = bangpn.Rows[donghh][6].ToString();
                txtghichu.Text = bangpn.Rows[donghh][7].ToString();
                txtmapn.Enabled = false;
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                bangpn.Rows[donghh].Delete();
                //cap nhat CSDL
                ketnoi.CapNhatDuLieu(bodocghi, bangpn); // goiham cap nhat
                bangpn.Clear();
                HienThiDuLieu();
            }
            catch (Exception)
            {
                MessageBox.Show("Khong the xoa");
            }
        }

        private void btchinhsua_Click(object sender, EventArgs e)
        {
            bangpn.Rows[donghh][0] = txtmapn.Text;
            bangpn.Rows[donghh][2] = txttentb.Text;
            bangpn.Rows[donghh][3] = txtsoluong.Text;
            bangpn.Rows[donghh][4] = txtncc.Text;
            bangpn.Rows[donghh][5] = txtgianhap.Text;
            bangpn.Rows[donghh][6] = dtpngaynhap.Text;
            bangpn.Rows[donghh][7] = cmbmanv.Text;
            bangpn.Rows[donghh][8] = txtghichu.Text;

            //cap nhat CSDL;
            ketnoi.CapNhatDuLieu(bodocghi, bangpn); // goiham cap nhat
            bangpn.Clear();
            HienThiDuLieu();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string sql = "select* from PHIEU_NHAP where Tentbm like N'%" + txttimkiem.Text + "%'";
            DataTable dt = ketnoi.DocDuLieu(sql);
            dgvpn.DataSource = dt;
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

        private void btnv_Click(object sender, EventArgs e)
        {
            danhsachNV nv = new danhsachNV();
            this.Hide();
            nv.ShowDialog();
            this.Show();
            this.Close();
        }

        private void btnhaptb_Click(object sender, EventArgs e)
        {

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
