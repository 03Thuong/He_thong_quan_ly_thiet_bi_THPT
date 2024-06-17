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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            string sql = "select taikhoan, matkhau, manv, tennv  from NHAN_VIEN where taikhoan = '" + txttaikhoan.Text + "' and matkhau = '" + txtmatkhau.Text + "'";
            DataTable dt = ketnoi.DocDuLieu(sql);
            if (txttaikhoan.Text == "admin" && txtmatkhau.Text == "abc")
            {
                Giaodien t = new Giaodien();
                this.Hide();
                t.ShowDialog();
                this.Show();
                this.Close();
            }
            else if (dt.Rows.Count != 0)
            {
                Giaodien t = new Giaodien();
                this.Hide();
                t.ShowDialog();
                this.Show();
                this.Close();






            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Form1_Load(this, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            }
        }
    }

