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
    public partial class Tratb : Form
    {
        public Tratb()
        {
            InitializeComponent();
        }
        // Khai bao doi tuong
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangpt = new DataTable();
        int donghh;
        // hien thi du lieu
        void HienThiDuLieu()
        {
            string sql = "select* from PHIEU_TRA";
            bangpt = ketnoi.DocDuLieu(sql); // goi ham trong lop
            bodocghi = ketnoi.docghi;   // gan gia tri
            dgvtrathietbi.DataSource = bangpt;

        }

        public void HienNhanVien()
        {
            string sql = "select *from NHAN_VIEN";
            cmbmanv.DataSource = ketnoi.DocDuLieu(sql);
            cmbmanv.DisplayMember = "manv";
            cmbmanv.ValueMember = "manv";
        }
        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tratb_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            HienNhanVien();
        }

        private void dgvtrathietbi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            txtma.Clear();
            txtma.Enabled = true;
            txtten.Clear();
            txtten.Enabled = true;
            txtcccd.Clear();
            txtcccd.Enabled = true;
            txtsdt.Clear();
            txtsdt.Enabled = true;
            txtcatra.Clear();
            txtcatra.Enabled = true;
            txtphong.Clear();
            txtphong.Enabled = true;
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
                DataRow dongmoi = bangpt.NewRow();
                dongmoi["mapt"] = txtma.Text;
                dongmoi["Nguoitra"] = txtten.Text;
                dongmoi["Gioitinh"] = cmbgioitinh.Text;
                dongmoi["CCCD"] = txtcccd.Text;
                dongmoi["Sdt"] = txtsdt.Text;
                dongmoi["Ngaytra"] = dtpngay.Text;
                dongmoi["Catra"] = txtcatra.Text;
                dongmoi["TenPhong"] = txtphong.Text;
                dongmoi["Soluong"] = txtsoluong.Text;
                dongmoi["Tentb"] = txttentb.Text;
                dongmoi["manv"] = cmbmanv.Text;
                dongmoi["Ghichu"] = txtghichu.Text;
                bangpt.Rows.Add(dongmoi);
                // cap nhat csdl
                ketnoi.CapNhatDuLieu(bodocghi, bangpt); // goi ham cap nhat
                bangpt.Clear();
                HienThiDuLieu();
            }
        }

        private void dgvtrathietbi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            donghh = e.RowIndex;
            if (donghh >= 0)
            {
                txtma.Text = bangpt.Rows[donghh][0].ToString();
                txtten.Text = bangpt.Rows[donghh][1].ToString();
                cmbgioitinh.Text = bangpt.Rows[donghh][2].ToString();
                txtcccd.Text = bangpt.Rows[donghh][3].ToString();
                txtsdt.Text = bangpt.Rows[donghh][4].ToString();
                dtpngay.Text = bangpt.Rows[donghh][5].ToString();
                txtcatra.Text = bangpt.Rows[donghh][6].ToString();
                txtphong.Text = bangpt.Rows[donghh][7].ToString();
                txtsoluong.Text = bangpt.Rows[donghh][8].ToString();
                txttentb.Text = bangpt.Rows[donghh][9].ToString();
                cmbmanv.Text = bangpt.Rows[donghh][10].ToString();
                txtghichu.Text = bangpt.Rows[donghh][11].ToString();
                txtma.Enabled = false;
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                bangpt.Rows[donghh].Delete();
                //cap nhat CSDL
                ketnoi.CapNhatDuLieu(bodocghi, bangpt); // goiham cap nhat
                bangpt.Clear();
                HienThiDuLieu();
            }
            catch (Exception)
            {
                MessageBox.Show("Khong the xoa");
            }
        }

        private void btchinhsua_Click(object sender, EventArgs e)
        {
            bangpt.Rows[donghh][0] = txtma.Text;
            bangpt.Rows[donghh][1] = txtten.Text;
            bangpt.Rows[donghh][2] = cmbgioitinh.Text;
            bangpt.Rows[donghh][3] = txtcccd.Text;
            bangpt.Rows[donghh][4] = txtsdt.Text;
            bangpt.Rows[donghh][5] = dtpngay.Text;
            bangpt.Rows[donghh][6] = txtcatra.Text;
            bangpt.Rows[donghh][7] = txtphong.Text;
            bangpt.Rows[donghh][8] = txtsoluong.Text;
            bangpt.Rows[donghh][9] = txttentb.Text;
            bangpt.Rows[donghh][10] = cmbmanv.Text;
            bangpt.Rows[donghh][11] = txtghichu.Text;
            //cap nhat CSDL;
            ketnoi.CapNhatDuLieu(bodocghi, bangpt); // goiham cap nhat
            bangpt.Clear();
            HienThiDuLieu();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string sql = "select* from PHIEU_TRA where Nguoitra like N'%" + txttimkiem.Text + "%'";
            DataTable dt = ketnoi.DocDuLieu(sql);
            dgvtrathietbi.DataSource = dt;
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
