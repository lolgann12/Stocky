namespace Stocky
{
    partial class FormSplash
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
            this.picLogo = new FontAwesome.Sharp.IconPictureBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.progressLoad = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.lblLoad = new System.Windows.Forms.Label();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            //
            // picLogo
            //
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.picLogo.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.picLogo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.picLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picLogo.IconSize = 72;
            this.picLogo.Location = new System.Drawing.Point(210, 48);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(80, 80);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            //
            // lblBrand
            //
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(90, 134);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(320, 60);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "STOCKY";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lblTag
            //
            this.lblTag.BackColor = System.Drawing.Color.Transparent;
            this.lblTag.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTag.Location = new System.Drawing.Point(90, 192);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(320, 26);
            this.lblTag.TabIndex = 2;
            this.lblTag.Text = "Sistem Informasi Stok Barang";
            this.lblTag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // progressLoad
            //
            this.progressLoad.BorderRadius = 6;
            this.progressLoad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.progressLoad.Location = new System.Drawing.Point(60, 248);
            this.progressLoad.Maximum = 100;
            this.progressLoad.Minimum = 0;
            this.progressLoad.Name = "progressLoad";
            this.progressLoad.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.progressLoad.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.progressLoad.Size = new System.Drawing.Size(380, 12);
            this.progressLoad.TabIndex = 3;
            this.progressLoad.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progressLoad.Value = 0;
            //
            // lblLoad
            //
            this.lblLoad.BackColor = System.Drawing.Color.Transparent;
            this.lblLoad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblLoad.Location = new System.Drawing.Point(60, 268);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(380, 22);
            this.lblLoad.TabIndex = 4;
            this.lblLoad.Text = "Memuat aplikasi...";
            this.lblLoad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // timerLoad
            //
            this.timerLoad.Interval = 30;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            //
            // guna2BorderlessForm1
            //
            this.guna2BorderlessForm1.BorderRadius = 18;
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
            // FormSplash
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(500, 330);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.progressLoad);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocky";
            this.Load += new System.EventHandler(this.FormSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox picLogo;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTag;
        private Guna.UI2.WinForms.Guna2ProgressBar progressLoad;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Timer timerLoad;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}
