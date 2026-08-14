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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            // PurchaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(720, 620);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PurchaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Satın Alma";

            // 
            // lblKalemNo
            // 
            lblKalemNo.AutoSize = true;
            lblKalemNo.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold);

            lblKalemNo.ForeColor =
                Color.FromArgb(31, 41, 55);

            lblKalemNo.Location =
                new Point(70, 115);

            lblKalemNo.Name = "lblKalemNo";
            lblKalemNo.Size =
                new Size(80, 23);

            lblKalemNo.Text =
                "Kalem No";

            // 
            // txtKalemNo
            // 
            txtKalemNo.BackColor = Color.White;
            txtKalemNo.BorderStyle = BorderStyle.FixedSingle;
            txtKalemNo.Font =
                new Font("Segoe UI", 10.5F);

            txtKalemNo.Location =
                new Point(70, 142);

            txtKalemNo.Name =
                "txtKalemNo";

            txtKalemNo.Size =
                new Size(580, 31);

            txtKalemNo.TabIndex = 0;

            // 
            // lblTedarikci
            // 
            lblTedarikci.AutoSize = true;
            lblTedarikci.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            lblTedarikci.ForeColor =
                Color.FromArgb(31, 41, 55);

            lblTedarikci.Location =
                new Point(70, 195);

            lblTedarikci.Name =
                "lblTedarikci";

            lblTedarikci.Size =
                new Size(78, 23);

            lblTedarikci.Text =
                "Tedarikçi";

            // 
            // txtTedarikci
            // 
            txtTedarikci.BackColor =
                Color.White;

            txtTedarikci.BorderStyle =
                BorderStyle.FixedSingle;

            txtTedarikci.Font =
                new Font("Segoe UI", 10.5F);

            txtTedarikci.Location =
                new Point(70, 222);

            txtTedarikci.Name =
                "txtTedarikci";

            txtTedarikci.Size =
                new Size(580, 31);

            txtTedarikci.TabIndex = 1;

            // 
            // lblMiktar
            // 
            lblMiktar.AutoSize = true;
            lblMiktar.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            lblMiktar.ForeColor =
                Color.FromArgb(31, 41, 55);

            lblMiktar.Location =
                new Point(70, 275);

            lblMiktar.Name =
                "lblMiktar";

            lblMiktar.Size =
                new Size(57, 23);

            lblMiktar.Text =
                "Miktar";

            // 
            // txtMiktar
            // 
            txtMiktar.BackColor =
                Color.White;

            txtMiktar.BorderStyle =
                BorderStyle.FixedSingle;

            txtMiktar.Font =
                new Font("Segoe UI", 10.5F);

            txtMiktar.Location =
                new Point(70, 302);

            txtMiktar.Name =
                "txtMiktar";

            txtMiktar.Size =
                new Size(270, 31);

            txtMiktar.TabIndex = 2;

            txtMiktar.TextChanged +=
                txtMiktar_TextChanged;

            // 
            // lblBirimFiyat
            // 
            lblBirimFiyat.AutoSize = true;
            lblBirimFiyat.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            lblBirimFiyat.ForeColor =
                Color.FromArgb(31, 41, 55);

            lblBirimFiyat.Location =
                new Point(380, 275);

            lblBirimFiyat.Name =
                "lblBirimFiyat";

            lblBirimFiyat.Size =
                new Size(91, 23);

            lblBirimFiyat.Text =
                "Birim Fiyat";

            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.BackColor =
                Color.White;

            txtBirimFiyat.BorderStyle =
                BorderStyle.FixedSingle;

            txtBirimFiyat.Font =
                new Font("Segoe UI", 10.5F);

            txtBirimFiyat.Location =
                new Point(380, 302);

            txtBirimFiyat.Name =
                "txtBirimFiyat";

            txtBirimFiyat.Size =
                new Size(270, 31);

            txtBirimFiyat.TabIndex = 3;

            txtBirimFiyat.TextChanged +=
                txtBirimFiyat_TextChanged;

            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            lblTarih.ForeColor =
                Color.FromArgb(31, 41, 55);

            lblTarih.Location =
                new Point(70, 355);

            lblTarih.Name =
                "lblTarih";

            lblTarih.Size =
                new Size(44, 23);

            lblTarih.Text =
                "Tarih";

            // 
            // dtpTarih
            // 
            dtpTarih.Font =
                new Font("Segoe UI", 10F);

            dtpTarih.Format =
                DateTimePickerFormat.Short;

            dtpTarih.Location =
                new Point(70, 382);

            dtpTarih.Name =
                "dtpTarih";

            dtpTarih.Size =
                new Size(270, 30);

            dtpTarih.TabIndex = 4;

            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            lblToplam.ForeColor =
                Color.FromArgb(31, 41, 55);

            lblToplam.Location =
                new Point(380, 355);

            lblToplam.Name =
                "lblToplam";

            lblToplam.Size =
                new Size(108, 23);

            lblToplam.Text =
                "Toplam Tutar";

            // 
            // txtToplam
            // 
            txtToplam.BackColor =
                Color.FromArgb(239, 246, 255);

            txtToplam.BorderStyle =
                BorderStyle.FixedSingle;

            txtToplam.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            txtToplam.ForeColor =
                Color.FromArgb(37, 99, 235);

            txtToplam.Location =
                new Point(380, 382);

            txtToplam.Name =
                "txtToplam";

            txtToplam.ReadOnly = true;

            txtToplam.Size =
                new Size(270, 32);

            txtToplam.TabIndex = 5;

            // 
            // btnKaydet
            // 
            btnKaydet.BackColor =
                Color.FromArgb(37, 99, 235);

            btnKaydet.FlatAppearance.BorderSize = 0;

            btnKaydet.FlatStyle =
                FlatStyle.Flat;

            btnKaydet.Font =
                new Font(
                    "Segoe UI",
                    10.5F,
                    FontStyle.Bold);

            btnKaydet.ForeColor =
                Color.White;

            btnKaydet.Location =
                new Point(450, 485);

            btnKaydet.Name =
                "btnKaydet";

            btnKaydet.Size =
                new Size(200, 48);

            btnKaydet.TabIndex = 6;

            btnKaydet.Text =
                "✓  Kaydet";

            btnKaydet.UseVisualStyleBackColor = false;

            btnKaydet.Cursor =
                Cursors.Hand;

            btnKaydet.Click +=
                btnKaydet_Click;

            // 
            // Controls
            // 
            Controls.Add(txtKalemNo);
            Controls.Add(lblKalemNo);

            Controls.Add(txtTedarikci);
            Controls.Add(lblTedarikci);

            Controls.Add(txtMiktar);
            Controls.Add(lblMiktar);

            Controls.Add(txtBirimFiyat);
            Controls.Add(lblBirimFiyat);

            Controls.Add(dtpTarih);
            Controls.Add(lblTarih);

            Controls.Add(txtToplam);
            Controls.Add(lblToplam);

            Controls.Add(btnKaydet);

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