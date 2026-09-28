using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Stocky
{
    public partial class Formmenu : Form
    {
        public string roleUser;
        private int navTargetTop;
        private Timer navTimer;
        public Formmenu(string role)
        {
            InitializeComponent();
            this.roleUser = role;
        }

        private void Formmenu_Load(object sender, EventArgs e)
        {
            lblrole.Text = "Selamat Datang, " + roleUser;
            lblTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            if (roleUser == "Staff")
            {
                btnaudit.Visible = false;
                btnbarang.Visible = false;
            }
            else if (roleUser == "Admin")
            {
                btnaudit.Visible = true;
                btnbarang.Visible = true;
            }

            SetActiveButton(btndashboard);

            pnlNav.Top = btndashboard.Top;
            pnlNav.Height = btndashboard.Height;
            navTargetTop = btndashboard.Top;
            navTimer = new Timer();
            navTimer.Interval = 15;
            navTimer.Tick += NavTimer_Tick;

            TampilkanForm(new Formdashboard());

        }

        private void NavTimer_Tick(object sender, EventArgs e)
        {
            int diff = navTargetTop - pnlNav.Top;
            if (diff == 0)
            {
                navTimer.Stop();
                return;
            }
            int step = Math.Max(2, Math.Abs(diff) / 4);
            pnlNav.Top += Math.Sign(diff) * Math.Min(step, Math.Abs(diff));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Apakah Anda Yakin Ingin Keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
               Formlogin login = new Formlogin();
                login.Show();
                this.Hide();
            }
        }

        private void Formmenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SetActiveButton(IconButton active)
        {
            Color normal = Color.FromArgb(31, 42, 68);
            Color highlight = Color.FromArgb(67, 97, 238);
            IconButton[] menus = { btndashboard, btnbarang, btnmasuk, btnkeluar, btnlaporan, btnaudit };
            foreach (var m in menus)
            {
                if (m == null) continue;
                m.BackColor = (m == active) ? highlight : normal;
            }

            // Geser indikator ke tombol aktif (abaikan tombol yang disembunyikan role)
            if (active != null && active.Visible)
            {
                pnlNav.Height = active.Height;
                navTargetTop = active.Top;
                if (navTimer != null && !navTimer.Enabled)
                    navTimer.Start();
            }
        }

        private void TampilkanForm(Form childform)
        {
            panelcontent.Controls.Clear();

            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;

            panelcontent.Controls.Add(childform);
            panelcontent.Tag = childform;
            childform.BringToFront();
            childform.Show();

            // Animasi transisi konten (async agar UI tidak freeze; fallback tampil biasa)
            try
            {
                guna2Transition1.Show(childform, false, Guna.UI2.AnimatorNS.Animation.Transparent);
            }
            catch { }
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            SetActiveButton(btndashboard);
            TampilkanForm(new Formdashboard());
        }

        private void panelcontent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmasuk_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnmasuk);
            TampilkanForm(new Formbarangmasuk());
        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnkeluar);
            TampilkanForm(new Formbarangkeluar());
        }

        private void btnlaporan_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnlaporan);
            TampilkanForm(new Formlaporan());
        }

        private void btnaudit_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnaudit);
            TampilkanForm(new Formaudit());
        }

        private void btnbarang_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnbarang);
            TampilkanForm(new Formbarang());
        }
    }
}
