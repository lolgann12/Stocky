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
    public partial class Formbarangkeluar : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Formbarangkeluar()
        {
            InitializeComponent();
            conn = module.Getconn();
        }

        private void LoadData()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT bk.id_keluar, bk.id_barang, b.nama_barang, bk.jumlah_keluar, bk.tanggal, bk.alasan FROM tb_barangkeluar bk INNER JOIN tb_barang b ON bk.id_barang = b.id_barang ORDER BY bk.id_keluar DESC", conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void LoadComboBarang()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT id_barang, nama_barang FROM tb_barang WHERE stok > 0", conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            cbbarang.DataSource = dt;
            cbbarang.DisplayMember = "nama_barang";
            cbbarang.ValueMember = "id_barang";
        }

        private void Formbarangkeluar_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "id_keluar", HeaderText = "ID", DataPropertyName = "id_keluar" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "nama_barang", HeaderText = "Nama Barang", DataPropertyName = "nama_barang" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "jumlah_keluar", HeaderText = "Jumlah Keluar", DataPropertyName = "jumlah_keluar" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "alasan", HeaderText = "Alasan", DataPropertyName = "alasan" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "tanggal", HeaderText = "Tanggal", DataPropertyName = "tanggal" });

            dataGridView1.Columns["nama_barang"].FillWeight = 150;
            dataGridView1.Columns["alasan"].FillWeight = 140;

            LoadComboBarang();
            LoadData();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (cbbarang.SelectedValue == null)
            {
                MessageBox.Show("Pilih barang terlebih dahulu!");
                return;
            }

            if (txtjumlah.Value <= 0)
            {
                MessageBox.Show("Jumlah harus lebih dari 0!");
                return;
            }

            conn.Open();
            cmd = new SqlCommand("SELECT stok FROM tb_barang WHERE id_barang = @id_barang", conn);
            cmd.Parameters.AddWithValue("@id_barang", cbbarang.SelectedValue);
            int stok = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            if (txtjumlah.Value > stok)
            {
                MessageBox.Show("Stok tidak cukup! Stok tersisa: " + stok);
                return;
            }

            try
            {
                conn.Open();

                // INSERT barang keluar
                cmd = new SqlCommand("INSERT INTO tb_barangkeluar (id_barang, jumlah_keluar, tanggal, alasan) VALUES (@id_barang, @jumlah, @tanggal, @alasan)", conn);
                cmd.Parameters.AddWithValue("@id_barang", cbbarang.SelectedValue);
                cmd.Parameters.AddWithValue("@jumlah", txtjumlah.Value);
                cmd.Parameters.AddWithValue("@alasan", txtalasan.Text);
                cmd.Parameters.AddWithValue("@tanggal", dtptanggal.Value);
                cmd.ExecuteNonQuery();

                // UPDATE tabel barang ke barang keluar
                cmd = new SqlCommand("UPDATE tb_barang SET stok = stok - @jumlah WHERE id_barang = @id_barang", conn);
                cmd.Parameters.AddWithValue("@jumlah", txtjumlah.Value);
                cmd.Parameters.AddWithValue("@id_barang", cbbarang.SelectedValue);
                cmd.ExecuteNonQuery();

                // INSERT barang keluar -> laporan
                cmd = new SqlCommand("INSERT INTO tb_laporan (tanggal, jenis, id_barang, jumlah, id_user) " +
                     "VALUES (@tanggal, 'Keluar', @id_barang, @jumlah, @id_user)", conn);
                cmd.Parameters.AddWithValue("@tanggal", dtptanggal.Value);
                cmd.Parameters.AddWithValue("@id_barang", cbbarang.SelectedValue);
                cmd.Parameters.AddWithValue("@jumlah", txtjumlah.Value);
                cmd.Parameters.AddWithValue("@id_user", module.Session.id_user);
                cmd.ExecuteNonQuery();

                conn.Close();

                FormToast.ShowToast("Barang keluar berhasil disimpan!", ToastType.Success);
                Formaudit.SimpanLog("Barang keluar - " + cbbarang.Text + " (" + txtjumlah.Value + ")");
                LoadData();
                LoadComboBarang();

                txtjumlah.Value = 0;
                dtptanggal.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Gagal menyimpan: " + ex.Message);
            }
        }
    }
}
