namespace Stocky
{
    partial class FormToast
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
            this.cardToast = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.picIcon = new FontAwesome.Sharp.IconPictureBox();
            this.animTimer = new System.Windows.Forms.Timer(this.components);
            this.cardToast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // cardToast
            // 
            this.cardToast.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cardToast.BorderRadius = 12;
            this.cardToast.BorderThickness = 1;
            this.cardToast.Controls.Add(this.lblMsg);
            this.cardToast.Controls.Add(this.picIcon);
            this.cardToast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardToast.FillColor = System.Drawing.Color.White;
            this.cardToast.Location = new System.Drawing.Point(0, 0);
            this.cardToast.Name = "cardToast";
            this.cardToast.ShadowDecoration.Depth = 20;
            this.cardToast.Size = new System.Drawing.Size(340, 80);
            this.cardToast.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblMsg.Location = new System.Drawing.Point(56, 8);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(272, 64);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "Berhasil!";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMsg.Click += new System.EventHandler(this.lblMsg_Click);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.White;
            this.picIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.picIcon.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.picIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.picIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picIcon.IconSize = 34;
            this.picIcon.Location = new System.Drawing.Point(14, 24);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(34, 34);
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // animTimer
            // 
            this.animTimer.Interval = 15;
            this.animTimer.Tick += new System.EventHandler(this.animTimer_Tick);
            // 
            // FormToast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 80);
            this.Controls.Add(this.cardToast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormToast";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormToast_FormClosed);
            this.Load += new System.EventHandler(this.FormToast_Load);
            this.cardToast.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel cardToast;
        private System.Windows.Forms.Label lblMsg;
        private FontAwesome.Sharp.IconPictureBox picIcon;
        private System.Windows.Forms.Timer animTimer;
    }
}
