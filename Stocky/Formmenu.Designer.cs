namespace Stocky
{
    partial class Formmenu
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
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnclose = new FontAwesome.Sharp.IconButton();
            this.btnaudit = new FontAwesome.Sharp.IconButton();
            this.btnlaporan = new FontAwesome.Sharp.IconButton();
            this.btnkeluar = new FontAwesome.Sharp.IconButton();
            this.btnmasuk = new FontAwesome.Sharp.IconButton();
            this.btnbarang = new FontAwesome.Sharp.IconButton();
            this.btndashboard = new FontAwesome.Sharp.IconButton();
            this.lblVersi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBrand = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.picAvatar = new FontAwesome.Sharp.IconPictureBox();
            this.lblrole = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.panelcontent = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrand)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            //
            // panel1
            //
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.btnaudit);
            this.panel1.Controls.Add(this.btnlaporan);
            this.panel1.Controls.Add(this.btnkeluar);
            this.panel1.Controls.Add(this.btnmasuk);
            this.panel1.Controls.Add(this.btnbarang);
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Controls.Add(this.lblVersi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picBrand);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 640);
            this.panel1.TabIndex = 2;
            //
            // btnclose
            //
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnclose.IconColor = System.Drawing.Color.White;
            this.btnclose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclose.IconSize = 22;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(12, 578);
            this.btnclose.Name = "btnclose";
            this.btnclose.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnclose.Size = new System.Drawing.Size(216, 46);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "  Keluar";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.button6_Click);
            //
            // btnaudit
            //
            this.btnaudit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.btnaudit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaudit.FlatAppearance.BorderSize = 0;
            this.btnaudit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnaudit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnaudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaudit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnaudit.ForeColor = System.Drawing.Color.White;
            this.btnaudit.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnaudit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnaudit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnaudit.IconSize = 22;
            this.btnaudit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaudit.Location = new System.Drawing.Point(12, 452);
            this.btnaudit.Name = "btnaudit";
            this.btnaudit.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnaudit.Size = new System.Drawing.Size(216, 46);
            this.btnaudit.TabIndex = 11;
            this.btnaudit.Text = "  Audit Log";
            this.btnaudit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaudit.UseVisualStyleBackColor = false;
            this.btnaudit.Click += new System.EventHandler(this.btnaudit_Click);
            //
            // btnlaporan
            //
            this.btnlaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.btnlaporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlaporan.FlatAppearance.BorderSize = 0;
            this.btnlaporan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnlaporan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnlaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlaporan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnlaporan.ForeColor = System.Drawing.Color.White;
            this.btnlaporan.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnlaporan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnlaporan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlaporan.IconSize = 22;
            this.btnlaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlaporan.Location = new System.Drawing.Point(12, 400);
            this.btnlaporan.Name = "btnlaporan";
            this.btnlaporan.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnlaporan.Size = new System.Drawing.Size(216, 46);
            this.btnlaporan.TabIndex = 9;
            this.btnlaporan.Text = "  Laporan";
            this.btnlaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlaporan.UseVisualStyleBackColor = false;
            this.btnlaporan.Click += new System.EventHandler(this.btnlaporan_Click);
            //
            // btnkeluar
            //
            this.btnkeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.btnkeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkeluar.FlatAppearance.BorderSize = 0;
            this.btnkeluar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnkeluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnkeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkeluar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnkeluar.ForeColor = System.Drawing.Color.White;
            this.btnkeluar.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.btnkeluar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnkeluar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnkeluar.IconSize = 22;
            this.btnkeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkeluar.Location = new System.Drawing.Point(12, 348);
            this.btnkeluar.Name = "btnkeluar";
            this.btnkeluar.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnkeluar.Size = new System.Drawing.Size(216, 46);
            this.btnkeluar.TabIndex = 7;
            this.btnkeluar.Text = "  Barang Keluar";
            this.btnkeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnkeluar.UseVisualStyleBackColor = false;
            this.btnkeluar.Click += new System.EventHandler(this.btnkeluar_Click);
            //
            // btnmasuk
            //
            this.btnmasuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.btnmasuk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmasuk.FlatAppearance.BorderSize = 0;
            this.btnmasuk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnmasuk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnmasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmasuk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnmasuk.ForeColor = System.Drawing.Color.White;
            this.btnmasuk.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
            this.btnmasuk.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.btnmasuk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmasuk.IconSize = 22;
            this.btnmasuk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmasuk.Location = new System.Drawing.Point(12, 296);
            this.btnmasuk.Name = "btnmasuk";
            this.btnmasuk.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnmasuk.Size = new System.Drawing.Size(216, 46);
            this.btnmasuk.TabIndex = 6;
            this.btnmasuk.Text = "  Barang Masuk";
            this.btnmasuk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmasuk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmasuk.UseVisualStyleBackColor = false;
            this.btnmasuk.Click += new System.EventHandler(this.btnmasuk_Click);
            //
            // btnbarang
            //
            this.btnbarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.btnbarang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbarang.FlatAppearance.BorderSize = 0;
            this.btnbarang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnbarang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnbarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbarang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnbarang.ForeColor = System.Drawing.Color.White;
            this.btnbarang.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btnbarang.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnbarang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbarang.IconSize = 22;
            this.btnbarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbarang.Location = new System.Drawing.Point(12, 244);
            this.btnbarang.Name = "btnbarang";
            this.btnbarang.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnbarang.Size = new System.Drawing.Size(216, 46);
            this.btnbarang.TabIndex = 12;
            this.btnbarang.Text = "  Kelola Barang";
            this.btnbarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbarang.UseVisualStyleBackColor = false;
            this.btnbarang.Click += new System.EventHandler(this.btnbarang_Click);
            //
            // btndashboard
            //
            this.btndashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btndashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.IconChar = FontAwesome.Sharp.IconChar.TachometerAlt;
            this.btndashboard.IconColor = System.Drawing.Color.White;
            this.btndashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndashboard.IconSize = 22;
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Location = new System.Drawing.Point(12, 192);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btndashboard.Size = new System.Drawing.Size(216, 46);
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "  Dashboard";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            //
            // lblVersi
            //
            this.lblVersi.AutoSize = true;
            this.lblVersi.BackColor = System.Drawing.Color.Transparent;
            this.lblVersi.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblVersi.Location = new System.Drawing.Point(78, 128);
            this.lblVersi.Name = "lblVersi";
            this.lblVersi.Size = new System.Drawing.Size(84, 19);
            this.lblVersi.TabIndex = 13;
            this.lblVersi.Text = "v2.0 Modern";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Stocky";
            //
            // picBrand
            //
            this.picBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.picBrand.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.picBrand.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.picBrand.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picBrand.IconSize = 40;
            this.picBrand.Location = new System.Drawing.Point(28, 88);
            this.picBrand.Name = "picBrand";
            this.picBrand.Size = new System.Drawing.Size(44, 44);
            this.picBrand.TabIndex = 14;
            this.picBrand.TabStop = false;
            //
            // pnlNav
            //
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 192);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(6, 46);
            this.pnlNav.TabIndex = 15;
            //
            // panel2
            //
            this.panel2.Controls.Add(this.picAvatar);
            this.panel2.Controls.Add(this.lblrole);
            this.panel2.Controls.Add(this.lblTanggal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.FillColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Name = "panel2";
            this.panel2.ShadowDecoration.Enabled = false;
            this.panel2.ShadowDecoration.Depth = 8;
            this.panel2.Size = new System.Drawing.Size(940, 70);
            this.panel2.TabIndex = 3;
            //
            // picAvatar
            //
            this.picAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.picAvatar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.picAvatar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picAvatar.IconSize = 36;
            this.picAvatar.Location = new System.Drawing.Point(884, 16);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(40, 40);
            this.picAvatar.TabIndex = 13;
            this.picAvatar.TabStop = false;
            //
            // lblrole
            //
            this.lblrole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblrole.BackColor = System.Drawing.Color.Transparent;
            this.lblrole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblrole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblrole.Location = new System.Drawing.Point(560, 12);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(300, 25);
            this.lblrole.TabIndex = 11;
            this.lblrole.Text = "Selamat Datang, Admin";
            this.lblrole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblTanggal
            //
            this.lblTanggal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTanggal.BackColor = System.Drawing.Color.Transparent;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTanggal.Location = new System.Drawing.Point(560, 37);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(300, 20);
            this.lblTanggal.TabIndex = 12;
            this.lblTanggal.Text = "-";
            this.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // panelcontent
            //
            this.panelcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelcontent.Location = new System.Drawing.Point(240, 70);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(940, 570);
            this.panelcontent.TabIndex = 4;
            //
            // guna2BorderlessForm1
            //
            this.guna2BorderlessForm1.BorderRadius = 14;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            //
            // guna2AnimateWindow1
            //
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.Interval = 250;
            this.guna2AnimateWindow1.TargetForm = this;
            //
            // guna2Transition1
            //
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.guna2Transition1.MaxAnimationTime = 400;
            //
            // Formmenu
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.panelcontent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocky - Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formmenu_FormClosed);
            this.Load += new System.EventHandler(this.Formmenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrand)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel2;
        private System.Windows.Forms.Label lblrole;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private FontAwesome.Sharp.IconButton btnclose;
        private FontAwesome.Sharp.IconButton btnlaporan;
        private FontAwesome.Sharp.IconButton btnkeluar;
        private FontAwesome.Sharp.IconButton btnmasuk;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btndashboard;
        private FontAwesome.Sharp.IconButton btnbarang;
        private Guna.UI2.WinForms.Guna2Panel panelcontent;
        private FontAwesome.Sharp.IconButton btnaudit;
        private FontAwesome.Sharp.IconPictureBox picBrand;
        private System.Windows.Forms.Label lblVersi;
        private FontAwesome.Sharp.IconPictureBox picAvatar;
        private System.Windows.Forms.Label lblTanggal;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.Panel pnlNav;
    }
}
