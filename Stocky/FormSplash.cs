using System;
using System.Windows.Forms;

namespace Stocky
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
            progressLoad.Value = 0;
            timerLoad.Start();
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            if (progressLoad.Value < 100)
            {
                progressLoad.Value += 2;
                lblLoad.Text = "Memuat aplikasi... " + progressLoad.Value + "%";
            }
            else
            {
                timerLoad.Stop();
                Formlogin login = new Formlogin();
                login.FormClosed += (s, ev) => this.Close();
                login.Show();
                this.Hide();
            }
        }
    }
}
