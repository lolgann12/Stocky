namespace Stocky
{
    partial class Formlaporan
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
            this.cardFilter = new Guna.UI2.WinForms.Guna2Panel();
            this.btntampilkan = new FontAwesome.Sharp.IconButton();
            this.dtpsampai = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpdari = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cardGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.picGrid = new FontAwesome.Sharp.IconPictureBox();
            this.lblGrid = new System.Windows.Forms.Label();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cardSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.picKeluar = new FontAwesome.Sharp.IconPictureBox();
            this.picMasuk = new FontAwesome.Sharp.IconPictureBox();
            this.lblkeluar = new System.Windows.Forms.Label();
            this.lblmasuk = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.cardFilter.SuspendLayout();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cardSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeluar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMasuk)).BeginInit();
            this.SuspendLayout();
            //
            // picHeader
            //
            this.picHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.picHeader.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.picHeader.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.picHeader.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picHeader.IconSize = 30;
            this.picHeader.Location = new System.Drawing.Point(20, 14);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(34, 34);
            this.picHeader.TabIndex = 11;
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
            this.lbljudul.Size = new System.Drawing.Size(110, 35);
            this.lbljudul.TabIndex = 10;
            this.lbljudul.Text = "Laporan";
            //
            // lblSub
            //
            this.lblSub.AutoSize = true;
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSub.Location = new System.Drawing.Point(60, 42);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(274, 20);
            this.lblSub.TabIndex = 12;
            this.lblSub.Text = "Rekap pergerakan stok per periode";
            //
            // sepHeader
            //
            this.sepHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.sepHeader.Location = new System.Drawing.Point(20, 66);
            this.sepHeader.Name = "sepHeader";
            this.sepHeader.Size = new System.Drawing.Size(884, 10);
            this.sepHeader.TabIndex = 13;
            //
            // cardFilter
            //
            this.cardFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cardFilter.BorderRadius = 14;
            this.cardFilter.BorderThickness = 1;
            this.cardFilter.Controls.Add(this.btntampilkan);
            this.cardFilter.Controls.Add(this.dtpsampai);
            this.cardFilter.Controls.Add(this.dtpdari);
            this.cardFilter.Controls.Add(this.label2);
            this.cardFilter.Controls.Add(this.label1);
            this.cardFilter.FillColor = System.Drawing.Color.White;
            this.cardFilter.Location = new System.Drawing.Point(20, 82);
            this.cardFilter.Name = "cardFilter";
            this.cardFilter.ShadowDecoration.Depth = 12;
            this.cardFilter.ShadowDecoration.Enabled = false;
            this.cardFilter.Size = new System.Drawing.Size(884, 100);
            this.cardFilter.TabIndex = 14;
            //
            // btntampilkan
            //
            this.btntampilkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btntampilkan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntampilkan.FlatAppearance.BorderSize = 0;
            this.btntampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntampilkan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btntampilkan.ForeColor = System.Drawing.Color.White;
            this.btntampilkan.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btntampilkan.IconColor = System.Drawing.Color.White;
            this.btntampilkan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btntampilkan.IconSize = 18;
            this.btntampilkan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntampilkan.Location = new System.Drawing.Point(700, 38);
            this.btntampilkan.Name = "btntampilkan";
            this.btntampilkan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btntampilkan.Size = new System.Drawing.Size(160, 38);
            this.btntampilkan.TabIndex = 2;
            this.btntampilkan.Text = "  Tampilkan";
            this.btntampilkan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntampilkan.UseVisualStyleBackColor = false;
            this.btntampilkan.Click += new System.EventHandler(this.btntampilkan_Click);
            //
            // dtpsampai
            //
            this.dtpsampai.BorderRadius = 8;
            this.dtpsampai.Checked = true;
            this.dtpsampai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dtpsampai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtpsampai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpsampai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dtpsampai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpsampai.Location = new System.Drawing.Point(400, 40);
            this.dtpsampai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpsampai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpsampai.Name = "dtpsampai";
            this.dtpsampai.Size = new System.Drawing.Size(270, 36);
            this.dtpsampai.TabIndex = 1;
            this.dtpsampai.Value = new System.DateTime(2026, 9, 23, 0, 0, 0, 0);
            //
            // dtpdari
            //
            this.dtpdari.BorderRadius = 8;
            this.dtpdari.Checked = true;
            this.dtpdari.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dtpdari.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtpdari.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpdari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dtpdari.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdari.Location = new System.Drawing.Point(96, 40);
            this.dtpdari.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpdari.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpdari.Name = "dtpdari";
            this.dtpdari.Size = new System.Drawing.Size(270, 36);
            this.dtpdari.TabIndex = 0;
            this.dtpdari.Value = new System.DateTime(2026, 9, 23, 0, 0, 0, 0);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(396, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sampai";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dari :";
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
            this.cardGrid.Location = new System.Drawing.Point(20, 192);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.ShadowDecoration.Depth = 12;
            this.cardGrid.ShadowDecoration.Enabled = false;
            this.cardGrid.Size = new System.Drawing.Size(620, 352);
            this.cardGrid.TabIndex = 15;
            //
            // picGrid
            //
            this.picGrid.BackColor = System.Drawing.Color.White;
            this.picGrid.IconChar = FontAwesome.Sharp.IconChar.TableList;
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
            this.lblGrid.Size = new System.Drawing.Size(144, 25);
            this.lblGrid.TabIndex = 1;
            this.lblGrid.Text = "Hasil Laporan";
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
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(592, 294);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 36;
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            //
            // cardSummary
            //
            this.cardSummary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cardSummary.BorderRadius = 14;
            this.cardSummary.BorderThickness = 1;
            this.cardSummary.Controls.Add(this.picKeluar);
            this.cardSummary.Controls.Add(this.picMasuk);
            this.cardSummary.Controls.Add(this.lblkeluar);
            this.cardSummary.Controls.Add(this.lblmasuk);
            this.cardSummary.Controls.Add(this.label4);
            this.cardSummary.Controls.Add(this.label3);
            this.cardSummary.FillColor = System.Drawing.Color.White;
            this.cardSummary.Location = new System.Drawing.Point(652, 192);
            this.cardSummary.Name = "cardSummary";
            this.cardSummary.ShadowDecoration.Depth = 12;
            this.cardSummary.ShadowDecoration.Enabled = false;
            this.cardSummary.Size = new System.Drawing.Size(252, 352);
            this.cardSummary.TabIndex = 16;
            //
            // picKeluar
            //
            this.picKeluar.BackColor = System.Drawing.Color.White;
            this.picKeluar.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.picKeluar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.picKeluar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picKeluar.IconSize = 26;
            this.picKeluar.Location = new System.Drawing.Point(20, 160);
            this.picKeluar.Name = "picKeluar";
            this.picKeluar.Size = new System.Drawing.Size(30, 30);
            this.picKeluar.TabIndex = 5;
            this.picKeluar.TabStop = false;
            //
            // picMasuk
            //
            this.picMasuk.BackColor = System.Drawing.Color.White;
            this.picMasuk.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
            this.picMasuk.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.picMasuk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picMasuk.IconSize = 26;
            this.picMasuk.Location = new System.Drawing.Point(20, 56);
            this.picMasuk.Name = "picMasuk";
            this.picMasuk.Size = new System.Drawing.Size(30, 30);
            this.picMasuk.TabIndex = 4;
            this.picMasuk.TabStop = false;
            //
            // lblkeluar
            //
            this.lblkeluar.BackColor = System.Drawing.Color.Transparent;
            this.lblkeluar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblkeluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblkeluar.Location = new System.Drawing.Point(58, 196);
            this.lblkeluar.Name = "lblkeluar";
            this.lblkeluar.Size = new System.Drawing.Size(174, 45);
            this.lblkeluar.TabIndex = 9;
            this.lblkeluar.Text = "0";
            //
            // lblmasuk
            //
            this.lblmasuk.BackColor = System.Drawing.Color.Transparent;
            this.lblmasuk.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblmasuk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblmasuk.Location = new System.Drawing.Point(58, 92);
            this.lblmasuk.Name = "lblmasuk";
            this.lblmasuk.Size = new System.Drawing.Size(174, 45);
            this.lblmasuk.TabIndex = 8;
            this.lblmasuk.Text = "0";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label4.Location = new System.Drawing.Point(58, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Keluar";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label3.Location = new System.Drawing.Point(58, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Masuk";
            //
            // Formlaporan
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(924, 558);
            this.Controls.Add(this.cardSummary);
            this.Controls.Add(this.cardGrid);
            this.Controls.Add(this.cardFilter);
            this.Controls.Add(this.sepHeader);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lbljudul);
            this.Controls.Add(this.picHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formlaporan";
            this.Text = "Formlaporan";
            this.Load += new System.EventHandler(this.Formlaporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.cardFilter.ResumeLayout(false);
            this.cardFilter.PerformLayout();
            this.cardGrid.ResumeLayout(false);
            this.cardGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cardSummary.ResumeLayout(false);
            this.cardSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeluar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMasuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox picHeader;
        private System.Windows.Forms.Label lblSub;
        private Guna.UI2.WinForms.Guna2Separator sepHeader;
        private Guna.UI2.WinForms.Guna2Panel cardFilter;
        private Guna.UI2.WinForms.Guna2Panel cardGrid;
        private Guna.UI2.WinForms.Guna2Panel cardSummary;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpdari;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpsampai;
        private FontAwesome.Sharp.IconButton btntampilkan;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblmasuk;
        private System.Windows.Forms.Label lblkeluar;
        private System.Windows.Forms.Label lbljudul;
        private FontAwesome.Sharp.IconPictureBox picGrid;
        private System.Windows.Forms.Label lblGrid;
        private FontAwesome.Sharp.IconPictureBox picMasuk;
        private FontAwesome.Sharp.IconPictureBox picKeluar;
    }
}
