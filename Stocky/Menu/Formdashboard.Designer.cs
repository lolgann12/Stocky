namespace Stocky
{
    partial class Formdashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picHeader = new FontAwesome.Sharp.IconPictureBox();
            this.lbldashboard = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.sepHeader = new Guna.UI2.WinForms.Guna2Separator();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.picTotal = new FontAwesome.Sharp.IconPictureBox();
            this.lbltotalbarang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.picMasuk = new FontAwesome.Sharp.IconPictureBox();
            this.lblbarangmasuk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.picKeluar = new FontAwesome.Sharp.IconPictureBox();
            this.lblbarangkeluar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.picStok = new FontAwesome.Sharp.IconPictureBox();
            this.lblstokmenipis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cardGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.picGrid = new FontAwesome.Sharp.IconPictureBox();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodebarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargabeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargajualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_pkkDataSet = new Stocky.db_pkkDataSet();
            this.tb_barangTableAdapter = new Stocky.db_pkkDataSetTableAdapters.tb_barangTableAdapter();
            this.tableAdapterManager = new Stocky.db_pkkDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTotal)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMasuk)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeluar)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStok)).BeginInit();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_pkkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // picHeader
            // 
            this.picHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.picHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.picHeader.IconChar = FontAwesome.Sharp.IconChar.TachometerAltFast;
            this.picHeader.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.picHeader.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picHeader.IconSize = 34;
            this.picHeader.Location = new System.Drawing.Point(20, 14);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(34, 34);
            this.picHeader.TabIndex = 10;
            this.picHeader.TabStop = false;
            // 
            // lbldashboard
            // 
            this.lbldashboard.AutoSize = true;
            this.lbldashboard.BackColor = System.Drawing.Color.Transparent;
            this.lbldashboard.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbldashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lbldashboard.Location = new System.Drawing.Point(58, 10);
            this.lbldashboard.Name = "lbldashboard";
            this.lbldashboard.Size = new System.Drawing.Size(141, 35);
            this.lbldashboard.TabIndex = 0;
            this.lbldashboard.Text = "Dashboard";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSub.Location = new System.Drawing.Point(60, 42);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(236, 20);
            this.lblSub.TabIndex = 11;
            this.lblSub.Text = "Ringkasan stok && aktivitas gudang";
            // 
            // sepHeader
            // 
            this.sepHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.sepHeader.Location = new System.Drawing.Point(20, 68);
            this.sepHeader.Name = "sepHeader";
            this.sepHeader.Size = new System.Drawing.Size(884, 10);
            this.sepHeader.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.panel1.BorderRadius = 14;
            this.panel1.BorderThickness = 1;
            this.panel1.Controls.Add(this.picTotal);
            this.panel1.Controls.Add(this.lbltotalbarang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.panel1.CustomBorderThickness = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.panel1.FillColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(20, 84);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.Depth = 12;
            this.panel1.Size = new System.Drawing.Size(212, 118);
            this.panel1.TabIndex = 1;
            // 
            // picTotal
            // 
            this.picTotal.BackColor = System.Drawing.Color.White;
            this.picTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.picTotal.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            this.picTotal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.picTotal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picTotal.IconSize = 34;
            this.picTotal.Location = new System.Drawing.Point(160, 14);
            this.picTotal.Name = "picTotal";
            this.picTotal.Size = new System.Drawing.Size(34, 34);
            this.picTotal.TabIndex = 2;
            this.picTotal.TabStop = false;
            // 
            // lbltotalbarang
            // 
            this.lbltotalbarang.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalbarang.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbltotalbarang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lbltotalbarang.Location = new System.Drawing.Point(14, 52);
            this.lbltotalbarang.Name = "lbltotalbarang";
            this.lbltotalbarang.Size = new System.Drawing.Size(184, 50);
            this.lbltotalbarang.TabIndex = 1;
            this.lbltotalbarang.Text = "0";
            this.lbltotalbarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Barang";
            // 
            // panel2
            // 
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.panel2.BorderRadius = 14;
            this.panel2.BorderThickness = 1;
            this.panel2.Controls.Add(this.picMasuk);
            this.panel2.Controls.Add(this.lblbarangmasuk);
            this.panel2.Controls.Add(this.label2);
            this.panel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel2.CustomBorderThickness = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.panel2.FillColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(244, 84);
            this.panel2.Name = "panel2";
            this.panel2.ShadowDecoration.Depth = 12;
            this.panel2.Size = new System.Drawing.Size(212, 118);
            this.panel2.TabIndex = 2;
            // 
            // picMasuk
            // 
            this.picMasuk.BackColor = System.Drawing.Color.White;
            this.picMasuk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.picMasuk.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
            this.picMasuk.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.picMasuk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picMasuk.IconSize = 34;
            this.picMasuk.Location = new System.Drawing.Point(160, 14);
            this.picMasuk.Name = "picMasuk";
            this.picMasuk.Size = new System.Drawing.Size(34, 34);
            this.picMasuk.TabIndex = 2;
            this.picMasuk.TabStop = false;
            // 
            // lblbarangmasuk
            // 
            this.lblbarangmasuk.BackColor = System.Drawing.Color.Transparent;
            this.lblbarangmasuk.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblbarangmasuk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblbarangmasuk.Location = new System.Drawing.Point(14, 52);
            this.lblbarangmasuk.Name = "lblbarangmasuk";
            this.lblbarangmasuk.Size = new System.Drawing.Size(184, 50);
            this.lblbarangmasuk.TabIndex = 1;
            this.lblbarangmasuk.Text = "0";
            this.lblbarangmasuk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Barang Masuk";
            // 
            // panel3
            // 
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.panel3.BorderRadius = 14;
            this.panel3.BorderThickness = 1;
            this.panel3.Controls.Add(this.picKeluar);
            this.panel3.Controls.Add(this.lblbarangkeluar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel3.CustomBorderThickness = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.panel3.FillColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(468, 84);
            this.panel3.Name = "panel3";
            this.panel3.ShadowDecoration.Depth = 12;
            this.panel3.Size = new System.Drawing.Size(212, 118);
            this.panel3.TabIndex = 3;
            // 
            // picKeluar
            // 
            this.picKeluar.BackColor = System.Drawing.Color.White;
            this.picKeluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.picKeluar.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.picKeluar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.picKeluar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picKeluar.IconSize = 34;
            this.picKeluar.Location = new System.Drawing.Point(160, 14);
            this.picKeluar.Name = "picKeluar";
            this.picKeluar.Size = new System.Drawing.Size(34, 34);
            this.picKeluar.TabIndex = 2;
            this.picKeluar.TabStop = false;
            // 
            // lblbarangkeluar
            // 
            this.lblbarangkeluar.BackColor = System.Drawing.Color.Transparent;
            this.lblbarangkeluar.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblbarangkeluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblbarangkeluar.Location = new System.Drawing.Point(14, 52);
            this.lblbarangkeluar.Name = "lblbarangkeluar";
            this.lblbarangkeluar.Size = new System.Drawing.Size(184, 50);
            this.lblbarangkeluar.TabIndex = 1;
            this.lblbarangkeluar.Text = "0";
            this.lblbarangkeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Barang Keluar";
            // 
            // panel4
            // 
            this.panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.panel4.BorderRadius = 14;
            this.panel4.BorderThickness = 1;
            this.panel4.Controls.Add(this.picStok);
            this.panel4.Controls.Add(this.lblstokmenipis);
            this.panel4.Controls.Add(this.label4);
            this.panel4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.panel4.CustomBorderThickness = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.panel4.FillColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(692, 84);
            this.panel4.Name = "panel4";
            this.panel4.ShadowDecoration.Depth = 12;
            this.panel4.Size = new System.Drawing.Size(212, 118);
            this.panel4.TabIndex = 4;
            // 
            // picStok
            // 
            this.picStok.BackColor = System.Drawing.Color.White;
            this.picStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.picStok.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.picStok.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.picStok.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picStok.IconSize = 34;
            this.picStok.Location = new System.Drawing.Point(160, 14);
            this.picStok.Name = "picStok";
            this.picStok.Size = new System.Drawing.Size(34, 34);
            this.picStok.TabIndex = 2;
            this.picStok.TabStop = false;
            // 
            // lblstokmenipis
            // 
            this.lblstokmenipis.BackColor = System.Drawing.Color.Transparent;
            this.lblstokmenipis.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblstokmenipis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblstokmenipis.Location = new System.Drawing.Point(14, 52);
            this.lblstokmenipis.Name = "lblstokmenipis";
            this.lblstokmenipis.Size = new System.Drawing.Size(184, 50);
            this.lblstokmenipis.TabIndex = 1;
            this.lblstokmenipis.Text = "0";
            this.lblstokmenipis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stok Menipis";
            // 
            // cardGrid
            // 
            this.cardGrid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cardGrid.BorderRadius = 14;
            this.cardGrid.BorderThickness = 1;
            this.cardGrid.Controls.Add(this.lblGridTitle);
            this.cardGrid.Controls.Add(this.picGrid);
            this.cardGrid.Controls.Add(this.dataGridView1);
            this.cardGrid.FillColor = System.Drawing.Color.White;
            this.cardGrid.Location = new System.Drawing.Point(20, 214);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.ShadowDecoration.Depth = 12;
            this.cardGrid.Size = new System.Drawing.Size(884, 330);
            this.cardGrid.TabIndex = 13;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblGridTitle.Location = new System.Drawing.Point(48, 14);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(157, 25);
            this.lblGridTitle.TabIndex = 2;
            this.lblGridTitle.Text = "Data Stok Terkini";
            // 
            // picGrid
            // 
            this.picGrid.BackColor = System.Drawing.Color.White;
            this.picGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.picGrid.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.picGrid.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.picGrid.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picGrid.IconSize = 26;
            this.picGrid.Location = new System.Drawing.Point(18, 14);
            this.picGrid.Name = "picGrid";
            this.picGrid.Size = new System.Drawing.Size(26, 26);
            this.picGrid.TabIndex = 1;
            this.picGrid.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 38;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarangDataGridViewTextBoxColumn,
            this.kodebarangDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.hargabeliDataGridViewTextBoxColumn,
            this.hargajualDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.satuanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tb_barangBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dataGridView1.Location = new System.Drawing.Point(14, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(856, 266);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 38;
            this.dataGridView1.ThemeStyle.ReadOnly = true;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 30;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            // 
            // idbarangDataGridViewTextBoxColumn
            // 
            this.idbarangDataGridViewTextBoxColumn.DataPropertyName = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idbarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbarangDataGridViewTextBoxColumn.Name = "idbarangDataGridViewTextBoxColumn";
            this.idbarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodebarangDataGridViewTextBoxColumn
            // 
            this.kodebarangDataGridViewTextBoxColumn.DataPropertyName = "kode_barang";
            this.kodebarangDataGridViewTextBoxColumn.HeaderText = "Kode";
            this.kodebarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodebarangDataGridViewTextBoxColumn.Name = "kodebarangDataGridViewTextBoxColumn";
            this.kodebarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang";
            this.namabarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            this.namabarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargabeliDataGridViewTextBoxColumn
            // 
            this.hargabeliDataGridViewTextBoxColumn.DataPropertyName = "harga_beli";
            this.hargabeliDataGridViewTextBoxColumn.HeaderText = "Harga Beli";
            this.hargabeliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargabeliDataGridViewTextBoxColumn.Name = "hargabeliDataGridViewTextBoxColumn";
            this.hargabeliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargajualDataGridViewTextBoxColumn
            // 
            this.hargajualDataGridViewTextBoxColumn.DataPropertyName = "harga_jual";
            this.hargajualDataGridViewTextBoxColumn.HeaderText = "Harga Jual";
            this.hargajualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargajualDataGridViewTextBoxColumn.Name = "hargajualDataGridViewTextBoxColumn";
            this.hargajualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // satuanDataGridViewTextBoxColumn
            // 
            this.satuanDataGridViewTextBoxColumn.DataPropertyName = "satuan";
            this.satuanDataGridViewTextBoxColumn.HeaderText = "Satuan";
            this.satuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satuanDataGridViewTextBoxColumn.Name = "satuanDataGridViewTextBoxColumn";
            this.satuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tb_barangBindingSource
            // 
            this.tb_barangBindingSource.DataMember = "tb_barang";
            this.tb_barangBindingSource.DataSource = this.db_pkkDataSet;
            // 
            // db_pkkDataSet
            // 
            this.db_pkkDataSet.DataSetName = "db_pkkDataSet";
            this.db_pkkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_barangTableAdapter
            // 
            this.tb_barangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_auditlogTableAdapter = null;
            this.tableAdapterManager.tb_barangkeluarTableAdapter = null;
            this.tableAdapterManager.tb_barangmasukTableAdapter = null;
            this.tableAdapterManager.tb_barangTableAdapter = this.tb_barangTableAdapter;
            this.tableAdapterManager.tb_laporanTableAdapter = null;
            this.tableAdapterManager.tb_userTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Stocky.db_pkkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Formdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(924, 558);
            this.Controls.Add(this.cardGrid);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sepHeader);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lbldashboard);
            this.Controls.Add(this.picHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formdashboard";
            this.Text = "Formdashboard";
            this.Load += new System.EventHandler(this.Formdashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTotal)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMasuk)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeluar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStok)).EndInit();
            this.cardGrid.ResumeLayout(false);
            this.cardGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_pkkDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox picHeader;
        private System.Windows.Forms.Label lblSub;
        private Guna.UI2.WinForms.Guna2Separator sepHeader;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private FontAwesome.Sharp.IconPictureBox picTotal;
        private System.Windows.Forms.Label lbltotalbarang;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel panel2;
        private FontAwesome.Sharp.IconPictureBox picMasuk;
        private System.Windows.Forms.Label lblbarangmasuk;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel panel3;
        private FontAwesome.Sharp.IconPictureBox picKeluar;
        private System.Windows.Forms.Label lblbarangkeluar;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel panel4;
        private FontAwesome.Sharp.IconPictureBox picStok;
        private System.Windows.Forms.Label lblstokmenipis;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel cardGrid;
        private System.Windows.Forms.Label lblGridTitle;
        private FontAwesome.Sharp.IconPictureBox picGrid;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.Label lbldashboard;
        private db_pkkDataSet db_pkkDataSet;
        private System.Windows.Forms.BindingSource tb_barangBindingSource;
        private db_pkkDataSetTableAdapters.tb_barangTableAdapter tb_barangTableAdapter;
        private db_pkkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodebarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargabeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargajualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuanDataGridViewTextBoxColumn;
    }
}
