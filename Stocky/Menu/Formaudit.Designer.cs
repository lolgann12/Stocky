namespace Stocky
{
    partial class Formaudit
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picHeader = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.sepHeader = new Guna.UI2.WinForms.Guna2Separator();
            this.cardSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.picSearch = new FontAwesome.Sharp.IconPictureBox();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cardGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idlogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_auditlogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_pkkDataSet = new Stocky.db_pkkDataSet();
            this.tb_auditlogTableAdapter = new Stocky.db_pkkDataSetTableAdapters.tb_auditlogTableAdapter();
            this.tableAdapterManager = new Stocky.db_pkkDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.cardSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.cardGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_auditlogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_pkkDataSet)).BeginInit();
            this.SuspendLayout();
            //
            // picHeader
            //
            this.picHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.picHeader.IconChar = FontAwesome.Sharp.IconChar.History;
            this.picHeader.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.picHeader.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picHeader.IconSize = 30;
            this.picHeader.Location = new System.Drawing.Point(20, 14);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(34, 34);
            this.picHeader.TabIndex = 4;
            this.picHeader.TabStop = false;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(58, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Audit Log";
            //
            // lblSub
            //
            this.lblSub.AutoSize = true;
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSub.Location = new System.Drawing.Point(60, 42);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(250, 20);
            this.lblSub.TabIndex = 5;
            this.lblSub.Text = "Jejak aktivitas seluruh pengguna";
            //
            // sepHeader
            //
            this.sepHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.sepHeader.Location = new System.Drawing.Point(20, 66);
            this.sepHeader.Name = "sepHeader";
            this.sepHeader.Size = new System.Drawing.Size(884, 10);
            this.sepHeader.TabIndex = 6;
            //
            // cardSearch
            //
            this.cardSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cardSearch.BorderRadius = 14;
            this.cardSearch.BorderThickness = 1;
            this.cardSearch.Controls.Add(this.picSearch);
            this.cardSearch.Controls.Add(this.txtsearch);
            this.cardSearch.Controls.Add(this.label2);
            this.cardSearch.FillColor = System.Drawing.Color.White;
            this.cardSearch.Location = new System.Drawing.Point(20, 82);
            this.cardSearch.Name = "cardSearch";
            this.cardSearch.ShadowDecoration.Depth = 12;
            this.cardSearch.ShadowDecoration.Enabled = false;
            this.cardSearch.Size = new System.Drawing.Size(884, 84);
            this.cardSearch.TabIndex = 7;
            //
            // picSearch
            //
            this.picSearch.BackColor = System.Drawing.Color.White;
            this.picSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.picSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.picSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picSearch.IconSize = 20;
            this.picSearch.Location = new System.Drawing.Point(158, 30);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(24, 24);
            this.picSearch.TabIndex = 4;
            this.picSearch.TabStop = false;
            //
            // txtsearch
            //
            this.txtsearch.BorderRadius = 10;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.DefaultText = "";
            this.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.txtsearch.Location = new System.Drawing.Point(190, 22);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtsearch.PlaceholderText = "Ketik untuk mencari username / aktivitas / waktu...";
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(670, 40);
            this.txtsearch.TabIndex = 3;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(24, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pencarian :";
            //
            // cardGrid
            //
            this.cardGrid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cardGrid.BorderRadius = 14;
            this.cardGrid.BorderThickness = 1;
            this.cardGrid.Controls.Add(this.dataGridView1);
            this.cardGrid.FillColor = System.Drawing.Color.White;
            this.cardGrid.Location = new System.Drawing.Point(20, 176);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.ShadowDecoration.Depth = 12;
            this.cardGrid.ShadowDecoration.Enabled = false;
            this.cardGrid.Size = new System.Drawing.Size(884, 368);
            this.cardGrid.TabIndex = 8;
            //
            // dataGridView1
            //
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 36;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlogDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.aktivitasDataGridViewTextBoxColumn,
            this.waktuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tb_auditlogBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dataGridView1.Location = new System.Drawing.Point(14, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(856, 340);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 36;
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            //
            // idlogDataGridViewTextBoxColumn
            //
            this.idlogDataGridViewTextBoxColumn.DataPropertyName = "id_log";
            this.idlogDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idlogDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idlogDataGridViewTextBoxColumn.Name = "idlogDataGridViewTextBoxColumn";
            this.idlogDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // usernameDataGridViewTextBoxColumn
            //
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // aktivitasDataGridViewTextBoxColumn
            //
            this.aktivitasDataGridViewTextBoxColumn.DataPropertyName = "aktivitas";
            this.aktivitasDataGridViewTextBoxColumn.HeaderText = "Aktivitas";
            this.aktivitasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aktivitasDataGridViewTextBoxColumn.Name = "aktivitasDataGridViewTextBoxColumn";
            this.aktivitasDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // waktuDataGridViewTextBoxColumn
            //
            this.waktuDataGridViewTextBoxColumn.DataPropertyName = "waktu";
            this.waktuDataGridViewTextBoxColumn.HeaderText = "Waktu";
            this.waktuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.waktuDataGridViewTextBoxColumn.Name = "waktuDataGridViewTextBoxColumn";
            this.waktuDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // tb_auditlogBindingSource
            //
            this.tb_auditlogBindingSource.DataMember = "tb_auditlog";
            this.tb_auditlogBindingSource.DataSource = this.db_pkkDataSet;
            //
            // db_pkkDataSet
            //
            this.db_pkkDataSet.DataSetName = "db_pkkDataSet";
            this.db_pkkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //
            // tb_auditlogTableAdapter
            //
            this.tb_auditlogTableAdapter.ClearBeforeFill = true;
            //
            // tableAdapterManager
            //
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_auditlogTableAdapter = this.tb_auditlogTableAdapter;
            this.tableAdapterManager.tb_barangkeluarTableAdapter = null;
            this.tableAdapterManager.tb_barangmasukTableAdapter = null;
            this.tableAdapterManager.tb_barangTableAdapter = null;
            this.tableAdapterManager.tb_laporanTableAdapter = null;
            this.tableAdapterManager.tb_userTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Stocky.db_pkkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            //
            // Formaudit
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(924, 558);
            this.Controls.Add(this.cardGrid);
            this.Controls.Add(this.cardSearch);
            this.Controls.Add(this.sepHeader);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formaudit";
            this.Text = "Formaudit";
            this.Load += new System.EventHandler(this.Formaudit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.cardSearch.ResumeLayout(false);
            this.cardSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.cardGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_auditlogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_pkkDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox picHeader;
        private System.Windows.Forms.Label lblSub;
        private Guna.UI2.WinForms.Guna2Separator sepHeader;
        private Guna.UI2.WinForms.Guna2Panel cardSearch;
        private Guna.UI2.WinForms.Guna2Panel cardGrid;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private db_pkkDataSet db_pkkDataSet;
        private System.Windows.Forms.BindingSource tb_auditlogBindingSource;
        private db_pkkDataSetTableAdapters.tb_auditlogTableAdapter tb_auditlogTableAdapter;
        private db_pkkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private FontAwesome.Sharp.IconPictureBox picSearch;
    }
}
