using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Stocky
{
    public enum ToastType
    {
        Success,
        Error,
        Info
    }

    /// <summary>
    /// Notifikasi toast geser dari kanan bawah, auto-hilang. Tidak mencuri fokus.
    /// </summary>
    public partial class FormToast : Form
    {
        private static FormToast current;

        private int phase;      // 0 = slide-in, 1 = tunggu, 2 = fade-out
        private int waitTicks;
        private int targetLeft;
        private const int WaitLimit = 170; // ±2,5 detik @15ms

        protected override bool ShowWithoutActivation => true;

        private FormToast(string message, ToastType type)
        {
            InitializeComponent();
            lblMsg.Text = message;

            switch (type)
            {
                case ToastType.Error:
                    picIcon.IconChar = IconChar.ExclamationCircle;
                    picIcon.IconColor = Color.FromArgb(239, 68, 68);
                    break;
                case ToastType.Info:
                    picIcon.IconChar = IconChar.InfoCircle;
                    picIcon.IconColor = Color.FromArgb(67, 97, 238);
                    break;
                default:
                    picIcon.IconChar = IconChar.CheckCircle;
                    picIcon.IconColor = Color.FromArgb(34, 197, 94);
                    break;
            }
        }

        public static void ShowToast(string message, ToastType type = ToastType.Success)
        {
            try
            {
                if (current != null && !current.IsDisposed)
                {
                    current.animTimer.Stop();
                    current.Close();
                    current.Dispose();
                }

                current = new FormToast(message, type);
                var wa = Screen.PrimaryScreen.WorkingArea;
                current.targetLeft = wa.Right - current.Width - 20;
                current.Left = wa.Right; // mulai dari luar layar kanan
                current.Top = wa.Bottom - current.Height - 20;
                current.Show();
            }
            catch { }
        }

        private void FormToast_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            phase = 0;
            waitTicks = 0;
            animTimer.Start();
        }

        private void animTimer_Tick(object sender, EventArgs e)
        {
            if (phase == 0)
            {
                // Geser masuk + fade-in
                this.Left -= 26;
                if (this.Opacity < 1) this.Opacity = Math.Min(1, this.Opacity + 0.12);
                if (this.Left <= targetLeft)
                {
                    this.Left = targetLeft;
                    this.Opacity = 1;
                    phase = 1;
                    waitTicks = 0;
                }
            }
            else if (phase == 1)
            {
                waitTicks++;
                if (waitTicks >= WaitLimit) phase = 2;
            }
            else
            {
                // Fade-out lalu tutup
                this.Opacity -= 0.15;
                if (this.Opacity <= 0)
                {
                    animTimer.Stop();
                    this.Close();
                }
            }
        }

        private void FormToast_FormClosed(object sender, FormClosedEventArgs e)
        {
            animTimer.Stop();
            if (current == this) current = null;
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
