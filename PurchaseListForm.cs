using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace PurchasingManagementApp
{
    public partial class PurchaseListForm : Form
    {
        public PurchaseListForm()
        {
            InitializeComponent();

            dgvPurchases.AutoGenerateColumns = true;

            ApplyModernTheme();
        }
        private void ApplyModernTheme()
        {
            // FORM
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.Font = new Font("Segoe UI", 10F);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1100, 650);
            this.Text = "Satın Alma Kayıtları";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // BAŞLIK
            label1.Text = "Satın Alma Kayıtları";
            label1.Font = new Font(
                "Segoe UI",
                22F,
                FontStyle.Bold);

            label1.ForeColor =
                Color.FromArgb(31, 41, 55);

            label1.Location =
                new Point(40, 30);

            label1.AutoSize = true;

            // ARAMA LABEL
            label2.Text = "Kalem No";
            label2.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            label2.ForeColor =
                Color.FromArgb(75, 85, 99);

            label2.Location =
                new Point(40, 95);

            // ARAMA KUTUSU
            txtArama.Location =
                new Point(40, 120);

            txtArama.Size =
                new Size(230, 32);

            txtArama.Font =
                new Font("Segoe UI", 10F);

            // TEDARİKÇİ LABEL
            label3.Text = "Tedarikçi";
            label3.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            label3.ForeColor =
                Color.FromArgb(75, 85, 99);

            label3.Location =
                new Point(290, 95);

            // TEDARİKÇİ COMBOBOX
            cmbTedarikci.Location =
                new Point(290, 120);

            cmbTedarikci.Size =
                new Size(230, 32);

            cmbTedarikci.Font =
                new Font("Segoe UI", 10F);

            // ARA BUTONU
            StyleModernButton(
                btnAra,
                "Ara",
                Color.FromArgb(37, 99, 235));

            btnAra.Location =
                new Point(540, 120);

            btnAra.Size =
                new Size(100, 32);

            // EXCEL
            StyleModernButton(
                btnExportExcel,
                "Excel'e Aktar",
                Color.FromArgb(15, 118, 110));

            btnExportExcel.Location =
                new Point(870, 120);

            btnExportExcel.Size =
                new Size(170, 38);

            // TABLO
            dgvPurchases.Location =
                new Point(40, 175);

            dgvPurchases.Size =
                new Size(1000, 390);

            dgvPurchases.BackgroundColor =
                Color.White;

            dgvPurchases.BorderStyle =
                BorderStyle.None;

            dgvPurchases.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvPurchases.GridColor =
                Color.FromArgb(229, 231, 235);

            dgvPurchases.RowHeadersVisible =
                false;

            dgvPurchases.AllowUserToAddRows =
                false;

            dgvPurchases.AllowUserToResizeRows =
                false;

            dgvPurchases.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvPurchases.MultiSelect = false;

            dgvPurchases.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvPurchases.RowTemplate.Height = 38;

            dgvPurchases.EnableHeadersVisualStyles =
                false;

            dgvPurchases.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(31, 41, 55);

            dgvPurchases.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvPurchases.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvPurchases.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dgvPurchases.ColumnHeadersHeight = 42;

            dgvPurchases.DefaultCellStyle.Font =
                new Font("Segoe UI", 9F);

            dgvPurchases.DefaultCellStyle.ForeColor =
                Color.FromArgb(31, 41, 55);

            dgvPurchases.DefaultCellStyle.BackColor =
                Color.White;

            dgvPurchases.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(219, 234, 254);

            dgvPurchases.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(30, 64, 175);

            // ALT BUTONLAR
            StyleModernButton(
                btnGuncelle,
                "Düzenle",
                Color.FromArgb(124, 58, 237));

            btnGuncelle.Location =
                new Point(40, 585);

            btnGuncelle.Size =
                new Size(140, 40);

            StyleModernButton(
                btnSil,
                "Sil",
                Color.FromArgb(220, 38, 38));

            btnSil.Location =
                new Point(195, 585);

            btnSil.Size =
                new Size(120, 40);
        }
        private void StyleModernButton(
    Button button,
    string text,
    Color color)
        {
            button.Text = text;

            button.BackColor = color;
            button.ForeColor = Color.White;

            button.FlatStyle =
                FlatStyle.Flat;

            button.FlatAppearance.BorderSize =
                0;

            button.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            button.Cursor =
                Cursors.Hand;

            button.UseVisualStyleBackColor =
                false;

            button.MouseEnter += (sender, e) =>
            {
                button.BackColor =
                    ControlPaint.Dark(color, 0.15f);
            };

            button.MouseLeave += (sender, e) =>
            {
                button.BackColor = color;
            };
        }

        private void PurchaseListForm_Load(object sender, EventArgs e)
        {
            LoadPurchases();
            LoadSuppliers();
        }

        private void LoadPurchases()
        {
            try
            {
                using (var connection =
                    new SqliteConnection(Database.ConnectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            Id,
                            ItemCode AS 'Kalem No',
                            Supplier AS 'Tedarikçi',
                            Quantity AS 'Miktar',
                            UnitPrice AS 'Birim Fiyat',
                            PurchaseDate AS 'Satın Alma Tarihi',
                            TotalPrice AS 'Toplam Tutar'
                        FROM Purchases
                        ORDER BY Id DESC";

                    using (var command =
                        new SqliteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);

                        dgvPurchases.DataSource = null;
                        dgvPurchases.Columns.Clear();

                        dgvPurchases.AutoGenerateColumns = true;
                        dgvPurchases.DataSource = table;

                        if (dgvPurchases.Columns.Contains("Id"))
                        {
                            dgvPurchases.Columns["Id"].Visible = false;
                        }

                        dgvPurchases.AutoSizeColumnsMode =
                            DataGridViewAutoSizeColumnsMode.Fill;
                        dgvPurchases.Columns["Kalem No"].FillWeight = 90;
                        dgvPurchases.Columns["Tedarikçi"].FillWeight = 130;
                        dgvPurchases.Columns["Miktar"].FillWeight = 70;
                        dgvPurchases.Columns["Birim Fiyat"].FillWeight = 100;
                        dgvPurchases.Columns["Satın Alma Tarihi"].FillWeight = 110;
                        dgvPurchases.Columns["Toplam Tutar"].FillWeight = 110;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Satın alma kayıtları yüklenirken hata oluştu.\n\n" +
                    ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                using (var connection =
                    new SqliteConnection(Database.ConnectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT DISTINCT Supplier
                        FROM Purchases
                        WHERE Supplier IS NOT NULL
                          AND Supplier <> ''
                        ORDER BY Supplier";

                    using (var command =
                        new SqliteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        cmbTedarikci.Items.Clear();

                        cmbTedarikci.Items.Add("Tüm Tedarikçiler");

                        while (reader.Read())
                        {
                            cmbTedarikci.Items.Add(
                                reader["Supplier"].ToString());
                        }
                    }
                }

                if (cmbTedarikci.Items.Count > 0)
                {
                    cmbTedarikci.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Tedarikçiler yüklenirken hata oluştu.\n\n" +
                    ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvPurchases.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Lütfen silmek istediğiniz kaydı seçin.",
                    "Uyarı");

                return;
            }

            DialogResult result = MessageBox.Show(
                "Seçili kaydı silmek istediğinize emin misiniz?",
                "Kayıt Silme",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            int id = Convert.ToInt32(
                dgvPurchases.SelectedRows[0].Cells["Id"].Value);

            try
            {
                using (var connection =
                    new SqliteConnection(Database.ConnectionString))
                {
                    connection.Open();

                    string query =
                        "DELETE FROM Purchases WHERE Id = @Id";

                    using (var command =
                        new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Kayıt başarıyla silindi.",
                    "Başarılı");

                LoadPurchases();
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Kayıt silinirken hata oluştu.\n\n" +
                    ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvPurchases.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Lütfen güncellemek istediğiniz kaydı seçin.",
                    "Uyarı");

                return;
            }

            DataGridViewRow row =
                dgvPurchases.SelectedRows[0];

            int id = Convert.ToInt32(
                row.Cells["Id"].Value);

            string itemCode =
                row.Cells["Kalem No"].Value?.ToString() ?? "";

            string supplier =
                row.Cells["Tedarikçi"].Value?.ToString() ?? "";

            string quantity =
                row.Cells["Miktar"].Value?.ToString() ?? "";

            string unitPrice =
                row.Cells["Birim Fiyat"].Value?.ToString() ?? "";

            string purchaseDate =
                row.Cells["Satın Alma Tarihi"].Value?.ToString() ?? "";

            PurchaseForm purchaseForm =
                new PurchaseForm();

            purchaseForm.UpdateId = id;

            purchaseForm.txtKalemNo.Text = itemCode;
            purchaseForm.txtTedarikci.Text = supplier;
            purchaseForm.txtMiktar.Text = quantity;
            purchaseForm.txtBirimFiyat.Text = unitPrice;

            if (DateTime.TryParse(
                purchaseDate,
                out DateTime date))
            {
                purchaseForm.dtpTarih.Value = date;
            }

            purchaseForm.ShowDialog();

            LoadPurchases();
            LoadSuppliers();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                string arama = txtArama.Text.Trim();

                string tedarikci =
                    cmbTedarikci.SelectedItem?.ToString();

                using (var connection =
                    new SqliteConnection(Database.ConnectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            Id,
                            ItemCode AS 'Kalem No',
                            Supplier AS 'Tedarikçi',
                            Quantity AS 'Miktar',
                            UnitPrice AS 'Birim Fiyat',
                            PurchaseDate AS 'Satın Alma Tarihi',
                            TotalPrice AS 'Toplam Tutar'
                        FROM Purchases
                        WHERE 1 = 1";

                    if (!string.IsNullOrWhiteSpace(arama))
                    {
                        query +=
                            " AND ItemCode LIKE @Arama";
                    }

                    if (!string.IsNullOrWhiteSpace(tedarikci) &&
                        tedarikci != "Tüm Tedarikçiler")
                    {
                        query +=
                            " AND Supplier = @Tedarikci";
                    }

                    query += " ORDER BY Id DESC";

                    using (var command =
                        new SqliteCommand(query, connection))
                    {
                        if (!string.IsNullOrWhiteSpace(arama))
                        {
                            command.Parameters.AddWithValue(
                                "@Arama",
                                "%" + arama + "%");
                        }

                        if (!string.IsNullOrWhiteSpace(tedarikci) &&
                            tedarikci != "Tüm Tedarikçiler")
                        {
                            command.Parameters.AddWithValue(
                                "@Tedarikci",
                                tedarikci);
                        }

                        using (var reader =
                            command.ExecuteReader())
                        {
                            DataTable table =
                                new DataTable();

                            table.Load(reader);

                            dgvPurchases.DataSource = null;
                            dgvPurchases.Columns.Clear();

                            dgvPurchases.AutoGenerateColumns = true;
                            dgvPurchases.DataSource = table;
                            dgvPurchases.Columns["Miktar"].DefaultCellStyle.Alignment =
                                DataGridViewContentAlignment.MiddleRight;

                            dgvPurchases.Columns["Birim Fiyat"].DefaultCellStyle.Alignment =
                                DataGridViewContentAlignment.MiddleRight;

                            dgvPurchases.Columns["Toplam Tutar"].DefaultCellStyle.Alignment =
                                DataGridViewContentAlignment.MiddleRight;

                            if (dgvPurchases.Columns.Contains("Id"))
                            {
                                dgvPurchases.Columns["Id"].Visible = false;
                            }

                            dgvPurchases.AutoSizeColumnsMode =
                                DataGridViewAutoSizeColumnsMode.Fill;
                            dgvPurchases.Columns["Kalem No"].FillWeight = 90;
                            dgvPurchases.Columns["Tedarikçi"].FillWeight = 130;
                            dgvPurchases.Columns["Miktar"].FillWeight = 70;
                            dgvPurchases.Columns["Birim Fiyat"].FillWeight = 100;
                            dgvPurchases.Columns["Satın Alma Tarihi"].FillWeight = 110;
                            dgvPurchases.Columns["Toplam Tutar"].FillWeight = 110;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Arama sırasında hata oluştu.\n\n" +
                    ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void dgvPurchases_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Excel Dosyasını Kaydet";
                    saveFileDialog.FileName = "SatınAlmaRaporu.xlsx";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                        return;

                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Satın Alma");

                        // Sütun başlıkları
                        for (int column = 0; column < dgvPurchases.Columns.Count; column++)
                        {
                            worksheet.Cell(1, column + 1).Value =
                                dgvPurchases.Columns[column].HeaderText;
                        }

                        // Satın alma kayıtları
                        int excelRow = 2;

                        foreach (DataGridViewRow dataRow in dgvPurchases.Rows)
                        {
                            if (dataRow.IsNewRow)
                                continue;

                            for (int column = 0; column < dgvPurchases.Columns.Count; column++)
                            {
                                object value = dataRow.Cells[column].Value;

                                worksheet.Cell(excelRow, column + 1).Value =
                                    value?.ToString() ?? "";
                            }

                            excelRow++;
                        }

                        // Başlıkları biçimlendir
                        var headerRange = worksheet.Range(
                            1,
                            1,
                            1,
                            dgvPurchases.Columns.Count);

                        headerRange.Style.Font.Bold = true;

                        // Sütun genişliklerini otomatik ayarla
                        worksheet.Columns().AdjustToContents();

                        // Excel dosyasını kaydet
                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show(
                        "Satın alma kayıtları Excel dosyasına başarıyla aktarıldı.",
                        "Başarılı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Excel aktarımı sırasında bir hata oluştu:\n\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}