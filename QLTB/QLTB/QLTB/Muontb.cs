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

namespace QLTB
{
    public partial class Muontb : Form
    {
        
        public Muontb()
        {
            InitializeComponent();
            
        }
        // Khai bao doi tuong
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangsd = new DataTable();
        int donghh;
        // hien thi du lieu
        void HienThiDuLieu()
        {
            string sql = "select* from PHIEU_MUON";
            bangsd = ketnoi.DocDuLieu(sql); // goi ham trong lop
            bodocghi = ketnoi.docghi;   // gan gia tri
            dgvmuonthietbi.DataSource = bangsd;

        }
        
        public void HienNhanVien()
        {
            string sql = "select *from NHAN_VIEN";
            cmbmanv.DataSource = ketnoi.DocDuLieu(sql);
            cmbmanv.DisplayMember = "manv";
            cmbmanv.ValueMember = "manv";
        }
        
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Muontb_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            HienNhanVien();
        }

        private void dgvmuonthietbi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnhaplai_Click(object sender, EventArgs e)
        {
            txtma.Clear();
            txtma.Enabled = true;
            txtnguoimuon.Clear();
            txtnguoimuon.Enabled = true;
            txtcccd.Clear();
            txtcccd.Enabled = true;
            txtsdt.Clear();
            txtsdt.Enabled = true;
            txtcamuon.Clear();
            txtcamuon.Enabled = true;
            txttenphong.Clear();
            txttenphong.Enabled = true;
            txtsoluong.Clear();
            txtsoluong.Enabled = true;
            txttentb.Clear();
            txttentb.Enabled = true;
            txtghichu.Clear();
            txtghichu.Enabled = true;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "") // thong tin cho cac truong con lai
            {
                DataRow dongmoi = bangsd.NewRow();
                dongmoi["id"] = txtma.Text;
                dongmoi["Nguoimuon"] = txtnguoimuon.Text;
                dongmoi["Gioitinh"] = cmbgioitinh.Text;
                dongmoi["CCCD"] = txtcccd.Text;
                dongmoi["Sdt"] = txtsdt.Text;
                dongmoi["Ngaymuon"] = dtpngaymuon.Text;
                dongmoi["Camuon"] = txtcamuon.Text;
                dongmoi["TenPhong"] = txttenphong.Text;
                dongmoi["Soluong"] = txtsoluong.Text;
                dongmoi["Tentb"] = txttentb.Text;
                dongmoi["manv"] = cmbmanv.Text;
                dongmoi["Ghichu"] = txtghichu.Text;
                bangsd.Rows.Add(dongmoi);
                // cap nhat csdl
                ketnoi.CapNhatDuLieu(bodocghi, bangsd); // goi ham cap nhat
                bangsd.Clear();
                HienThiDuLieu();


            }
        }

        private void dgvmuonthietbi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            donghh = e.RowIndex;
            if (donghh >= 0)
            {
                txtma.Text = bangsd.Rows[donghh][0].ToString();
                txtnguoimuon.Text = bangsd.Rows[donghh][1].ToString();
                cmbgioitinh.Text = bangsd.Rows[donghh][2].ToString();
                txtcccd.Text = bangsd.Rows[donghh][3].ToString();
                txtsdt.Text = bangsd.Rows[donghh][4].ToString();
                dtpngaymuon.Text = bangsd.Rows[donghh][5].ToString();
                txtcamuon.Text = bangsd.Rows[donghh][6].ToString();
                txttenphong.Text = bangsd.Rows[donghh][7].ToString();
                txtsoluong.Text = bangsd.Rows[donghh][8].ToString();
                txttentb.Text = bangsd.Rows[donghh][9].ToString();
                cmbmanv.Text = bangsd.Rows[donghh][10].ToString();
                txtghichu.Text = bangsd.Rows[donghh][11].ToString();
                txtma.Enabled = false;
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                bangsd.Rows[donghh].Delete();
                //cap nhat CSDL
                ketnoi.CapNhatDuLieu(bodocghi, bangsd); // goiham cap nhat
                bangsd.Clear();
                HienThiDuLieu();
            }
            catch (Exception)
            {
                MessageBox.Show("Khong the xoa");
            }
        }

        private void btchinhsua_Click(object sender, EventArgs e)
        {
            bangsd.Rows[donghh][0] = txtma.Text;
            bangsd.Rows[donghh][1] = txtnguoimuon.Text;
            bangsd.Rows[donghh][2] = cmbgioitinh.Text;
            bangsd.Rows[donghh][3] = txtcccd.Text;
            bangsd.Rows[donghh][4] = txtsdt.Text;
            bangsd.Rows[donghh][5] = dtpngaymuon.Text;
            bangsd.Rows[donghh][6] = txtcamuon.Text;
            bangsd.Rows[donghh][7] = txttenphong.Text;
            bangsd.Rows[donghh][8] = txtsoluong.Text;
            bangsd.Rows[donghh][9] = txttentb.Text;
            bangsd.Rows[donghh][10] = cmbmanv.Text;
            bangsd.Rows[donghh][11] = txtghichu.Text;
            //cap nhat CSDL;
            ketnoi.CapNhatDuLieu(bodocghi, bangsd); // goiham cap nhat
            bangsd.Clear();
            HienThiDuLieu();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txttimkim_TextChanged(object sender, EventArgs e)
        {
            string sql = "select* from PHIEU_MUON where Nguoimuon like '%" + txttimkim.Text + "%'";
            DataTable dt = ketnoi.DocDuLieu(sql);
            dgvmuonthietbi.DataSource = dt;
        }

        private void btthietbi_Click(object sender, EventArgs e)
        {
            Giaodien tb = new Giaodien();
            this.Hide();
            tb.ShowDialog();
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

        private void txttenphong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
