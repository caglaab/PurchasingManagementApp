using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using ScottPlot.WinForms;




namespace PurchasingManagementApp
{
    public partial class MainForm : Form
    {
        private Label lblDashboardTotalPurchase;
        private Label lblDashboardSupplierCount;
        private Label lblDashboardItemCount;
        private Label lblDashboardAveragePrice;
        private FormsPlot dashboardSupplierChart;
        // Renk paleti
        private readonly Color SidebarColor =
            Color.FromArgb(15, 23, 42);

        private readonly Color BackgroundColor =
            Color.FromArgb(248, 250, 252);

        private readonly Color CardColor =
            Color.White;

        private readonly Color TextColor =
            Color.FromArgb(15, 23, 42);

        private readonly Color SecondaryTextColor =
            Color.FromArgb(100, 116, 139);

        private readonly Color BorderColor =
            Color.FromArgb(226, 232, 240);

        public MainForm()
        {
            InitializeComponent();

            SetupForm();
            CreateSidebar();
            CreateDashboard();
        }

        private void SetupForm()
        {
            BackColor = BackgroundColor;
            Font = new Font("Segoe UI", 10F);

            StartPosition = FormStartPosition.CenterScreen;

            ClientSize = new Size(1200, 700);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Text = "Purchasing Management";

            lblBaslik.Text = "PURCHASING MANAGEMENT";
            lblBaslik.Font =
                new Font("Segoe UI", 22F, FontStyle.Bold);

            lblBaslik.ForeColor = TextColor;
            lblBaslik.AutoSize = true;

            lblBaslik.Location =
                new Point(260, 38);
        }

        // ----------------------------------------------------
        // SIDEBAR
        // ----------------------------------------------------

        private void CreateSidebar()
        {
            Panel sidebar = new Panel();

            sidebar.Name = "pnlSidebar";
            sidebar.BackColor = SidebarColor;

            sidebar.Location =
                new Point(0, 0);

            sidebar.Size =
                new Size(220, ClientSize.Height);

            sidebar.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left;

            Controls.Add(sidebar);

            // Logo
            Label logo = new Label();

            logo.Text =
                "PURCHASING\nMANAGEMENT";

            logo.ForeColor = Color.White;

            logo.Font =
                new Font(
                    "Segoe UI",
                    14F,
                    FontStyle.Bold);

            logo.Location =
                new Point(25, 30);

            logo.Size =
                new Size(175, 55);

            sidebar.Controls.Add(logo);

            // Menü başlığı
            Label menuTitle = new Label();

            menuTitle.Text = "ANA MENÜ";

            menuTitle.ForeColor =
                Color.FromArgb(148, 163, 184);

            menuTitle.Font =
                new Font(
                    "Segoe UI",
                    8F,
                    FontStyle.Bold);

            menuTitle.Location =
                new Point(25, 115);

            menuTitle.AutoSize = true;

            sidebar.Controls.Add(menuTitle);

            // Ana sayfa
            Button homeButton =
                CreateSidebarButton(
                    "⌂   Ana Sayfa",
                    new Point(15, 145));

            homeButton.BackColor =
                Color.FromArgb(37, 99, 235);

            sidebar.Controls.Add(homeButton);

            // Yeni satın alma
            Button purchaseButton =
                CreateSidebarButton(
                    "＋   Yeni Satın Alma",
                    new Point(15, 200));

            purchaseButton.Click +=
                btnYeniSatinAlma_Click;

            sidebar.Controls.Add(purchaseButton);

            // Kayıtlar
            Button recordsButton =
                CreateSidebarButton(
                    "▣   Satın Alma Kayıtları",
                    new Point(15, 255));

            recordsButton.Click +=
                btnKayitlar_Click;

            sidebar.Controls.Add(recordsButton);

            // Analiz
            Button analysisButton =
                CreateSidebarButton(
                    "▥   Analiz",
                    new Point(15, 310));

            analysisButton.Click +=
                btnAnaliz_Click;

            sidebar.Controls.Add(analysisButton);

            // Çıkış
            Button exitButton =
                CreateSidebarButton(
                    "×   Çıkış",
                    new Point(15, 600));

            exitButton.Click +=
                btnCikis_Click;

            exitButton.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Left;

            sidebar.Controls.Add(exitButton);
        }

