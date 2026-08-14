namespace PurchasingManagementApp
{
    partial class PurchaseListForm
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
            dgvPurchases = new DataGridView();
            btnSil = new Button();
            btnGuncelle = new Button();
            label1 = new Label();
            txtArama = new TextBox();
            label2 = new Label();
            btnAra = new Button();
            label3 = new Label();
            cmbTedarikci = new ComboBox();
            btnExportExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPurchases).BeginInit();
            SuspendLayout();
            // 
            // dgvPurchases
            // 
            dgvPurchases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchases.Location = new Point(22, 128);
            dgvPurchases.Name = "dgvPurchases";
            dgvPurchases.RowHeadersWidth = 51;
            dgvPurchases.Size = new Size(750, 399);
            dgvPurchases.TabIndex = 0;
            dgvPurchases.CellContentClick += dgvPurchases_CellContentClick;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(426, 533);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(146, 29);
            btnSil.TabIndex = 1;
            btnSil.Text = "Seçili Kaydı Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(81, 533);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(154, 29);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Seçili Kaydı Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 3;
            label1.Text = "Satın Alma Kayıtları";
            // 
            // txtArama
            // 
            txtArama.Location = new Point(192, 50);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(125, 27);
            txtArama.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 57);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 5;
            label2.Text = "Kalem No Ara:";
            label2.Click += label2_Click;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(336, 50);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(47, 27);
            btnAra.TabIndex = 6;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 92);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 7;
            label3.Text = "Tedarikçi:";
            label3.Click += label3_Click;
            // 
            // cmbTedarikci
            // 
            cmbTedarikci.FormattingEnabled = true;
            cmbTedarikci.Location = new Point(192, 94);
            cmbTedarikci.Name = "cmbTedarikci";
            cmbTedarikci.Size = new Size(151, 28);
            cmbTedarikci.TabIndex = 8;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(591, 88);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(108, 29);
            btnExportExcel.TabIndex = 9;
            btnExportExcel.Text = "Excel'e Aktar";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += button1_Click;
            // 
            // PurchaseListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 565);
            Controls.Add(btnExportExcel);
            Controls.Add(cmbTedarikci);
            Controls.Add(label3);
            Controls.Add(btnAra);
            Controls.Add(label2);
            Controls.Add(txtArama);
            Controls.Add(label1);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(dgvPurchases);
            Name = "PurchaseListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satın Alma Kayıtları";
            Load += PurchaseListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPurchases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPurchases;
        private Button btnSil;
        private Button btnGuncelle;
        private Label label1;
        private TextBox txtArama;
        private Label label2;
        private Button btnAra;
        private Label label3;
        private ComboBox cmbTedarikci;
        private Button btnExportExcel;
    }
}