using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTB
{
    public partial class INPNHAP : Form
    {
        public INPNHAP()
        {
            InitializeComponent();
        }

        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        DataTable banghd = new DataTable();

        void LoadPhieuNhap()
        {
            string sql = "select* from PHIEU_NHAP";
            cmb_pn.DataSource = ketnoi.DocDuLieu(sql);
            cmb_pn.DisplayMember = "Mapn";
            cmb_pn.ValueMember = "Mapn";

        }

        private void INPNHAP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTB4DataSet.PHIEU_NHAP' table. You can move, or remove it, as needed.
            this.pHIEU_NHAPTableAdapter.Fill(this.qLTB4DataSet.PHIEU_NHAP);
            this.rpv_inphieunhap.RefreshReport();

            LoadPhieuNhap();
            this.rpv_inphieunhap.RefreshReport();

        }

        private void bt_inphieunhap_Click(object sender, EventArgs e)
        {
            string sql = "select* from PHIEU_NHAP where Mapn like '%" + cmb_pn.SelectedValue + "%'";
            banghd = ketnoi.DocDuLieu(sql);
            rpv_inphieunhap.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rpv_inphieunhap.LocalReport.ReportPath = "Report1.rdlc";
            if (banghd.Rows.Count > 0)
            {
                ReportDataSource nguondl = new ReportDataSource();
                nguondl.Name = "inphieunhap";
                nguondl.Value = banghd;
                rpv_inphieunhap.LocalReport.DataSources.Clear();
                rpv_inphieunhap.LocalReport.DataSources.Add(nguondl);
                rpv_inphieunhap.RefreshReport();
            }

        }

        private void btthietbi_Click(object sender, EventArgs e)
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

        private void guna2Button1_Click(object sender, EventArgs e)
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

        private void btnhanvien_Click(object sender, EventArgs e)
        {
            danhsachNV nv = new danhsachNV();
            this.Hide();
            nv.ShowDialog();
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

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pHIEUNHAPBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_pn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rpv_inphieunhap_Load(object sender, EventArgs e)
        {

        }

        private void btinphieunhap_Click(object sender, EventArgs e)
        {

        }

        private void pHIEUNHAPBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
