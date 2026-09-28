using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Guna.UI2.WinForms;

namespace Stocky
{
    /// <summary>
    /// Tema global Stocky: palet warna, font, dan helper styling Guna2 + FontAwesome.
    /// </summary>
    public static class UITheme
    {
        // Palet utama
        public static readonly Color Primary      = Color.FromArgb(67, 97, 238);   // #4361EE
        public static readonly Color PrimaryDark = Color.FromArgb(58, 80, 200);
        public static readonly Color SidebarBg   = Color.FromArgb(31, 42, 68);    // #1F2A44
        public static readonly Color SidebarHover= Color.FromArgb(67, 97, 238);
        public static readonly Color PageBg      = Color.FromArgb(241, 245, 249); // #F1F5F9
        public static readonly Color CardBg      = Color.White;
        public static readonly Color TextDark    = Color.FromArgb(30, 41, 59);
        public static readonly Color TextMuted   = Color.FromArgb(100, 116, 139);
        public static readonly Color Success     = Color.FromArgb(34, 197, 94);
        public static readonly Color Danger      = Color.FromArgb(239, 68, 68);
        public static readonly Color Warning     = Color.FromArgb(245, 158, 11);
        public static readonly Color Info        = Color.FromArgb(6, 182, 212);

        public static Font TitleFont    => new Font("Segoe UI", 14F, FontStyle.Bold);
        public static Font SubtitleFont => new Font("Segoe UI", 9F, FontStyle.Regular);
        public static Font LabelFont    => new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        public static Font ButtonFont   => new Font("Segoe UI", 9.5F, FontStyle.Bold);

        /// <summary>Styling standar untuk Guna2DataGridView agar modern.</summary>
        public static void StyleGrid(Guna2DataGridView grid)
        {
            grid.ThemeStyle.HeaderStyle.BackColor = Primary;
            grid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            grid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grid.ThemeStyle.HeaderStyle.Height = 38;
            grid.ThemeStyle.RowsStyle.Height = 30;
            grid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            grid.ThemeStyle.RowsStyle.SelectionForeColor = TextDark;
            grid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 250, 252);
            grid.ColumnHeadersHeight = 38;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Primary;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            grid.DefaultCellStyle.SelectionForeColor = TextDark;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.FromArgb(226, 232, 240);
            grid.RowHeadersVisible = false;
        }

        /// <summary>Styling standar Guna2TextBox.</summary>
        public static void StyleTextBox(Guna2TextBox tb)
        {
            tb.BorderRadius = 8;
            tb.FocusedState.BorderColor = Primary;
            tb.HoverState.BorderColor = Primary;
            tb.Font = new Font("Segoe UI", 10F);
            tb.ForeColor = TextDark;
        }

        /// <summary>Styling standar Guna2ComboBox.</summary>
        public static void StyleCombo(Guna2ComboBox cb)
        {
            cb.BorderRadius = 8;
            cb.FocusedState.BorderColor = Primary;
            cb.HoverState.BorderColor = Primary;
            cb.Font = new Font("Segoe UI", 10F);
            cb.ForeColor = TextDark;
        }

        /// <summary>Tombol primer (Simpan/Tampilkan/Login).</summary>
        public static void StylePrimaryButton(Guna2Button btn)
        {
            btn.BorderRadius = 8;
            btn.FillColor = Primary;
            btn.HoverState.FillColor = PrimaryDark;
            btn.ForeColor = Color.White;
            btn.Font = ButtonFont;
        }

        /// <summary>Tombol bahaya (Hapus/Keluar).</summary>
        public static void StyleDangerButton(Guna2Button btn)
        {
            btn.BorderRadius = 8;
            btn.FillColor = Danger;
            btn.HoverState.FillColor = Color.FromArgb(220, 38, 38);
            btn.ForeColor = Color.White;
            btn.Font = ButtonFont;
        }

        /// <summary>Tombol menu sidebar berbasis FontAwesome IconButton.</summary>
        public static void StyleMenuButton(IconButton btn, bool active = false)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 97, 238);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(58, 80, 200);
            btn.BackColor = active ? Primary : Color.Transparent;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.IconColor = Color.White;
            btn.IconSize = 22;
            btn.IconFont = IconFont.Auto;
            btn.Padding = new Padding(18, 0, 0, 0);
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
        }

        /// <summary>Kartu statistik dashboard: panel + icon + angka.</summary>
        public static Guna2Panel MakeStatCard(Color accent)
        {
            var p = new Guna2Panel
            {
                FillColor = CardBg,
                BorderRadius = 14,
                ShadowDecoration = { Enabled = true, Depth = 12, Shadow = new Padding(0, 0, 6, 6) },
                BorderColor = Color.FromArgb(226, 232, 240),
                BorderThickness = 1,
                Size = new Size(200, 110)
            };
            // garis aksen kiri via CustomBorderThickness
            p.CustomBorderThickness = new Padding(6, 0, 0, 0);
            p.CustomBorderColor = accent;
            return p;
        }

        public static IconPictureBox MakeIcon(IconChar icon, Color color, int size = 28)
        {
            return new IconPictureBox
            {
                IconChar = icon,
                IconColor = color,
                IconFont = IconFont.Auto,
                IconSize = size,
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.CenterImage
            };
        }
    }
}
