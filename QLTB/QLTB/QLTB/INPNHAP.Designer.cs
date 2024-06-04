namespace QLTB
{
    partial class INPNHAP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pHIEUNHAPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLTB4DataSet = new QLTB.QLTB4DataSet();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.bt_inphieunhap = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmb_pn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.rpv_inphieunhap = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btdangxuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.btinphieunhap = new Guna.UI2.WinForms.Guna2Button();
            this.btnhaptb = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btmuontb = new Guna.UI2.WinForms.Guna2Button();
            this.btthietbi = new Guna.UI2.WinForms.Guna2Button();
            this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEU_NHAPTableAdapter = new QLTB.QLTB4DataSetTableAdapters.PHIEU_NHAPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTB4DataSet)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pHIEUNHAPBindingSource1
            // 
            this.pHIEUNHAPBindingSource1.DataMember = "PHIEU_NHAP";
            this.pHIEUNHAPBindingSource1.DataSource = this.qLTB4DataSet;
            this.pHIEUNHAPBindingSource1.CurrentChanged += new System.EventHandler(this.pHIEUNHAPBindingSource1_CurrentChanged);
            // 
            // qLTB4DataSet
            // 
            this.qLTB4DataSet.DataSetName = "QLTB4DataSet";
            this.qLTB4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 36;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2GradientPanel1.Controls.Add(this.bt_inphieunhap);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel1.Controls.Add(this.cmb_pn);
            this.guna2GradientPanel1.Controls.Add(this.rpv_inphieunhap);
            this.guna2GradientPanel1.Controls.Add(this.guna2Panel1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(10, 10);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1338, 703);
            this.guna2GradientPanel1.TabIndex = 0;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1293, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 5;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // bt_inphieunhap
            // 
            this.bt_inphieunhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_inphieunhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_inphieunhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_inphieunhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_inphieunhap.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inphieunhap.ForeColor = System.Drawing.Color.White;
            this.bt_inphieunhap.Location = new System.Drawing.Point(846, 35);
            this.bt_inphieunhap.Name = "bt_inphieunhap";
            this.bt_inphieunhap.Size = new System.Drawing.Size(117, 45);
            this.bt_inphieunhap.TabIndex = 4;
            this.bt_inphieunhap.Text = "Lọc";
            this.bt_inphieunhap.Click += new System.EventHandler(this.bt_inphieunhap_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(357, 49);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(161, 31);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Mã phiếu nhập";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // cmb_pn
            // 
            this.cmb_pn.BackColor = System.Drawing.Color.Transparent;
            this.cmb_pn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_pn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_pn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_pn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_pn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_pn.ItemHeight = 30;
            this.cmb_pn.Location = new System.Drawing.Point(535, 44);
            this.cmb_pn.Name = "cmb_pn";
            this.cmb_pn.Size = new System.Drawing.Size(271, 36);
            this.cmb_pn.TabIndex = 2;
            this.cmb_pn.SelectedIndexChanged += new System.EventHandler(this.cmb_pn_SelectedIndexChanged);
            // 
            // rpv_inphieunhap
            // 
            reportDataSource1.Name = "inphieunhap";
            reportDataSource1.Value = this.pHIEUNHAPBindingSource1;
            this.rpv_inphieunhap.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_inphieunhap.LocalReport.ReportEmbeddedResource = "QLTB.Report1.rdlc";
            this.rpv_inphieunhap.Location = new System.Drawing.Point(183, 158);
            this.rpv_inphieunhap.Name = "rpv_inphieunhap";
            this.rpv_inphieunhap.ServerReport.BearerToken = null;
            this.rpv_inphieunhap.Size = new System.Drawing.Size(1152, 545);
            this.rpv_inphieunhap.TabIndex = 1;
            this.rpv_inphieunhap.Load += new System.EventHandler(this.rpv_inphieunhap_Load);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.btdangxuat);
            this.guna2Panel1.Controls.Add(this.btnhanvien);
            this.guna2Panel1.Controls.Add(this.btinphieunhap);
            this.guna2Panel1.Controls.Add(this.btnhaptb);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.btmuontb);
            this.guna2Panel1.Controls.Add(this.btthietbi);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(180, 703);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btdangxuat
            // 
            this.btdangxuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btdangxuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btdangxuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btdangxuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btdangxuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangxuat.ForeColor = System.Drawing.Color.White;
            this.btdangxuat.Location = new System.Drawing.Point(0, 553);
            this.btdangxuat.Name = "btdangxuat";
            this.btdangxuat.Size = new System.Drawing.Size(180, 58);
            this.btdangxuat.TabIndex = 5;
            this.btdangxuat.Text = "ĐĂNG XUẤT";
            this.btdangxuat.Click += new System.EventHandler(this.btdangxuat_Click);
            // 
            // btnhanvien
            // 
            this.btnhanvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhanvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhanvien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhanvien.ForeColor = System.Drawing.Color.White;
            this.btnhanvien.Location = new System.Drawing.Point(3, 417);
            this.btnhanvien.Name = "btnhanvien";
            this.btnhanvien.Size = new System.Drawing.Size(180, 58);
            this.btnhanvien.TabIndex = 5;
            this.btnhanvien.Text = "NHÂN VIÊN";
            this.btnhanvien.Click += new System.EventHandler(this.btnhanvien_Click);
            // 
            // btinphieunhap
            // 
            this.btinphieunhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btinphieunhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btinphieunhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btinphieunhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btinphieunhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btinphieunhap.ForeColor = System.Drawing.Color.White;
            this.btinphieunhap.Location = new System.Drawing.Point(-17, 339);
            this.btinphieunhap.Name = "btinphieunhap";
            this.btinphieunhap.Size = new System.Drawing.Size(210, 58);
            this.btinphieunhap.TabIndex = 5;
            this.btinphieunhap.Text = "IN PHIẾU NHẬP";
            this.btinphieunhap.Click += new System.EventHandler(this.btinphieunhap_Click);
            // 
            // btnhaptb
            // 
            this.btnhaptb.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhaptb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhaptb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhaptb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhaptb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhaptb.ForeColor = System.Drawing.Color.White;
            this.btnhaptb.Location = new System.Drawing.Point(-3, 260);
            this.btnhaptb.Name = "btnhaptb";
            this.btnhaptb.Size = new System.Drawing.Size(180, 59);
            this.btnhaptb.TabIndex = 5;
            this.btnhaptb.Text = "NHẬP THIẾT BỊ";
            this.btnhaptb.Click += new System.EventHandler(this.btnhaptb_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(3, 179);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 60);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "TRẢ THIẾT BỊ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btmuontb
            // 
            this.btmuontb.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btmuontb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btmuontb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btmuontb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btmuontb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmuontb.ForeColor = System.Drawing.Color.White;
            this.btmuontb.Location = new System.Drawing.Point(-3, 102);
            this.btmuontb.Name = "btmuontb";
            this.btmuontb.Size = new System.Drawing.Size(193, 61);
            this.btmuontb.TabIndex = 5;
            this.btmuontb.Text = "MƯỢN THIẾT BỊ";
            this.btmuontb.Click += new System.EventHandler(this.btmuontb_Click);
            // 
            // btthietbi
            // 
            this.btthietbi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btthietbi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btthietbi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btthietbi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btthietbi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthietbi.ForeColor = System.Drawing.Color.White;
            this.btthietbi.Location = new System.Drawing.Point(3, 35);
            this.btthietbi.Name = "btthietbi";
            this.btthietbi.Size = new System.Drawing.Size(180, 61);
            this.btthietbi.TabIndex = 5;
            this.btthietbi.Text = "THIẾT BỊ";
            this.btthietbi.Click += new System.EventHandler(this.btthietbi_Click);
            // 
            // pHIEUNHAPBindingSource
            // 
            this.pHIEUNHAPBindingSource.DataMember = "PHIEU_NHAP";
            this.pHIEUNHAPBindingSource.DataSource = this.qLTB4DataSet;
            this.pHIEUNHAPBindingSource.CurrentChanged += new System.EventHandler(this.pHIEUNHAPBindingSource_CurrentChanged);
            // 
            // pHIEU_NHAPTableAdapter
            // 
            this.pHIEU_NHAPTableAdapter.ClearBeforeFill = true;
            // 
            // INPNHAP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1358, 723);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "INPNHAP";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "INPNHAP";
            this.Load += new System.EventHandler(this.INPNHAP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTB4DataSet)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_inphieunhap;
        private QLTB4DataSet qLTB4DataSet;
        private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
        private QLTB4DataSetTableAdapters.PHIEU_NHAPTableAdapter pHIEU_NHAPTableAdapter;
        private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_pn;
        private Guna.UI2.WinForms.Guna2Button bt_inphieunhap;
        private Guna.UI2.WinForms.Guna2Button btthietbi;
        private Guna.UI2.WinForms.Guna2Button btmuontb;
        private Guna.UI2.WinForms.Guna2Button btnhaptb;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btdangxuat;
        private Guna.UI2.WinForms.Guna2Button btnhanvien;
        private Guna.UI2.WinForms.Guna2Button btinphieunhap;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}