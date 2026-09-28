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

namespace Stocky
{
    public partial class Formbarang : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private int idbarang = 0;

        public Formbarang()
        {
            InitializeComponent();
            conn = module.Getconn();
        }

        private void Formbarang_Load(object sender, EventArgs e)
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

            LoadData();
            LoadComboBarang();
        }

        private void LoadComboBarang()
        {
            cbkategori.Items.Clear();
            cbkategori.Items.Add("Elektronik");
            cbkategori.Items.Add("ATK");
            cbkategori.Items.Add("Furniture");
            cbkategori.Items.Add("Peralatan");
            cbkategori.Items.Add("Sparepart");
        }
        private void LoadData()
        {
            conn.Open();
            da = new SqlDataAdapter("SELECT id_barang, kode_barang, nama_barang, kategori, harga_beli, harga_jual, stok, satuan FROM tb_barang ORDER BY id_barang", conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            idbarang = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_barang"].Value);
            txtkode.Text = dataGridView1.Rows[e.RowIndex].Cells["kode_barang"].Value.ToString();
            txtnama.Text = dataGridView1.Rows[e.RowIndex].Cells["nama_barang"].Value.ToString();
            txthargabeli.Text = dataGridView1.Rows[e.RowIndex].Cells["harga_beli"].Value.ToString();
            txthargajual.Text = dataGridView1.Rows[e.RowIndex].Cells["harga_jual"].Value.ToString();
            txtstok.Text = dataGridView1.Rows[e.RowIndex].Cells["stok"].Value.ToString();
            txtsatuan.Text = dataGridView1.Rows[e.RowIndex].Cells["satuan"].Value.ToString();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            try
            {
                conn.Open();

                // Cek kode duplikat
                cmd = new SqlCommand("SELECT COUNT(*) FROM tb_barang WHERE kode_barang = @kode", conn);
                cmd.Parameters.AddWithValue("@kode", txtkode.Text.Trim());
                int ada = Convert.ToInt32(cmd.ExecuteScalar());

                if (ada > 0)
                {
                    MessageBox.Show("Kode barang sudah ada!", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }

                // INSERT
                cmd = new SqlCommand("INSERT INTO tb_barang (kode_barang, nama_barang, kategori, harga_beli, harga_jual, stok, satuan) " +
                                     "VALUES (@kode, @nama, @kategori, @hb, @hj, @stok, @satuan)", conn);
                cmd.Parameters.AddWithValue("@kode", txtkode.Text.Trim());
                cmd.Parameters.AddWithValue("@nama", txtnama.Text.Trim());
                cmd.Parameters.AddWithValue("@kategori", cbkategori.Text.Trim());
                cmd.Parameters.AddWithValue("@hb", Convert.ToInt32(txthargabeli.Text));
                cmd.Parameters.AddWithValue("@hj", Convert.ToInt32(txthargajual.Text));
                cmd.Parameters.AddWithValue("@stok", Convert.ToInt32(txtstok.Text));
                cmd.Parameters.AddWithValue("@satuan", txtsatuan.Text.Trim());
                cmd.ExecuteNonQuery();

                conn.Close();

                Formaudit.SimpanLog("Barang ditambah - " + txtnama.Text + " (" + txtkode.Text + ")");
                LoadData();
                btnbersihkan_Click(sender, e);
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Gagal menyimpan: " + ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (idbarang == 0)
            {
                MessageBox.Show("Pilih barang di grid dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidasiInput()) return;

            try
            {
                conn.Open();

                // Cek duplikat kode, kecuali id yang lagi diedit
                cmd = new SqlCommand("SELECT COUNT(*) FROM tb_barang WHERE kode_barang = @kode AND id_barang <> @id", conn);
                cmd.Parameters.AddWithValue("@kode", txtkode.Text.Trim());
                cmd.Parameters.AddWithValue("@id", idbarang);
                int ada = Convert.ToInt32(cmd.ExecuteScalar());

                if (ada > 0)
                {
                    MessageBox.Show("Kode barang sudah dipakai barang lain!", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }

                // UPDATE
                cmd = new SqlCommand("UPDATE tb_barang SET kode_barang = @kode, nama_barang = @nama, kategori = @kategori, " +
                                     "harga_beli = @hb, harga_jual = @hj, stok = @stok, satuan = @satuan " +
                                     "WHERE id_barang = @id", conn);
                cmd.Parameters.AddWithValue("@kode", txtkode.Text.Trim());
                cmd.Parameters.AddWithValue("@nama", txtnama.Text.Trim());
                cmd.Parameters.AddWithValue("@kategori", cbkategori.Text.Trim());
                cmd.Parameters.AddWithValue("@hb", Convert.ToInt32(txthargabeli.Text));
                cmd.Parameters.AddWithValue("@hj", Convert.ToInt32(txthargajual.Text));
                cmd.Parameters.AddWithValue("@stok", Convert.ToInt32(txtstok.Text));
                cmd.Parameters.AddWithValue("@satuan", txtsatuan.Text.Trim());
                cmd.Parameters.AddWithValue("@id", idbarang);
                cmd.ExecuteNonQuery();

                conn.Close();

                Formaudit.SimpanLog("Barang diupdate - " + txtnama.Text + " (" + txtkode.Text + ")");
                LoadData();
                btnbersihkan_Click(sender, e);
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Gagal mengupdate: " + ex.Message);
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (idbarang == 0)
            {
                MessageBox.Show("Pilih barang di grid dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult jawab = MessageBox.Show("Yakin mau hapus barang ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (jawab != DialogResult.Yes) return;

            try
            {
                conn.Open();
                cmd = new SqlCommand("DELETE FROM tb_barang WHERE id_barang = @id", conn);
                cmd.Parameters.AddWithValue("@id", idbarang);
                cmd.ExecuteNonQuery();
                conn.Close();

                Formaudit.SimpanLog("Barang dihapus - " + txtnama.Text + " (" + txtkode.Text + ")");
                LoadData();
                btnbersihkan_Click(sender, e);
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Gagal menghapus: " + ex.Message);
            }
        }

        private void btnbersihkan_Click(object sender, EventArgs e)
        {
            txtkode.Clear();
            txtnama.Clear();
            txthargabeli.Clear();
            txthargajual.Clear();
            txtstok.Clear();
            txtsatuan.Clear();
            idbarang = 0;
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtkode.Text) ||
                string.IsNullOrWhiteSpace(txtnama.Text) ||
                string.IsNullOrWhiteSpace(cbkategori.Text) ||
                string.IsNullOrWhiteSpace(txthargabeli.Text) ||
                string.IsNullOrWhiteSpace(txthargajual.Text) ||
                string.IsNullOrWhiteSpace(txtstok.Text) ||
                string.IsNullOrWhiteSpace(txtsatuan.Text))
            {
                MessageBox.Show("Semua field wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txthargabeli.Text, out _) ||
                !int.TryParse(txthargajual.Text, out _) ||
                !int.TryParse(txtstok.Text, out _))
            {
                MessageBox.Show("Harga Beli, Harga Jual, dan Stok harus angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}