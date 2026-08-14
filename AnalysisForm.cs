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
            LoadAnalysis();
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