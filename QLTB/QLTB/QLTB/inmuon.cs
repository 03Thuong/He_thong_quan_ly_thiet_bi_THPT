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
    public partial class inmuon : Form
    {
        public inmuon()
        {
            InitializeComponent();
        }
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        DataTable banghd = new DataTable();

        void LoadPhieuMuon()
        {
            string sql = "select* from PHIEU_MUON";
            cmb_pm.DataSource = ketnoi.DocDuLieu(sql);
            cmb_pm.DisplayMember = "id";
            cmb_pm.ValueMember = "id";

        }
        private void btthietbi_Click(object sender, EventArgs e)
        {

        }

        private void inmuon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTB4DataSet1.PHIEU_MUON' table. You can move, or remove it, as needed.
            this.pHIEU_MUONTableAdapter.Fill(this.qLTB4DataSet1.PHIEU_MUON);
            this.rpv_inphieumuon.RefreshReport();

            LoadPhieuMuon();
            this.rpv_inphieumuon.RefreshReport();

        }

        private void rpv_inphieumuon_Load(object sender, EventArgs e)
        {

        }
    }
}
