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

namespace Stocky
{
    public partial class Formaudit : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Formaudit()
        {
            InitializeComponent();
            conn = module.Getconn();
        }

        private void LoadData()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT id_log, username, aktivitas, waktu FROM tb_auditlog ORDER BY waktu DESC", conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Formaudit_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "id_log", HeaderText = "ID", DataPropertyName = "id_log" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "username", HeaderText = "Username", DataPropertyName = "username" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "aktivitas", HeaderText = "Aktivitas", DataPropertyName = "aktivitas" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "waktu", HeaderText = "Waktu", DataPropertyName = "waktu" });

            dataGridView1.Columns["aktivitas"].FillWeight = 200;
            dataGridView1.Columns["waktu"].FillWeight = 130;

            LoadData();
        }

        public static void SimpanLog(string aktivitas)
        {
            try
            {
                using (SqlConnection conn = module.Getconn())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tb_auditlog (username, aktivitas, waktu) VALUES (@user, @aktivitas, @waktu)", conn);
                    cmd.Parameters.AddWithValue("@user", module.Session.username);
                    cmd.Parameters.AddWithValue("@aktivitas", aktivitas);
                    cmd.Parameters.AddWithValue("@waktu", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (dt == null) return;

            if(string.IsNullOrEmpty(txtsearch.Text))
            {
                dt.DefaultView.RowFilter = "";
            }
            else
            {
                string cari = txtsearch.Text.Replace("'", "''");
                dt.DefaultView.RowFilter = string.Format(
                    "username LIKE '%{0}%' OR aktivitas LIKE '%{0}%' OR CONVERT(waktu, 'System.String') LIKE '%{0}%'", cari);
            }
        }
    }
}
