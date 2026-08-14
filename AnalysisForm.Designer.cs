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
            lblSupplierAnalysis = new Label();
            Supplier = new DataGridViewTextBoxColumn();
            TotalPurchase = new DataGridViewTextBoxColumn();
            PurchaseCount = new DataGridViewTextBoxColumn();
            AveragePrice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierAnalysis).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(235, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(157, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SATIN ALMA ANALİZİ";
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
            lblTotalPurchase.AutoSize = true;
            lblTotalPurchase.Font = new Font("Segoe UI", 14F);
            lblTotalPurchase.Location = new Point(47, 96);
            lblTotalPurchase.Name = "lblTotalPurchase";
            lblTotalPurchase.Size = new Size(71, 32);
            lblTotalPurchase.TabIndex = 2;
            lblTotalPurchase.Text = "₺0,00";
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
            lblSupplierCount.AutoSize = true;
            lblSupplierCount.Font = new Font("Segoe UI", 14F);
            lblSupplierCount.Location = new Point(438, 96);
            lblSupplierCount.Name = "lblSupplierCount";
            lblSupplierCount.Size = new Size(27, 32);
            lblSupplierCount.TabIndex = 4;
            lblSupplierCount.Text = "0";
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
            lblItemCount.AutoSize = true;
            lblItemCount.Font = new Font("Segoe UI", 14F);
            lblItemCount.Location = new Point(47, 191);
            lblItemCount.Name = "lblItemCount";
            lblItemCount.Size = new Size(27, 32);
            lblItemCount.TabIndex = 6;
            lblItemCount.Text = "0";
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
            lblAveragePrice.AutoSize = true;
            lblAveragePrice.Font = new Font("Segoe UI", 14F);
            lblAveragePrice.Location = new Point(438, 191);
            lblAveragePrice.Name = "lblAveragePrice";
            lblAveragePrice.Size = new Size(71, 32);
            lblAveragePrice.TabIndex = 8;
            lblAveragePrice.Text = "₺0,00";
            // 
            // dgvSupplierAnalysis
            // 
            dgvSupplierAnalysis.AllowUserToAddRows = false;
            dgvSupplierAnalysis.AllowUserToDeleteRows = false;
            dgvSupplierAnalysis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupplierAnalysis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplierAnalysis.Columns.AddRange(new DataGridViewColumn[] { Supplier, TotalPurchase, PurchaseCount, AveragePrice });
            dgvSupplierAnalysis.Location = new Point(75, 280);
            dgvSupplierAnalysis.MultiSelect = false;
            dgvSupplierAnalysis.Name = "dgvSupplierAnalysis";
            dgvSupplierAnalysis.ReadOnly = true;
            dgvSupplierAnalysis.RowHeadersWidth = 51;
            dgvSupplierAnalysis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupplierAnalysis.Size = new Size(546, 221);
            dgvSupplierAnalysis.TabIndex = 9;
            // 
            // lblSupplierAnalysis
            // 
            lblSupplierAnalysis.AutoSize = true;
            lblSupplierAnalysis.Font = new Font("Segoe UI", 12F);
            lblSupplierAnalysis.Location = new Point(88, 239);
            lblSupplierAnalysis.Name = "lblSupplierAnalysis";
            lblSupplierAnalysis.Size = new Size(230, 28);
            lblSupplierAnalysis.TabIndex = 10;
            lblSupplierAnalysis.Text = "TEDARİKÇİ BAZLI ANALİZ";
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
            // AnalysisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 513);
            Controls.Add(lblSupplierAnalysis);
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
        private Label lblSupplierAnalysis;
    }
}