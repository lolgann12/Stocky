namespace Stocky
{
    partial class Formbarangkeluar
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
            this.lbljudul = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.sepHeader = new Guna.UI2.WinForms.Guna2Separator();
            this.cardForm = new Guna.UI2.WinForms.Guna2Panel();
            this.txtalasan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtptanggal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtjumlah = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbbarang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnsimpan = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cardGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.picGrid = new FontAwesome.Sharp.IconPictureBox();
            this.lblGrid = new System.Windows.Forms.Label();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idkeluarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahkeluarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_barangkeluarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_pkkDataSet = new Stocky.db_pkkDataSet();
            this.tb_barangkeluarTableAdapter = new Stocky.db_pkkDataSetTableAdapters.tb_barangkeluarTableAdapter();
            this.tableAdapterManager = new Stocky.db_pkkDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.cardForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtjumlah)).BeginInit();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_barangkeluarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_pkkDataSet)).BeginInit();
            this.SuspendLayout();
            //
            // picHeader
            //
            this.picHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.picHeader.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.picHeader.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.picHeader.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picHeader.IconSize = 30;
            this.picHeader.Location = new System.Drawing.Point(20, 14);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(34, 34);
            this.picHeader.TabIndex = 12;
            this.picHeader.TabStop = false;
            //
            // lbljudul
            //
            this.lbljudul.AutoSize = true;
            this.lbljudul.BackColor = System.Drawing.Color.Transparent;
            this.lbljudul.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbljudul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lbljudul.Location = new System.Drawing.Point(58, 10);
            this.lbljudul.Name = "lbljudul";
            this.lbljudul.Size = new System.Drawing.Size(179, 35);
            this.lbljudul.TabIndex = 9;
            this.lbljudul.Text = "Barang Keluar";
            //
            // lblSub
            //
            this.lblSub.AutoSize = true;
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSub.Location = new System.Drawing.Point(60, 42);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(286, 20);
            this.lblSub.TabIndex = 13;
            this.lblSub.Text = "Catat stok barang yang keluar / terjual";
            //
            // sepHeader
            //
            this.sepHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.sepHeader.Location = new System.Drawing.Point(20, 66);
            this.sepHeader.Name = "sepHeader";
            this.sepHeader.Size = new System.Drawing.Size(884, 10);
            this.sepHeader.TabIndex = 14;
            //
            // cardForm
            //
            this.cardForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cardForm.BorderRadius = 14;
            this.cardForm.BorderThickness = 1;
            this.cardForm.Controls.Add(this.txtalasan);
            this.cardForm.Controls.Add(this.label4);
            this.cardForm.Controls.Add(this.dtptanggal);
            this.cardForm.Controls.Add(this.txtjumlah);
            this.cardForm.Controls.Add(this.cbbarang);
            this.cardForm.Controls.Add(this.btnsimpan);
            this.cardForm.Controls.Add(this.label3);
            this.cardForm.Controls.Add(this.label2);
            this.cardForm.Controls.Add(this.label1);
            this.cardForm.FillColor = System.Drawing.Color.White;
            this.cardForm.Location = new System.Drawing.Point(20, 82);
            this.cardForm.Name = "cardForm";
            this.cardForm.ShadowDecoration.Depth = 12;
            this.cardForm.ShadowDecoration.Enabled = false;
            this.cardForm.Size = new System.Drawing.Size(884, 122);
            this.cardForm.TabIndex = 15;
            //
            // txtalasan
            //
            this.txtalasan.BorderRadius = 8;
            this.txtalasan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtalasan.DefaultText = "";
            this.txtalasan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtalasan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtalasan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtalasan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtalasan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtalasan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtalasan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtalasan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtalasan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtalasan.Location = new System.Drawing.Point(486, 46);
            this.txtalasan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtalasan.Name = "txtalasan";
            this.txtalasan.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtalasan.PlaceholderText = "Contoh: Terjual / Rusak";
            this.txtalasan.SelectedText = "";
            this.txtalasan.Size = new System.Drawing.Size(150, 36);
            this.txtalasan.TabIndex = 10;
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(482, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alasan";
            //
            // dtptanggal
            //
            this.dtptanggal.BorderRadius = 8;
            this.dtptanggal.Checked = true;
            this.dtptanggal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dtptanggal.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtptanggal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtptanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dtptanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptanggal.Location = new System.Drawing.Point(656, 46);
            this.dtptanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtptanggal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtptanggal.Name = "dtptanggal";
            this.dtptanggal.Size = new System.Drawing.Size(204, 36);
            this.dtptanggal.TabIndex = 4;
            this.dtptanggal.Value = new System.DateTime(2026, 9, 23, 0, 0, 0, 0);
            //
            // txtjumlah
            //
            this.txtjumlah.BackColor = System.Drawing.Color.Transparent;
            this.txtjumlah.BorderRadius = 8;
            this.txtjumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtjumlah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtjumlah.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtjumlah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtjumlah.Location = new System.Drawing.Point(372, 46);
            this.txtjumlah.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtjumlah.Name = "txtjumlah";
            this.txtjumlah.Size = new System.Drawing.Size(94, 36);
            this.txtjumlah.TabIndex = 3;
            this.txtjumlah.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtjumlah.UpDownButtonForeColor = System.Drawing.Color.White;
            //
            // cbbarang
            //
            this.cbbarang.BackColor = System.Drawing.Color.Transparent;
            this.cbbarang.BorderRadius = 8;
            this.cbbarang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cbbarang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbarang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbarang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cbbarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cbbarang.ItemHeight = 30;
            this.cbbarang.Location = new System.Drawing.Point(184, 46);
            this.cbbarang.Name = "cbbarang";
            this.cbbarang.Size = new System.Drawing.Size(168, 36);
            this.cbbarang.TabIndex = 1;
            //
            // btnsimpan
            //
            this.btnsimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnsimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsimpan.FlatAppearance.BorderSize = 0;
            this.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsimpan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnsimpan.ForeColor = System.Drawing.Color.White;
            this.btnsimpan.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnsimpan.IconColor = System.Drawing.Color.White;
            this.btnsimpan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsimpan.IconSize = 18;
            this.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsimpan.Location = new System.Drawing.Point(24, 46);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnsimpan.Size = new System.Drawing.Size(134, 36);
            this.btnsimpan.TabIndex = 2;
            this.btnsimpan.Text = "  Simpan";
            this.btnsimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(652, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tanggal";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(368, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jumlah";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(180, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nama Barang";
            //
            // cardGrid
            //
            this.cardGrid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cardGrid.BorderRadius = 14;
            this.cardGrid.BorderThickness = 1;
            this.cardGrid.Controls.Add(this.picGrid);
            this.cardGrid.Controls.Add(this.lblGrid);
            this.cardGrid.Controls.Add(this.dataGridView1);
            this.cardGrid.FillColor = System.Drawing.Color.White;
            this.cardGrid.Location = new System.Drawing.Point(20, 214);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.ShadowDecoration.Depth = 12;
            this.cardGrid.ShadowDecoration.Enabled = false;
            this.cardGrid.Size = new System.Drawing.Size(884, 330);
            this.cardGrid.TabIndex = 16;
            //
            // picGrid
            //
            this.picGrid.BackColor = System.Drawing.Color.White;
            this.picGrid.IconChar = FontAwesome.Sharp.IconChar.History;
            this.picGrid.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.picGrid.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picGrid.IconSize = 20;
            this.picGrid.Location = new System.Drawing.Point(18, 12);
            this.picGrid.Name = "picGrid";
            this.picGrid.Size = new System.Drawing.Size(24, 24);
            this.picGrid.TabIndex = 2;
            this.picGrid.TabStop = false;
            //
            // lblGrid
            //
            this.lblGrid.AutoSize = true;
            this.lblGrid.BackColor = System.Drawing.Color.Transparent;
            this.lblGrid.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblGrid.Location = new System.Drawing.Point(46, 12);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(207, 25);
            this.lblGrid.TabIndex = 1;
            this.lblGrid.Text = "Riwayat Barang Keluar";
            //
            // dataGridView1
            //
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 36;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkeluarDataGridViewTextBoxColumn,
            this.idbarangDataGridViewTextBoxColumn,
            this.jumlahkeluarDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tb_barangkeluarBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dataGridView1.Location = new System.Drawing.Point(14, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(856, 272);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 36;
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 28;
            //
            // idkeluarDataGridViewTextBoxColumn
            //
            this.idkeluarDataGridViewTextBoxColumn.DataPropertyName = "id_keluar";
            this.idkeluarDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idkeluarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idkeluarDataGridViewTextBoxColumn.Name = "idkeluarDataGridViewTextBoxColumn";
            this.idkeluarDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // idbarangDataGridViewTextBoxColumn
            //
            this.idbarangDataGridViewTextBoxColumn.DataPropertyName = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.HeaderText = "ID Barang";
            this.idbarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbarangDataGridViewTextBoxColumn.Name = "idbarangDataGridViewTextBoxColumn";
            this.idbarangDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // jumlahkeluarDataGridViewTextBoxColumn
            //
            this.jumlahkeluarDataGridViewTextBoxColumn.DataPropertyName = "jumlah_keluar";
            this.jumlahkeluarDataGridViewTextBoxColumn.HeaderText = "Jumlah Keluar";
            this.jumlahkeluarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahkeluarDataGridViewTextBoxColumn.Name = "jumlahkeluarDataGridViewTextBoxColumn";
            this.jumlahkeluarDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // tanggalDataGridViewTextBoxColumn
            //
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            this.tanggalDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // tb_barangkeluarBindingSource
            //
            this.tb_barangkeluarBindingSource.DataMember = "tb_barangkeluar";
            this.tb_barangkeluarBindingSource.DataSource = this.db_pkkDataSet;
            //
            // db_pkkDataSet
            //
            this.db_pkkDataSet.DataSetName = "db_pkkDataSet";
            this.db_pkkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //
            // tb_barangkeluarTableAdapter
            //
            this.tb_barangkeluarTableAdapter.ClearBeforeFill = true;
            //
            // tableAdapterManager
            //
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_auditlogTableAdapter = null;
            this.tableAdapterManager.tb_barangkeluarTableAdapter = this.tb_barangkeluarTableAdapter;
            this.tableAdapterManager.tb_barangmasukTableAdapter = null;
            this.tableAdapterManager.tb_barangTableAdapter = null;
            this.tableAdapterManager.tb_laporanTableAdapter = null;
            this.tableAdapterManager.tb_userTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Stocky.db_pkkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            //
            // Formbarangkeluar
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(924, 558);
            this.Controls.Add(this.cardGrid);
            this.Controls.Add(this.cardForm);
            this.Controls.Add(this.sepHeader);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lbljudul);
            this.Controls.Add(this.picHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formbarangkeluar";
            this.Text = "Formbarangkeluar";
            this.Load += new System.EventHandler(this.Formbarangkeluar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.cardForm.ResumeLayout(false);
            this.cardForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtjumlah)).EndInit();
            this.cardGrid.ResumeLayout(false);
            this.cardGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_barangkeluarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_pkkDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox picHeader;
        private System.Windows.Forms.Label lblSub;
        private Guna.UI2.WinForms.Guna2Separator sepHeader;
        private Guna.UI2.WinForms.Guna2Panel cardForm;
        private Guna.UI2.WinForms.Guna2Panel cardGrid;
        private System.Windows.Forms.Label lbljudul;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbarang;
        private FontAwesome.Sharp.IconButton btnsimpan;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtjumlah;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtptanggal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private db_pkkDataSet db_pkkDataSet;
        private System.Windows.Forms.BindingSource tb_barangkeluarBindingSource;
        private db_pkkDataSetTableAdapters.tb_barangkeluarTableAdapter tb_barangkeluarTableAdapter;
        private db_pkkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkeluarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahkeluarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2TextBox txtalasan;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox picGrid;
        private System.Windows.Forms.Label lblGrid;
    }
}
