using Microsoft.Data.Sqlite;
using System;
using System.Data;
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

                            if (dgvPurchases.Columns.Contains("Id"))
                            {
                                dgvPurchases.Columns["Id"].Visible = false;
                            }

                            dgvPurchases.AutoSizeColumnsMode =
                                DataGridViewAutoSizeColumnsMode.Fill;
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