        private Button CreateSidebarButton(
            string text,
            Point location)
        {
            Button button = new Button();

            button.Text = text;

            button.Location =
                location;

            button.Size =
                new Size(190, 45);

            button.BackColor =
                SidebarColor;

            button.ForeColor =
                Color.FromArgb(226, 232, 240);

            button.FlatStyle =
                FlatStyle.Flat;

            button.FlatAppearance.BorderSize = 0;

            button.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Regular);

            button.TextAlign =
                ContentAlignment.MiddleLeft;

            button.Padding =
                new Padding(10, 0, 0, 0);

            button.Cursor =
                Cursors.Hand;

            Color normal =
                SidebarColor;

            Color hover =
                Color.FromArgb(30, 41, 59);

            button.MouseEnter +=
                (sender, e) =>
                {
                    if (button.BackColor !=
                        Color.FromArgb(37, 99, 235))
                    {
                        button.BackColor = hover;
                    }
                };

            button.MouseLeave +=
                (sender, e) =>
                {
                    if (button.BackColor !=
                        Color.FromArgb(37, 99, 235))
                    {
                        button.BackColor = normal;
                    }
                };

            return button;
        }

        // ----------------------------------------------------
        // DASHBOARD
        // ----------------------------------------------------

        private void CreateDashboard()
        {
            // Alt başlık
            Label subtitle = new Label();

            subtitle.Text =
                "Satın alma süreçlerinize genel bakış";

            subtitle.Font =
                new Font(
                    "Segoe UI",
                    10F);

            subtitle.ForeColor =
                SecondaryTextColor;

            subtitle.AutoSize = true;

            subtitle.Location =
                new Point(262, 84);

            Controls.Add(subtitle);

            // Ayırıcı çizgi
            Panel divider = new Panel();

            divider.BackColor =
                BorderColor;

            divider.Location =
                new Point(260, 110);

            divider.Size =
                new Size(900, 1);

            Controls.Add(divider);


            // ------------------------------------------------
            // KPI KARTLARI
            // ------------------------------------------------

            CreateKpiCard(
                "TOPLAM HARCAMA",
                "₺0,00",
                "Tüm satın almalar",
                Color.FromArgb(37, 99, 235),
                new Point(260, 140),
                new Size(205, 125));

            CreateKpiCard(
                "TEDARİKÇİLER",
                "0",
                "Kayıtlı tedarikçi",
                Color.FromArgb(15, 118, 110),
                new Point(480, 140),
                new Size(205, 125));

            CreateKpiCard(
                "TOPLAM KALEM",
                "0",
                "Satın alınan kalem",
                Color.FromArgb(124, 58, 237),
                new Point(700, 140),
                new Size(205, 125));

            CreateKpiCard(
                "ORT. BİRİM FİYAT",
                "₺0,00",
                "Ortalama fiyat",
                Color.FromArgb(234, 88, 12),
                new Point(920, 140),
                new Size(205, 125));


            // Verileri yükle
            LoadDashboardKpis();

            // Grafik
            CreateAnalysisChart();
        }

