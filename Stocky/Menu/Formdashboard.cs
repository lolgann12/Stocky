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
    public partial class Formdashboard : Form
    {
        private Timer timerrefresh;

        public Formdashboard()
        {
            InitializeComponent();

            timerrefresh = new Timer();
            timerrefresh.Interval = 5000;
            timerrefresh.Tick += Timerrefresh_Tick;
            this.FormClosed += Formdashboard_FormClosed;
        }

        private void Timerrefresh_Tick(object sender, EventArgs e)
        {
            Refreshdata();
        }

        private void Refreshdata()
        {
            using (SqlConnection conn = module.Getconn())
            {
                conn.Open();

                SqlCommand cmd0 = new SqlCommand("SELECT COUNT(*) FROM tb_barang", conn);
                lbltotalbarang.Text = cmd0.ExecuteScalar().ToString();

                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM tb_barangmasuk", conn);
                lblbarangmasuk.Text = cmd1.ExecuteScalar().ToString();

                SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM tb_barangkeluar", conn);
                lblbarangkeluar.Text = cmd2.ExecuteScalar().ToString();

                SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM tb_barang WHERE stok <= 5", conn);
                lblstokmenipis.Text = cmd3.ExecuteScalar().ToString();
            }

            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            using (SqlConnection conn = module.Getconn())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_barang, kode_barang, nama_barang, kategori, harga_beli, harga_jual, stok, satuan FROM tb_barang", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Formdashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "id_barang", HeaderText = "ID", DataPropertyName = "id_barang" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "kode_barang", HeaderText = "Kode Barang", DataPropertyName = "kode_barang" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "nama_barang", HeaderText = "Nama Barang", DataPropertyName = "nama_barang" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "kategori", HeaderText = "Kategori", DataPropertyName = "kategori" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "harga_beli", HeaderText = "Harga Beli", DataPropertyName = "harga_beli" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "harga_jual", HeaderText = "Harga Jual", DataPropertyName = "harga_jual" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "stok", HeaderText = "Stok", DataPropertyName = "stok" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "satuan", HeaderText = "Satuan", DataPropertyName = "satuan" });

            dataGridView1.Columns["nama_barang"].FillWeight = 160;
            dataGridView1.Columns["kode_barang"].FillWeight = 110;
            dataGridView1.Columns["id_barang"].FillWeight = 60;
            dataGridView1.Columns["stok"].FillWeight = 70;
            dataGridView1.Columns["satuan"].FillWeight = 80;

            Refreshdata();
            timerrefresh.Start();
        }

        private void Formdashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerrefresh.Stop();
            timerrefresh.Dispose();
        }
    }
}
