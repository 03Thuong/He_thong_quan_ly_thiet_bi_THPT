using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace QLTB
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string sql = "select taikhoan, matkhau, manv, tennv  from NHAN_VIEN where taikhoan = '" + txttaikhoan.Text + "' and matkhau = '" + txtmatkhau.Text + "'";
            DataTable dt = ketnoi.DocDuLieu(sql);
            if (txttaikhoan.Text == "admin" && txtmatkhau.Text == "abc")
            {
                Trangchinh t = new Trangchinh();
                this.Hide();
                t.ShowDialog();
                this.Show();
                this.Close();
            }
            else if (dt.Rows.Count != 0)
            {
                Trangchinh t = new Trangchinh();
                this.Hide();
                t.ShowDialog();
                this.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Dangnhap_Load(this, null);     */
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbhienthimatkhau.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = true;
            }
            if (!ckbhienthimatkhau.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

