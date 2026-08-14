using System;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Linq;

namespace PurchasingManagementApp
{
    public partial class AnalysisForm : Form
    {
        private readonly string connectionString = Database.ConnectionString;

        public AnalysisForm()
        {
            InitializeComponent();
            ApplyModernTheme();
            LoadAnalysis();

            
        }

        private void ApplyModernTheme()
        {
            // FORM
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.Font = new Font("Segoe UI", 10F);
            this.ClientSize = new Size(1200, 820);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Satın Alma Analizi";

            // BAŞLIK
            lblTitle.Text = "Satın Alma Analizi";
            lblTitle.Font = new Font(
                "Segoe UI",
                22F,
                FontStyle.Bold);

            lblTitle.ForeColor =
                Color.FromArgb(31, 41, 55);

            lblTitle.Location = new Point(30, 25);
            lblTitle.Size = new Size(500, 45);
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;


            // KPI KARTLARI
            CreateKpiCard(
                lblTotalPurchaseTitle,
                lblTotalPurchase,
                "TOPLAM HARCAMA",
                new Point(30, 90),
                Color.FromArgb(37, 99, 235));

            CreateKpiCard(
                lblSupplierCountTitle,
                lblSupplierCount,
                "TEDARİKÇİLER",
                new Point(320, 90),
                Color.FromArgb(15, 118, 110));

            CreateKpiCard(
                lblItemCountTitle,
                lblItemCount,
                "TOPLAM KALEM",
                new Point(610, 90),
                Color.FromArgb(124, 58, 237));

            CreateKpiCard(
                lblAveragePriceTitle,
                lblAveragePrice,
                "ORT. BİRİM FİYAT",
                new Point(900, 90),
                Color.FromArgb(234, 88, 12));


            // GRAFİK
            formsPlotSupplier.Location =
                new Point(30, 240);

            formsPlotSupplier.Size =
                new Size(700, 330);

            formsPlotSupplier.BackColor =
                Color.White;


            // TABLO
            dgvSupplierAnalysis.Location =
                new Point(760, 240);

            dgvSupplierAnalysis.Size =
                new Size(410, 330);

            dgvSupplierAnalysis.BackgroundColor =
                Color.White;

            dgvSupplierAnalysis.BorderStyle =
                BorderStyle.None;

            dgvSupplierAnalysis.EnableHeadersVisualStyles = false;

            dgvSupplierAnalysis.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(31, 41, 55);

            dgvSupplierAnalysis.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvSupplierAnalysis.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvSupplierAnalysis.ColumnHeadersHeight = 40;

            dgvSupplierAnalysis.DefaultCellStyle.Font =
                new Font("Segoe UI", 9F);

            dgvSupplierAnalysis.DefaultCellStyle.ForeColor =
                Color.FromArgb(55, 65, 81);

            dgvSupplierAnalysis.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(219, 234, 254);

            dgvSupplierAnalysis.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(31, 41, 55);

            dgvSupplierAnalysis.RowTemplate.Height = 35;

            dgvSupplierAnalysis.GridColor =
                Color.FromArgb(229, 231, 235);


            // TABLO BAŞLIĞI GİBİ KULLANILACAK LABEL
            Label chartTitle = new Label();

            chartTitle.Text = "Tedarikçiye Göre Harcama";
            chartTitle.Font =
                new Font("Segoe UI", 12F, FontStyle.Bold);

            chartTitle.ForeColor =
                Color.FromArgb(31, 41, 55);

            chartTitle.Location =
                new Point(30, 210);

            chartTitle.AutoSize = true;

            this.Controls.Add(chartTitle);


            Label tableTitle = new Label();

            tableTitle.Text = "Tedarikçi Özeti";
            tableTitle.Font =
                new Font("Segoe UI", 12F, FontStyle.Bold);

            tableTitle.ForeColor =
                Color.FromArgb(31, 41, 55);

            tableTitle.Location =
                new Point(760, 210);

            tableTitle.AutoSize = true;

            this.Controls.Add(tableTitle);
        }
        private void CreateKpiCard(
    Label titleLabel,
    Label valueLabel,
    string title,
    Point location,
    Color accentColor)
        {
            Panel card = new Panel();

            card.BackColor = Color.White;
            card.Location = location;
            card.Size = new Size(260, 110);

            card.Paint += (sender, e) =>
            {
                using (SolidBrush brush =
                    new SolidBrush(accentColor))
                {
                    e.Graphics.FillRectangle(
                        brush,
                        0,
                        0,
                        5,
                        card.Height);
                }

                using (Pen pen =
                    new Pen(Color.FromArgb(229, 231, 235)))
                {
                    e.Graphics.DrawRectangle(
                        pen,
                        0,
                        0,
                        card.Width - 1,
                        card.Height - 1);
                }
            };

            // Eski label'ları kartın içine taşı
            titleLabel.Parent = card;
            valueLabel.Parent = card;

            titleLabel.Text = title;

            titleLabel.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            titleLabel.ForeColor =
                Color.FromArgb(107, 114, 128);

            titleLabel.Location =
                new Point(20, 18);

            titleLabel.AutoSize = true;


            valueLabel.Font =
                new Font(
                    "Segoe UI",
                    20F,
                    FontStyle.Bold);

            valueLabel.ForeColor =
                accentColor;

            valueLabel.Location =
                new Point(20, 45);

            valueLabel.Size =
                new Size(220, 40);

            valueLabel.TextAlign =
                ContentAlignment.MiddleLeft;

            card.Controls.Add(titleLabel);
            card.Controls.Add(valueLabel);

            this.Controls.Add(card);

            card.BringToFront();
        }
        private void LoadAnalysis()
        {
            try
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    // TOPLAM SATIN ALMA
                    string totalPurchaseQuery =
                        "SELECT COALESCE(SUM(TotalPrice), 0) FROM Purchases";

                    using (var command = new SqliteCommand(
                        totalPurchaseQuery, connection))
                    {
                        decimal totalPurchase =
                            Convert.ToDecimal(command.ExecuteScalar());

                        lblTotalPurchase.Text =
                            totalPurchase.ToString(
                                "C2",
                                new CultureInfo("tr-TR"));
                    }

                    // TOPLAM TEDARİKÇİ
                    string supplierCountQuery =
                        "SELECT COUNT(DISTINCT Supplier) FROM Purchases";

                    using (var command = new SqliteCommand(
                        supplierCountQuery, connection))
                    {
                        int supplierCount =
                            Convert.ToInt32(command.ExecuteScalar());

                        lblSupplierCount.Text =
                            supplierCount.ToString();
                    }

                    // TOPLAM KALEM
                    string itemCountQuery =
                        "SELECT COUNT(DISTINCT ItemCode) FROM Purchases";

                    using (var command = new SqliteCommand(
                        itemCountQuery, connection))
                    {
                        int itemCount =
                            Convert.ToInt32(command.ExecuteScalar());

                        lblItemCount.Text =
                            itemCount.ToString();
                    }

                    // ORTALAMA BİRİM FİYAT
                    string averagePriceQuery =
                        "SELECT COALESCE(AVG(UnitPrice), 0) FROM Purchases";

                    using (var command = new SqliteCommand(
                        averagePriceQuery, connection))
                    {
                        decimal averagePrice =
                            Convert.ToDecimal(command.ExecuteScalar());

                        lblAveragePrice.Text =
                            averagePrice.ToString(
                                "C2",
                                new CultureInfo("tr-TR"));
                    }
                    List<string> supplierNames = new List<string>();
                    List<double> supplierTotals = new List<double>();

                    // TEDARİKÇİ BAZLI ANALİZ
                    string supplierAnalysisQuery = @"
                        SELECT
                            Supplier,
                            SUM(TotalPrice) AS TotalPurchase,
                            COUNT(*) AS PurchaseCount,
                            AVG(UnitPrice) AS AveragePrice
                        FROM Purchases
                        GROUP BY Supplier
                        ORDER BY TotalPurchase DESC";

                    using (var command = new SqliteCommand(
                        supplierAnalysisQuery, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            dgvSupplierAnalysis.Rows.Clear();

                            while (reader.Read())
                            {
                                string supplier =
                                    reader["Supplier"].ToString();

                                decimal totalPurchase =
                                    Convert.ToDecimal(
                                        reader["TotalPurchase"]);

                                int purchaseCount =
                                    Convert.ToInt32(
                                        reader["PurchaseCount"]);

                                decimal averagePrice =
                                    Convert.ToDecimal(
                                        reader["AveragePrice"]);

                                dgvSupplierAnalysis.Rows.Add(
                                    supplier,
                                    totalPurchase.ToString(
                                        "C2",
                                        new CultureInfo("tr-TR")),
                                    purchaseCount,
                                    averagePrice.ToString(
                                        "C2",
                                        new CultureInfo("tr-TR"))
                                );
                                // Grafik için verileri al
                                supplierNames.Add(supplier);
                                supplierTotals.Add(Convert.ToDouble(totalPurchase));
                            }
                        }
                        formsPlotSupplier.Plot.Clear();

                        var bars = formsPlotSupplier.Plot.Add.Bars(supplierTotals.ToArray());



                        formsPlotSupplier.Plot.Title("Tedarikçiye Göre Toplam Satın Alma");
                        formsPlotSupplier.Plot.XLabel("Toplam Satın Alma Tutarı");

                        // Tedarikçi isimlerini eksene bağla
                        formsPlotSupplier.Plot.Axes.Bottom.SetTicks(
                            Enumerable.Range(0, supplierNames.Count)
                                .Select(i => (double)i)
                                .ToArray(),
                            supplierNames.ToArray()
                        );

                        formsPlotSupplier.Plot.Axes.AutoScale();
                        formsPlotSupplier.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Analiz verileri yüklenirken bir hata oluştu.\n\n" +
                    ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Designer tarafından oluşturulan olaylar
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void AnalysisForm_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}