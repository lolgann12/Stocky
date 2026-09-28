using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stocky
{
    public partial class Formlaporan : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public Formlaporan()
        {
            InitializeComponent();
            conn = module.Getconn();
        }

        private void Formlaporan_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "id_laporan", HeaderText = "ID", DataPropertyName = "id_laporan" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "tanggal", HeaderText = "Tanggal", DataPropertyName = "tanggal" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "jenis", HeaderText = "Jenis", DataPropertyName = "jenis" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "nama_barang", HeaderText = "Nama Barang", DataPropertyName = "nama_barang" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "jumlah", HeaderText = "Jumlah", DataPropertyName = "jumlah" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "nama_user", HeaderText = "User", DataPropertyName = "nama_user" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "id_user", HeaderText = "ID User", DataPropertyName = "id_user" });

            dataGridView1.Columns["nama_barang"].FillWeight = 150;
            dataGridView1.Columns["tanggal"].FillWeight = 130;

            LoadData(null, null);
        }

        private void LoadData(DateTime? dari, DateTime? sampai)
        {
            conn.Open();

            string sql = "SELECT l.id_laporan, l.tanggal, l.jenis, b.nama_barang, l.jumlah, l.id_user, u.username AS nama_user " +
                         "FROM tb_laporan l INNER JOIN tb_barang b ON l.id_barang = b.id_barang " +
                         "LEFT JOIN tb_user u ON l.id_user = u.id_user ";

            if (dari != null && sampai != null)
            {
                sql += "WHERE l.tanggal BETWEEN @dari AND @sampai ";
            }

            sql += "ORDER BY l.id_laporan DESC ";

            cmd = new SqlCommand(sql, conn);

            if (dari != null && sampai != null)
            {
                cmd.Parameters.AddWithValue("@dari", dari);
                cmd.Parameters.AddWithValue("@sampai", sampai);
            }

            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();
            HitungTotal();
        }

        private void HitungTotal()
        {
            lblmasuk.Text = "0";
            lblkeluar.Text = "0";

            if (dt == null)
                return;

            foreach (DataRow row in dt.Rows)
            {
                if (row["jenis"].ToString() == "Masuk")
                {
                    lblmasuk.Text = (Convert.ToInt32(lblmasuk.Text) + Convert.ToInt32(row["jumlah"])).ToString();
                }
                else if (row["jenis"].ToString() == "Keluar")
                {
                    lblkeluar.Text = (Convert.ToInt32(lblkeluar.Text) + Convert.ToInt32(row["jumlah"])).ToString();
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btntampilkan_Click(object sender, EventArgs e)
        {
            LoadData(dtpdari.Value, dtpsampai.Value);
        }
    }
}
