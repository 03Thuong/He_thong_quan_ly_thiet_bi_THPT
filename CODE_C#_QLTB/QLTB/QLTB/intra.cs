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
    public partial class intra : Form
    {
        public intra()
        {
            InitializeComponent();
        }
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        DataTable banghd = new DataTable();

        void LoadPhieuTRA()
        {
            string sql = "select* from PHIEU_TRA";
            cmb_pm.DataSource = ketnoi.DocDuLieu(sql);
            cmb_pm.DisplayMember = "mapt";
            cmb_pm.ValueMember = "mapt";

        }
        private void intra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTB4DataSet2.PHIEU_TRA' table. You can move, or remove it, as needed.
            this.pHIEU_TRATableAdapter.Fill(this.qLTB4DataSet2.PHIEU_TRA);

            LoadPhieuTRA();
            this.rpv_inphieumuon.RefreshReport();

        }
    }
}
