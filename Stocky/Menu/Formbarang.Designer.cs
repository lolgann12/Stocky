namespace Stocky
{
    partial class Formbarang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picHeader = new FontAwesome.Sharp.IconPictureBox();
            this.lbljudul = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.sepHeader = new Guna.UI2.WinForms.Guna2Separator();
            this.cardForm = new Guna.UI2.WinForms.Guna2Panel();
            this.cbkategori = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtsatuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtstok = new Guna.UI2.WinForms.Guna2TextBox();
            this.txthargajual = new Guna.UI2.WinForms.Guna2TextBox();
            this.txthargabeli = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtkode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbersihkan = new FontAwesome.Sharp.IconButton();
            this.btnhapus = new FontAwesome.Sharp.IconButton();
            this.btnupdate = new FontAwesome.Sharp.IconButton();
            this.btnsimpan = new FontAwesome.Sharp.IconButton();
            this.cardGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.picGrid = new FontAwesome.Sharp.IconPictureBox();
            this.lblGrid = new System.Windows.Forms.Label();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.cardForm.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            //
            // picHeader
            //
            this.picHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.picHeader.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.picHeader.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.picHeader.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picHeader.IconSize = 30;
            this.picHeader.Location = new System.Drawing.Point(20, 14);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(34, 34);
            this.picHeader.TabIndex = 30;
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
            this.lbljudul.Size = new System.Drawing.Size(168, 35);
            this.lbljudul.TabIndex = 1;
            this.lbljudul.Text = "Kelola Barang";
            //
            // lblSub
            //
            this.lblSub.AutoSize = true;
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSub.Location = new System.Drawing.Point(60, 42);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(298, 20);
            this.lblSub.TabIndex = 31;
            this.lblSub.Text = "Tambah, ubah, dan hapus data barang";
            //
            // sepHeader
            //
            this.sepHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.sepHeader.Location = new System.Drawing.Point(20, 66);
            this.sepHeader.Name = "sepHeader";
            this.sepHeader.Size = new System.Drawing.Size(884, 10);
            this.sepHeader.TabIndex = 32;
            //
            // cardForm
            //
            this.cardForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cardForm.BorderRadius = 14;
            this.cardForm.BorderThickness = 1;
            this.cardForm.Controls.Add(this.cbkategori);
            this.cardForm.Controls.Add(this.txtsatuan);
            this.cardForm.Controls.Add(this.txtstok);
            this.cardForm.Controls.Add(this.txthargajual);
            this.cardForm.Controls.Add(this.txthargabeli);
            this.cardForm.Controls.Add(this.txtnama);
            this.cardForm.Controls.Add(this.txtkode);
            this.cardForm.Controls.Add(this.label7);
            this.cardForm.Controls.Add(this.label6);
            this.cardForm.Controls.Add(this.label5);
            this.cardForm.Controls.Add(this.label4);
            this.cardForm.Controls.Add(this.label3);
            this.cardForm.Controls.Add(this.label2);
            this.cardForm.Controls.Add(this.label1);
            this.cardForm.Controls.Add(this.btnbersihkan);
            this.cardForm.Controls.Add(this.btnhapus);
            this.cardForm.Controls.Add(this.btnupdate);
            this.cardForm.Controls.Add(this.btnsimpan);
            this.cardForm.FillColor = System.Drawing.Color.White;
            this.cardForm.Location = new System.Drawing.Point(20, 82);
            this.cardForm.Name = "cardForm";
            this.cardForm.ShadowDecoration.Depth = 12;
            this.cardForm.ShadowDecoration.Enabled = false;
            this.cardForm.Size = new System.Drawing.Size(884, 218);
            this.cardForm.TabIndex = 33;
            //
            // cbkategori
            //
            this.cbkategori.BackColor = System.Drawing.Color.Transparent;
            this.cbkategori.BorderRadius = 8;
            this.cbkategori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbkategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.cbkategori.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbkategori.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbkategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cbkategori.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.cbkategori.ItemHeight = 28;
            this.cbkategori.Location = new System.Drawing.Point(448, 42);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(190, 34);
            this.cbkategori.TabIndex = 20;
            //
            // txtsatuan
            //
            this.txtsatuan.BorderRadius = 8;
            this.txtsatuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsatuan.DefaultText = "";
            this.txtsatuan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsatuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsatuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsatuan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsatuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txtsatuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txtsatuan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtsatuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtsatuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txtsatuan.Location = new System.Drawing.Point(668, 122);
            this.txtsatuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsatuan.Name = "txtsatuan";
            this.txtsatuan.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtsatuan.PlaceholderText = "pcs / box";
            this.txtsatuan.SelectedText = "";
            this.txtsatuan.Size = new System.Drawing.Size(190, 34);
            this.txtsatuan.TabIndex = 12;
            //
            // txtstok
            //
            this.txtstok.BorderRadius = 8;
            this.txtstok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstok.DefaultText = "";
            this.txtstok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txtstok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txtstok.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtstok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtstok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txtstok.Location = new System.Drawing.Point(448, 122);
            this.txtstok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtstok.Name = "txtstok";
            this.txtstok.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtstok.PlaceholderText = "0";
            this.txtstok.SelectedText = "";
            this.txtstok.Size = new System.Drawing.Size(190, 34);
            this.txtstok.TabIndex = 15;
            //
            // txthargajual
            //
            this.txthargajual.BorderRadius = 8;
            this.txthargajual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthargajual.DefaultText = "";
            this.txthargajual.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txthargajual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txthargajual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthargajual.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthargajual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txthargajual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txthargajual.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txthargajual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txthargajual.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txthargajual.Location = new System.Drawing.Point(238, 122);
            this.txthargajual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txthargajual.Name = "txthargajual";
            this.txthargajual.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txthargajual.PlaceholderText = "Rp ...";
            this.txthargajual.SelectedText = "";
            this.txthargajual.Size = new System.Drawing.Size(180, 34);
            this.txthargajual.TabIndex = 14;
            //
            // txthargabeli
            //
            this.txthargabeli.BorderRadius = 8;
            this.txthargabeli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthargabeli.DefaultText = "";
            this.txthargabeli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txthargabeli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txthargabeli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthargabeli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthargabeli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txthargabeli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txthargabeli.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txthargabeli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txthargabeli.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txthargabeli.Location = new System.Drawing.Point(28, 122);
            this.txthargabeli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txthargabeli.Name = "txthargabeli";
            this.txthargabeli.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txthargabeli.PlaceholderText = "Rp ...";
            this.txthargabeli.SelectedText = "";
            this.txthargabeli.Size = new System.Drawing.Size(180, 34);
            this.txthargabeli.TabIndex = 13;
            //
            // txtnama
            //
            this.txtnama.BorderRadius = 8;
            this.txtnama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnama.DefaultText = "";
            this.txtnama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txtnama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txtnama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtnama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtnama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txtnama.Location = new System.Drawing.Point(238, 42);
            this.txtnama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnama.Name = "txtnama";
            this.txtnama.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtnama.PlaceholderText = "Nama barang";
            this.txtnama.SelectedText = "";
            this.txtnama.Size = new System.Drawing.Size(180, 34);
            this.txtnama.TabIndex = 10;
            //
            // txtkode
            //
            this.txtkode.BorderRadius = 8;
            this.txtkode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtkode.DefaultText = "";
            this.txtkode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtkode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtkode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtkode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtkode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txtkode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txtkode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtkode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtkode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txtkode.Location = new System.Drawing.Point(28, 42);
            this.txtkode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtkode.Name = "txtkode";
            this.txtkode.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtkode.PlaceholderText = "BRG-001";
            this.txtkode.SelectedText = "";
            this.txtkode.Size = new System.Drawing.Size(180, 34);
            this.txtkode.TabIndex = 9;
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(444, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stok";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(234, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Harga Jual";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(24, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Harga Beli";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(664, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Satuan";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(444, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategori";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(234, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kode Barang";
            //
            // btnbersihkan
            //
            this.btnbersihkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnbersihkan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbersihkan.FlatAppearance.BorderSize = 0;
            this.btnbersihkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbersihkan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnbersihkan.ForeColor = System.Drawing.Color.White;
            this.btnbersihkan.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnbersihkan.IconColor = System.Drawing.Color.White;
            this.btnbersihkan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbersihkan.IconSize = 18;
            this.btnbersihkan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbersihkan.Location = new System.Drawing.Point(448, 168);
            this.btnbersihkan.Name = "btnbersihkan";
            this.btnbersihkan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnbersihkan.Size = new System.Drawing.Size(150, 36);
            this.btnbersihkan.TabIndex = 19;
            this.btnbersihkan.Text = "  Bersihkan";
            this.btnbersihkan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbersihkan.UseVisualStyleBackColor = false;
            this.btnbersihkan.Click += new System.EventHandler(this.btnbersihkan_Click);
            //
            // btnhapus
            //
            this.btnhapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnhapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhapus.FlatAppearance.BorderSize = 0;
            this.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhapus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnhapus.ForeColor = System.Drawing.Color.White;
            this.btnhapus.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnhapus.IconColor = System.Drawing.Color.White;
            this.btnhapus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnhapus.IconSize = 18;
            this.btnhapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhapus.Location = new System.Drawing.Point(310, 168);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnhapus.Size = new System.Drawing.Size(128, 36);
            this.btnhapus.TabIndex = 18;
            this.btnhapus.Text = "  Hapus";
            this.btnhapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            //
            // btnupdate
            //
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnupdate.IconColor = System.Drawing.Color.White;
            this.btnupdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnupdate.IconSize = 18;
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(172, 168);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnupdate.Size = new System.Drawing.Size(128, 36);
            this.btnupdate.TabIndex = 17;
            this.btnupdate.Text = "  Update";
            this.btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            //
            // btnsimpan
            //
            this.btnsimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
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
            this.btnsimpan.Location = new System.Drawing.Point(28, 168);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnsimpan.Size = new System.Drawing.Size(134, 36);
            this.btnsimpan.TabIndex = 16;
            this.btnsimpan.Text = "  Simpan";
            this.btnsimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
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
            this.cardGrid.Location = new System.Drawing.Point(20, 308);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.ShadowDecoration.Depth = 12;
            this.cardGrid.ShadowDecoration.Enabled = false;
            this.cardGrid.Size = new System.Drawing.Size(884, 236);
            this.cardGrid.TabIndex = 34;
            //
            // picGrid
            //
            this.picGrid.BackColor = System.Drawing.Color.White;
            this.picGrid.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.picGrid.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
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
            this.lblGrid.Size = new System.Drawing.Size(122, 25);
            this.lblGrid.TabIndex = 1;
            this.lblGrid.Text = "Daftar Barang";
            //
            // dataGridView1
            //
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 36;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dataGridView1.Location = new System.Drawing.Point(14, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(856, 178);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 36;
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            //
            // Formbarang
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
            this.Name = "Formbarang";
            this.Text = "Formbarang";
            this.Load += new System.EventHandler(this.Formbarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.cardForm.ResumeLayout(false);
            this.cardForm.PerformLayout();
            this.cardGrid.ResumeLayout(false);
            this.cardGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox picHeader;
        private System.Windows.Forms.Label lblSub;
        private Guna.UI2.WinForms.Guna2Separator sepHeader;
        private Guna.UI2.WinForms.Guna2Panel cardForm;
        private Guna.UI2.WinForms.Guna2Panel cardGrid;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.Label lbljudul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtkode;
        private Guna.UI2.WinForms.Guna2TextBox txtnama;
        private Guna.UI2.WinForms.Guna2TextBox txtsatuan;
        private Guna.UI2.WinForms.Guna2TextBox txthargabeli;
        private Guna.UI2.WinForms.Guna2TextBox txthargajual;
        private Guna.UI2.WinForms.Guna2TextBox txtstok;
        private FontAwesome.Sharp.IconButton btnsimpan;
        private FontAwesome.Sharp.IconButton btnupdate;
        private FontAwesome.Sharp.IconButton btnhapus;
        private FontAwesome.Sharp.IconButton btnbersihkan;
        private Guna.UI2.WinForms.Guna2ComboBox cbkategori;
        private FontAwesome.Sharp.IconPictureBox picGrid;
        private System.Windows.Forms.Label lblGrid;
    }
}
