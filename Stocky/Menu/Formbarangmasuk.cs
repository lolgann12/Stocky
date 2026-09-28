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
    public partial class Formbarangmasuk : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Formbarangmasuk()
        {
            InitializeComponent();
            conn = module.Getconn();
        }

        private void LoadData()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT bm.id_masuk, bm.id_barang, b.nama_barang, bm.jumlah_masuk, bm.tanggal FROM tb_barangmasuk bm INNER JOIN tb_barang b ON bm.id_barang = b.id_barang ORDER BY bm.id_masuk DESC", conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void LoadComboBarang()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT id_barang, nama_barang FROM tb_barang", conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            cbbarang.DataSource = dt;
            cbbarang.DisplayMember = "nama_barang";
            cbbarang.ValueMember = "id_barang";
        }

        private void Formbarangmasuk_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "id_masuk", HeaderText = "ID", DataPropertyName = "id_masuk" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "nama_barang", HeaderText = "Nama Barang", DataPropertyName = "nama_barang" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "jumlah_masuk", HeaderText = "Jumlah Masuk", DataPropertyName = "jumlah_masuk" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "tanggal", HeaderText = "Tanggal", DataPropertyName = "tanggal" });

            dataGridView1.Columns["nama_barang"].FillWeight = 160;
            dataGridView1.Columns["tanggal"].FillWeight = 130;

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

            try
            {
                conn.Open();

                // INSERT barang masuk
                cmd = new SqlCommand("INSERT INTO tb_barangmasuk (id_barang, jumlah_masuk, tanggal) VALUES (@id_barang, @jumlah, @tanggal)", conn);
                cmd.Parameters.AddWithValue("@id_barang", cbbarang.SelectedValue);
                cmd.Parameters.AddWithValue("@jumlah", txtjumlah.Value);
                cmd.Parameters.AddWithValue("@tanggal", dtptanggal.Value);
                cmd.ExecuteNonQuery();

                // UPDATE tabel barang ke barang masuk
                cmd = new SqlCommand("UPDATE tb_barang SET stok = stok + @jumlah WHERE id_barang = @id_barang", conn);
                cmd.Parameters.AddWithValue("@jumlah", txtjumlah.Value);
                cmd.Parameters.AddWithValue("@id_barang", cbbarang.SelectedValue);
                cmd.ExecuteNonQuery();

                // INSERT barang masuk -> laporan
cmd = new SqlCommand("INSERT INTO tb_laporan (tanggal, jenis, id_barang, jumlah, id_user) " +
                     "VALUES (@tanggal, 'Masuk', @id_barang, @jumlah, @id_user)", conn);
                cmd.Parameters.AddWithValue("@tanggal", dtptanggal.Value);
                cmd.Parameters.AddWithValue("@id_barang", cbbarang.SelectedValue);
                cmd.Parameters.AddWithValue("@jumlah", txtjumlah.Value);
                cmd.Parameters.AddWithValue("@id_user", module.Session.id_user);
                cmd.ExecuteNonQuery();

                conn.Close();

                FormToast.ShowToast("Barang masuk berhasil disimpan!", ToastType.Success);
                Formaudit.SimpanLog("Barang masuk - " + cbbarang.Text + " (" + txtjumlah.Value + ")");
                LoadData();

                txtjumlah.Value = 0;
                dtptanggal.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Gagal menyimpan: " + ex.Message);
            }
        }

        private void cbbarang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
