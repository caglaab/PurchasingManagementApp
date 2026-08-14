namespace PurchasingManagementApp
{
    partial class AnalysisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblTotalPurchaseTitle = new Label();
            lblTotalPurchase = new Label();
            lblSupplierCountTitle = new Label();
            lblSupplierCount = new Label();
            lblItemCountTitle = new Label();
            lblItemCount = new Label();
            lblAveragePriceTitle = new Label();
            lblAveragePrice = new Label();
            dgvSupplierAnalysis = new DataGridView();
            Supplier = new DataGridViewTextBoxColumn();
            TotalPurchase = new DataGridViewTextBoxColumn();
            PurchaseCount = new DataGridViewTextBoxColumn();
            AveragePrice = new DataGridViewTextBoxColumn();
            formsPlotSupplier = new ScottPlot.WinForms.FormsPlot();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierAnalysis).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTitle.Location = new Point(235, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(308, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SATIN ALMA ANALİZİ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += label1_Click;
            // 
            // lblTotalPurchaseTitle
            // 
            lblTotalPurchaseTitle.AutoSize = true;
            lblTotalPurchaseTitle.Location = new Point(33, 63);
            lblTotalPurchaseTitle.Name = "lblTotalPurchaseTitle";
            lblTotalPurchaseTitle.Size = new Size(153, 20);
            lblTotalPurchaseTitle.TabIndex = 1;
            lblTotalPurchaseTitle.Text = "TOPLAM SATIN ALMA";
            // 
            // lblTotalPurchase
            // 
            lblTotalPurchase.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTotalPurchase.Location = new Point(47, 96);
            lblTotalPurchase.Name = "lblTotalPurchase";
            lblTotalPurchase.Size = new Size(180, 40);
            lblTotalPurchase.TabIndex = 2;
            lblTotalPurchase.Text = "₺0,00";
            lblTotalPurchase.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSupplierCountTitle
            // 
            lblSupplierCountTitle.AutoSize = true;
            lblSupplierCountTitle.Location = new Point(426, 63);
            lblSupplierCountTitle.Name = "lblSupplierCountTitle";
            lblSupplierCountTitle.Size = new Size(140, 20);
            lblSupplierCountTitle.TabIndex = 3;
            lblSupplierCountTitle.Text = "TOPLAM TEDARİKÇİ";
            // 
            // lblSupplierCount
            // 
            lblSupplierCount.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSupplierCount.Location = new Point(438, 96);
            lblSupplierCount.Name = "lblSupplierCount";
            lblSupplierCount.Size = new Size(180, 40);
            lblSupplierCount.TabIndex = 4;
            lblSupplierCount.Text = "0";
            lblSupplierCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblItemCountTitle
            // 
            lblItemCountTitle.AutoSize = true;
            lblItemCountTitle.Location = new Point(33, 151);
            lblItemCountTitle.Name = "lblItemCountTitle";
            lblItemCountTitle.Size = new Size(116, 20);
            lblItemCountTitle.TabIndex = 5;
            lblItemCountTitle.Text = "TOPLAM KALEM";
            // 
            // lblItemCount
            // 
            lblItemCount.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblItemCount.Location = new Point(47, 191);
            lblItemCount.Name = "lblItemCount";
            lblItemCount.Size = new Size(180, 40);
            lblItemCount.TabIndex = 6;
            lblItemCount.Text = "0";
            lblItemCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAveragePriceTitle
            // 
            lblAveragePriceTitle.AutoSize = true;
            lblAveragePriceTitle.Location = new Point(426, 151);
            lblAveragePriceTitle.Name = "lblAveragePriceTitle";
            lblAveragePriceTitle.Size = new Size(167, 20);
            lblAveragePriceTitle.TabIndex = 7;
            lblAveragePriceTitle.Text = "ORTALAMA BİRİM FİYAT";
            // 
            // lblAveragePrice
            // 
            lblAveragePrice.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAveragePrice.Location = new Point(438, 191);
            lblAveragePrice.Name = "lblAveragePrice";
            lblAveragePrice.Size = new Size(180, 40);
            lblAveragePrice.TabIndex = 8;
            lblAveragePrice.Text = "₺0,00";
            lblAveragePrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvSupplierAnalysis
            // 
            dgvSupplierAnalysis.AllowUserToAddRows = false;
            dgvSupplierAnalysis.AllowUserToDeleteRows = false;
            dgvSupplierAnalysis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupplierAnalysis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplierAnalysis.Columns.AddRange(new DataGridViewColumn[] { Supplier, TotalPurchase, PurchaseCount, AveragePrice });
            dgvSupplierAnalysis.Location = new Point(20, 694);
            dgvSupplierAnalysis.MultiSelect = false;
            dgvSupplierAnalysis.Name = "dgvSupplierAnalysis";
            dgvSupplierAnalysis.ReadOnly = true;
            dgvSupplierAnalysis.RowHeadersWidth = 51;
            dgvSupplierAnalysis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupplierAnalysis.Size = new Size(820, 200);
            dgvSupplierAnalysis.TabIndex = 9;
            // 
            // Supplier
            // 
            Supplier.HeaderText = "Tedarikçi";
            Supplier.MinimumWidth = 6;
            Supplier.Name = "Supplier";
            Supplier.ReadOnly = true;
            // 
            // TotalPurchase
            // 
            TotalPurchase.HeaderText = "Toplam Harcama";
            TotalPurchase.MinimumWidth = 6;
            TotalPurchase.Name = "TotalPurchase";
            TotalPurchase.ReadOnly = true;
            // 
            // PurchaseCount
            // 
            PurchaseCount.HeaderText = "Kayıt Sayısı";
            PurchaseCount.MinimumWidth = 6;
            PurchaseCount.Name = "PurchaseCount";
            PurchaseCount.ReadOnly = true;
            // 
            // AveragePrice
            // 
            AveragePrice.HeaderText = "Ortalama Birim Fiyat";
            AveragePrice.MinimumWidth = 6;
            AveragePrice.Name = "AveragePrice";
            AveragePrice.ReadOnly = true;
            // 
            // formsPlotSupplier
            // 
            formsPlotSupplier.Location = new Point(0, 319);
            formsPlotSupplier.Name = "formsPlotSupplier";
            formsPlotSupplier.Size = new Size(820, 300);
            formsPlotSupplier.TabIndex = 11;
            // 
            // AnalysisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 803);
            Controls.Add(formsPlotSupplier);
            Controls.Add(dgvSupplierAnalysis);
            Controls.Add(lblAveragePrice);
            Controls.Add(lblAveragePriceTitle);
            Controls.Add(lblItemCount);
            Controls.Add(lblItemCountTitle);
            Controls.Add(lblSupplierCount);
            Controls.Add(lblSupplierCountTitle);
            Controls.Add(lblTotalPurchase);
            Controls.Add(lblTotalPurchaseTitle);
            Controls.Add(lblTitle);
            Name = "AnalysisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satın Alma Analizi";
            Load += AnalysisForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSupplierAnalysis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTotalPurchaseTitle;
        private Label lblTotalPurchase;
        private Label lblSupplierCountTitle;
        private Label lblSupplierCount;
        private Label lblItemCountTitle;
        private Label lblItemCount;
        private Label lblAveragePriceTitle;
        private Label lblAveragePrice;
        private DataGridView dgvSupplierAnalysis;
        private DataGridViewTextBoxColumn Supplier;
        private DataGridViewTextBoxColumn TotalPurchase;
        private DataGridViewTextBoxColumn PurchaseCount;
        private DataGridViewTextBoxColumn AveragePrice;
        private ScottPlot.WinForms.FormsPlot formsPlotSupplier;
    }
}