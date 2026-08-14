namespace PurchasingManagementApp
{
    partial class MainForm
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
            btnYeniSatinAlma = new Button();
            btnKayitlar = new Button();
            btnAnaliz = new Button();
            btnCikis = new Button();
            lblBaslik = new Label();
            SuspendLayout();
            // 
            // btnYeniSatinAlma
            // 
            btnYeniSatinAlma.Location = new Point(320, 76);
            btnYeniSatinAlma.Name = "btnYeniSatinAlma";
            btnYeniSatinAlma.Size = new Size(160, 40);
            btnYeniSatinAlma.TabIndex = 0;
            btnYeniSatinAlma.Text = "Yeni Satın Alma";
            btnYeniSatinAlma.UseVisualStyleBackColor = true;
            btnYeniSatinAlma.Click += btnYeniSatinAlma_Click;
            // 
            // btnKayitlar
            // 
            btnKayitlar.Location = new Point(320, 158);
            btnKayitlar.Name = "btnKayitlar";
            btnKayitlar.Size = new Size(160, 40);
            btnKayitlar.TabIndex = 1;
            btnKayitlar.Text = "Satın Alma Kayıtları";
            btnKayitlar.UseVisualStyleBackColor = true;
            btnKayitlar.Click += btnKayitlar_Click;
            // 
            // btnAnaliz
            // 
            btnAnaliz.Location = new Point(320, 240);
            btnAnaliz.Name = "btnAnaliz";
            btnAnaliz.Size = new Size(160, 40);
            btnAnaliz.TabIndex = 2;
            btnAnaliz.Text = "Analiz";
            btnAnaliz.UseVisualStyleBackColor = true;
            btnAnaliz.Click += btnAnaliz_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(320, 322);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(160, 40);
            btnCikis.TabIndex = 3;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 14F);
            lblBaslik.Location = new Point(237, 20);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(347, 32);
            lblBaslik.TabIndex = 4;
            lblBaslik.Text = "SATIN ALMA YÖNETİM SİSTEMİ";
            lblBaslik.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBaslik);
            Controls.Add(btnCikis);
            Controls.Add(btnAnaliz);
            Controls.Add(btnKayitlar);
            Controls.Add(btnYeniSatinAlma);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satın Alma Yönetim Sistemi - Ana Menü";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYeniSatinAlma;
        private Button btnKayitlar;
        private Button btnAnaliz;
        private Button btnCikis;
        private Label lblBaslik;
    }
}