        private void CreateKpiCard(
            string title,
            string value,
            string description,
            Color accentColor,
            Point location,
            Size size)
        {
            Panel card = new Panel();

            card.BackColor =
                CardColor;

            card.Location =
                location;

            card.Size =
                size;

            card.Paint +=
                (sender, e) =>
                {
                    using (Pen pen =
                        new Pen(BorderColor))
                    {
                        e.Graphics.DrawRectangle(
                            pen,
                            0,
                            0,
                            card.Width - 1,
                            card.Height - 1);
                    }

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
                };

            Label titleLabel =
                new Label();

            titleLabel.Text =
                title;

            titleLabel.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            titleLabel.ForeColor =
                SecondaryTextColor;

            titleLabel.Location =
                new Point(22, 18);

            titleLabel.AutoSize = true;

            card.Controls.Add(titleLabel);

            Label valueLabel =
                new Label();

            valueLabel.Text =
                value;
            if (title == "TOPLAM HARCAMA")
                lblDashboardTotalPurchase = valueLabel;

            else if (title == "TEDARİKÇİLER")
                lblDashboardSupplierCount = valueLabel;

            else if (title == "TOPLAM KALEM")
                lblDashboardItemCount = valueLabel;
            else if (title == "ORT. BİRİM FİYAT")
                lblDashboardAveragePrice = valueLabel;

            valueLabel.Font =
                new Font(
                    "Segoe UI",
                    20F,
                    FontStyle.Bold);

            valueLabel.ForeColor =
                TextColor;

            valueLabel.Location =
                new Point(22, 42);

            valueLabel.AutoSize = true;

            card.Controls.Add(valueLabel);

            Label descriptionLabel =
                new Label();

            descriptionLabel.Text =
                description;

            descriptionLabel.Font =
                new Font(
                    "Segoe UI",
                    8.5F);

            descriptionLabel.ForeColor =
                SecondaryTextColor;

            descriptionLabel.Location =
                new Point(22, 91);

            descriptionLabel.AutoSize = true;

            card.Controls.Add(descriptionLabel);

            Controls.Add(card);
        }
        private void LoadDashboardKpis()
        {
            try
            {
                using (var connection =
                    new SqliteConnection(Database.ConnectionString))
                {
                    connection.Open();

                    // TOPLAM HARCAMA
                    string totalPurchaseQuery =
                        "SELECT COALESCE(SUM(TotalPrice), 0) FROM Purchases";

                    using (var command =
                        new SqliteCommand(
                            totalPurchaseQuery,
                            connection))
                    {
                        decimal totalPurchase =
                            Convert.ToDecimal(
                                command.ExecuteScalar());

                        lblDashboardTotalPurchase.Text =
                            totalPurchase.ToString(
                                "C2",
                                new CultureInfo("tr-TR"));
                    }


                    // TEDARİKÇİ SAYISI
                    string supplierCountQuery =
                        "SELECT COUNT(DISTINCT Supplier) FROM Purchases";

                    using (var command =
                        new SqliteCommand(
                            supplierCountQuery,
                            connection))
                    {
                        int supplierCount =
                            Convert.ToInt32(
                                command.ExecuteScalar());

                        lblDashboardSupplierCount.Text =
                            supplierCount.ToString();
                    }


                    // TOPLAM KALEM
                    string itemCountQuery =
                        "SELECT COUNT(DISTINCT ItemCode) FROM Purchases";

                    using (var command =
                        new SqliteCommand(
                            itemCountQuery,
                            connection))
                    {
                        int itemCount =
                            Convert.ToInt32(
                                command.ExecuteScalar());

                        lblDashboardItemCount.Text =
                            itemCount.ToString();
                    }


                    // ORTALAMA BİRİM FİYAT
                    string averagePriceQuery =
                        "SELECT COALESCE(AVG(UnitPrice), 0) FROM Purchases";

                    using (var command =
                        new SqliteCommand(
                            averagePriceQuery,
                            connection))
                    {
                        decimal averagePrice =
                            Convert.ToDecimal(
                                command.ExecuteScalar());

                        lblDashboardAveragePrice.Text =
                            averagePrice.ToString(
                                "C2",
                                new CultureInfo("tr-TR"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Dashboard verileri yüklenirken bir hata oluştu.\n\n" +
                    ex.Message,
                    "Dashboard Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void CreateAnalysisChart()
        {
            Panel analysisPanel = new Panel();

            analysisPanel.BackColor =
                CardColor;

            analysisPanel.Location =
                new Point(260, 290);

            analysisPanel.Size =
                new Size(860, 330);

            analysisPanel.Paint +=
                (sender, e) =>
                {
                    using (Pen pen =
                        new Pen(BorderColor))
                    {
                        e.Graphics.DrawRectangle(
                            pen,
                            0,
                            0,
                            analysisPanel.Width - 1,
                            analysisPanel.Height - 1);
                    }
                };

            Label title =
                new Label();

            title.Text =
                "SATIN ALMA ANALİZİ";

            title.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            title.ForeColor =
                TextColor;

            title.Location =
                new Point(25, 18);

            title.AutoSize = true;

            analysisPanel.Controls.Add(title);

            Label subtitle =
                new Label();

            subtitle.Text =
                "Toplam satın alma tutarının tedarikçilere göre dağılımı";

            subtitle.Font =
                new Font(
                    "Segoe UI",
                    9F);

            subtitle.ForeColor =
                SecondaryTextColor;

            subtitle.Location =
                new Point(25, 45);

            subtitle.AutoSize = true;

            analysisPanel.Controls.Add(subtitle);

            dashboardSupplierChart =
                new FormsPlot();

            dashboardSupplierChart.Location =
                new Point(20, 75);

            dashboardSupplierChart.Size =
                new Size(820, 235);

            dashboardSupplierChart.BackColor =
                Color.White;

            analysisPanel.Controls.Add(dashboardSupplierChart);

            Controls.Add(analysisPanel);

            LoadSupplierChart(dashboardSupplierChart);
        }
        private void LoadSupplierChart(FormsPlot chart)
        {
            try
            {
                List<string> supplierNames =
                    new List<string>();

                List<double> supplierTotals =
                    new List<double>();

                using (var connection =
                    new SqliteConnection(Database.ConnectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT
                    Supplier,
                    SUM(TotalPrice) AS TotalPurchase
                FROM Purchases
                GROUP BY Supplier
                ORDER BY TotalPurchase DESC";

                    using (var command =
                        new SqliteCommand(
                            query,
                            connection))
                    {
                        using (var reader =
                            command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                supplierNames.Add(
                                    reader["Supplier"].ToString());

                                supplierTotals.Add(
                                    Convert.ToDouble(
                                        reader["TotalPurchase"]));
                            }
                        }
                    }
                }

                chart.Plot.Clear();

                chart.Plot.Add.Bars(
                    supplierTotals.ToArray());

                

                chart.Plot.Axes.Bottom.SetTicks(
                    Enumerable.Range(
                        0,
                        supplierNames.Count)
                        .Select(i => (double)i)
                        .ToArray(),
                    supplierNames.ToArray());

                chart.Plot.Axes.AutoScale();

                chart.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Grafik yüklenirken bir hata oluştu.\n\n" +
                    ex.Message,
                    "Grafik Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------------------
        // FORM EVENTS
        // ----------------------------------------------------

        private void btnYeniSatinAlma_Click(
            object sender,
            EventArgs e)
        {
            PurchaseForm purchaseForm =
                new PurchaseForm();

            purchaseForm.ShowDialog();
            // Kayıt sonrası dashboard KPI'larını yenile
            LoadDashboardKpis();

            // Kayıt sonrası grafiği yenile
            if (dashboardSupplierChart != null)
            {
                LoadSupplierChart(dashboardSupplierChart);
            }
        }

        private void btnKayitlar_Click(
            object sender,
            EventArgs e)
        {
            PurchaseListForm purchaseListForm =
                new PurchaseListForm();

            purchaseListForm.ShowDialog();

            // Kayıtlar ekranından dönünce dashboard'u yenile
            LoadDashboardKpis();

            if (dashboardSupplierChart != null)
            {
                LoadSupplierChart(dashboardSupplierChart);
            }
        }

        private void btnAnaliz_Click(
            object sender,
            EventArgs e)
        {
            AnalysisForm analysisForm =
                new AnalysisForm();

            analysisForm.ShowDialog();
        }

        private void btnCikis_Click(
            object sender,
            EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}