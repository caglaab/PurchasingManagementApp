namespace PurchasingManagementApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

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
            panelLeft = new Panel();
            lblLogo = new Label();
            lblLogoSub = new Label();

            panelLogin = new Panel();
            lblWelcome = new Label();
            lblSubtitle = new Label();

            label1 = new Label();
            txtKullaniciAdi = new TextBox();

            label2 = new Label();
            txtSifre = new TextBox();

            btnGiris = new Button();
            lblInfo = new Label();

            panelLeft.SuspendLayout();
            panelLogin.SuspendLayout();
            SuspendLayout();

            // SOL PANEL
            panelLeft.BackColor = Color.FromArgb(15, 23, 42);
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(330, 520);
            panelLeft.TabIndex = 0;

            // LOGO
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font(
                "Segoe UI",
                22F,
                FontStyle.Bold);

            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(42, 170);
            lblLogo.Name = "lblLogo";
            lblLogo.Text = "PURCHASING";

            // ALT LOGO
            lblLogoSub.AutoSize = true;
            lblLogoSub.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Regular);

            lblLogoSub.ForeColor =
                Color.FromArgb(148, 163, 184);

            lblLogoSub.Location =
                new Point(45, 225);

            lblLogoSub.Name =
                "lblLogoSub";

            lblLogoSub.Text =
                "MANAGEMENT SYSTEM";

            panelLeft.Controls.Add(lblLogo);
            panelLeft.Controls.Add(lblLogoSub);

            // SAĞ PANEL
            panelLogin.BackColor = Color.White;
            panelLogin.Location = new Point(330, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(520, 520);
            panelLogin.TabIndex = 1;

            // HOŞ GELDİNİZ
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font(
                "Segoe UI",
                21F,
                FontStyle.Bold);

            lblWelcome.ForeColor =
                Color.FromArgb(15, 23, 42);

            lblWelcome.Location =
                new Point(80, 70);

            lblWelcome.Name =
                "lblWelcome";

            lblWelcome.Text =
                "Hoş Geldiniz";

            panelLogin.Controls.Add(lblWelcome);

            // ALT BAŞLIK
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font(
                "Segoe UI",
                9.5F);

            lblSubtitle.ForeColor =
                Color.FromArgb(100, 116, 139);

            lblSubtitle.Location =
                new Point(82, 120);

            lblSubtitle.Name =
                "lblSubtitle";

            lblSubtitle.Text =
                "Hesabınıza giriş yapın";

            panelLogin.Controls.Add(lblSubtitle);

            // KULLANICI ADI LABEL
            label1.AutoSize = true;
            label1.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold);

            label1.ForeColor =
                Color.FromArgb(51, 65, 85);

            label1.Location =
                new Point(82, 170);

            label1.Name =
                "label1";

            label1.Text =
                "Kullanıcı Adı";

            label1.Click += label1_Click;

            panelLogin.Controls.Add(label1);

            // KULLANICI ADI
            txtKullaniciAdi.Font =
                new Font(
                    "Segoe UI",
                    10F);

            txtKullaniciAdi.Location =
                new Point(82, 195);

            txtKullaniciAdi.Name =
                "txtKullaniciAdi";

            txtKullaniciAdi.Size =
                new Size(300, 30);

            txtKullaniciAdi.TabIndex =
                1;

            panelLogin.Controls.Add(txtKullaniciAdi);

            // ŞİFRE LABEL
            label2.AutoSize = true;
            label2.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold);

            label2.ForeColor =
                Color.FromArgb(51, 65, 85);

            label2.Location =
                new Point(82, 245);

            label2.Name =
                "label2";

            label2.Text =
                "Şifre";

            panelLogin.Controls.Add(label2);

            // ŞİFRE
            txtSifre.Font =
                new Font(
                    "Segoe UI",
                    10F);

            txtSifre.Location =
                new Point(82, 270);

            txtSifre.Name =
                "txtSifre";

            txtSifre.PasswordChar =
                '●';

            txtSifre.Size =
                new Size(300, 30);

            txtSifre.TabIndex =
                2;

            panelLogin.Controls.Add(txtSifre);

            // GİRİŞ BUTONU
            btnGiris.BackColor =
                Color.FromArgb(37, 99, 235);

            btnGiris.FlatStyle =
                FlatStyle.Flat;

            btnGiris.FlatAppearance.BorderSize =
                0;

            btnGiris.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            btnGiris.ForeColor =
                Color.White;

            btnGiris.Location =
                new Point(82, 325);

            btnGiris.Name =
                "btnGiris";

            btnGiris.Size =
                new Size(300, 45);

            btnGiris.TabIndex =
                3;

            btnGiris.Text =
                "Giriş Yap";

            btnGiris.UseVisualStyleBackColor =
                false;

            btnGiris.Cursor =
                Cursors.Hand;

            btnGiris.Click +=
                btnGiris_Click;

            panelLogin.Controls.Add(btnGiris);

            // ALT BİLGİ
            lblInfo.AutoSize = true;

            lblInfo.Font =
                new Font(
                    "Segoe UI",
                    8.5F);

            lblInfo.ForeColor =
                Color.FromArgb(148, 163, 184);

            lblInfo.Location =
                new Point(82, 390);

            lblInfo.Name =
                "lblInfo";

            lblInfo.Text =
                "Purchasing Management System";

            panelLogin.Controls.Add(lblInfo);

            // FORM
            AutoScaleDimensions =
                new SizeF(8F, 20F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.White;

            ClientSize =
                new Size(850, 520);

            Controls.Add(panelLogin);
            Controls.Add(panelLeft);

            FormBorderStyle =
                FormBorderStyle.FixedSingle;

            MaximizeBox =
                false;

            MinimizeBox =
                false;

            Name =
                "LoginForm";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "Purchasing Management";

            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();

            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();

            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Label lblLogo;
        private Label lblLogoSub;

        private Panel panelLogin;
        private Label lblWelcome;
        private Label lblSubtitle;

        private Label label1;
        private TextBox txtKullaniciAdi;

        private Label label2;
        private TextBox txtSifre;

        private Button btnGiris;
        private Label lblInfo;
    }
}