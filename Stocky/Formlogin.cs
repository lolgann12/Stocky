using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using static Stocky.module;

namespace Stocky
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtuser.Text) || string.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show("Username dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try 
            {

                using (SqlConnection conn = module.Getconn())
                {
                    conn.Open();

                    string query = "SELECT id_user, role FROM tb_user WHERE username = @user AND password = @pass";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", txtuser.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtpass.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            { 
                               string role = reader["role"].ToString();

                                Session.username = txtuser.Text.Trim();
                                Session.role = role;
                                Session.id_user = Convert.ToInt32(reader["id_user"]);

                                MessageBox.Show("Login Berhasil sebagai " + role + "!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Formaudit.SimpanLog("Login berhasil - " + Session.username);

                                Formmenu menu = new Formmenu(role);
                                menu.Show();
                                FormToast.ShowToast("Login berhasil sebagai " + role + "!", ToastType.Success);
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Username atau Password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Formaudit.SimpanLog("Login gagal - " + txtuser.Text.Trim());
                                txtpass.Clear();
                                txtuser.Clear();
                                txtuser.Focus();
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            // Tampilkan placeholder saat kosong, samarkan saat ada isi
            txtpass.PasswordChar = string.IsNullOrEmpty(txtpass.Text) ? '\0' : (char)0x25CF;
        }
    }
}
