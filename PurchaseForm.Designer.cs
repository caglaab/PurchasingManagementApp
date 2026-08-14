namespace PurchasingManagementApp
{
    partial class PurchaseForm
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
            lblKalemNo = new Label();
            lblTedarikci = new Label();
            lblMiktar = new Label();
            lblBirimFiyat = new Label();
            lblTarih = new Label();
            lblToplam = new Label();
            txtKalemNo = new TextBox();
            txtTedarikci = new TextBox();
            txtMiktar = new TextBox();
            txtBirimFiyat = new TextBox();
            dtpTarih = new DateTimePicker();
            txtToplam = new TextBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // lblKalemNo
            // 
            lblKalemNo.AutoSize = true;
            lblKalemNo.Location = new Point(21, 58);
            lblKalemNo.Name = "lblKalemNo";
            lblKalemNo.Size = new Size(78, 20);
            lblKalemNo.TabIndex = 0;
            lblKalemNo.Text = "Kalem No:";
            // 
            // lblTedarikci
            // 
            lblTedarikci.AutoSize = true;
            lblTedarikci.Location = new Point(21, 101);
            lblTedarikci.Name = "lblTedarikci";
            lblTedarikci.Size = new Size(71, 20);
            lblTedarikci.TabIndex = 1;
            lblTedarikci.Text = "Tedarikçi:";
            // 
            // lblMiktar
            // 
            lblMiktar.AutoSize = true;
            lblMiktar.Location = new Point(21, 148);
            lblMiktar.Name = "lblMiktar";
            lblMiktar.Size = new Size(54, 20);
            lblMiktar.TabIndex = 2;
            lblMiktar.Text = "Miktar:";
            // 
            // lblBirimFiyat
            // 
            lblBirimFiyat.AutoSize = true;
            lblBirimFiyat.Location = new Point(21, 205);
            lblBirimFiyat.Name = "lblBirimFiyat";
            lblBirimFiyat.Size = new Size(82, 20);
            lblBirimFiyat.TabIndex = 3;
            lblBirimFiyat.Text = "Birim Fiyat:";
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(21, 259);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(43, 20);
            lblTarih.TabIndex = 4;
            lblTarih.Text = "Tarih:";
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(21, 311);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(100, 20);
            lblToplam.TabIndex = 5;
            lblToplam.Text = "Toplam Tutar:";
            // 
            // txtKalemNo
            // 
            txtKalemNo.Location = new Point(133, 58);
            txtKalemNo.Name = "txtKalemNo";
            txtKalemNo.Size = new Size(125, 27);
            txtKalemNo.TabIndex = 6;
            // 
            // txtTedarikci
            // 
            txtTedarikci.Location = new Point(133, 101);
            txtTedarikci.Name = "txtTedarikci";
            txtTedarikci.Size = new Size(125, 27);
            txtTedarikci.TabIndex = 7;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(133, 148);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(125, 27);
            txtMiktar.TabIndex = 8;
            txtMiktar.TextChanged += txtMiktar_TextChanged;
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Location = new Point(133, 202);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(125, 27);
            txtBirimFiyat.TabIndex = 9;
            txtBirimFiyat.TextChanged += txtBirimFiyat_TextChanged;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(133, 259);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 27);
            dtpTarih.TabIndex = 10;
            // 
            // txtToplam
            // 
            txtToplam.Location = new Point(133, 311);
            txtToplam.Name = "txtToplam";
            txtToplam.Size = new Size(125, 27);
            txtToplam.TabIndex = 11;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(118, 382);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(78, 34);
            btnKaydet.TabIndex = 12;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // PurchaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKaydet);
            Controls.Add(txtToplam);
            Controls.Add(dtpTarih);
            Controls.Add(txtBirimFiyat);
            Controls.Add(txtMiktar);
            Controls.Add(txtTedarikci);
            Controls.Add(txtKalemNo);
            Controls.Add(lblToplam);
            Controls.Add(lblTarih);
            Controls.Add(lblBirimFiyat);
            Controls.Add(lblMiktar);
            Controls.Add(lblTedarikci);
            Controls.Add(lblKalemNo);
            Name = "PurchaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Satın Alma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKalemNo;
        private Label lblTedarikci;
        private Label lblMiktar;
        private Label lblBirimFiyat;
        private Label lblTarih;
        private Label lblToplam;
        private Button btnKaydet;
        public TextBox txtKalemNo;
        public TextBox txtTedarikci;
        public TextBox txtMiktar;
        public TextBox txtBirimFiyat;
        public TextBox txtToplam;
        public DateTimePicker dtpTarih;
    }
}