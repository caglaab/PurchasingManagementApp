using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PurchasingManagementApp
{
    public partial class PurchaseForm : Form
    {
        private int updateId = -1;
        [System.ComponentModel.DesignerSerializationVisibility(
        System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int UpdateId
        {
            get { return updateId; }
            set { updateId = value; }
        }
        public PurchaseForm()
        {
            InitializeComponent();
        }
        private void HesaplaToplam()
        {
            if (decimal.TryParse(txtMiktar.Text, out decimal miktar) &&
                decimal.TryParse(txtBirimFiyat.Text, out decimal birimFiyat))
            {
                decimal toplam = miktar * birimFiyat;
                txtToplam.Text = toplam.ToString("0.00");
            }
            else
            {
                txtToplam.Text = "";
            }
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            HesaplaToplam();
        }

        private void txtBirimFiyat_TextChanged(object sender, EventArgs e)
        {
            HesaplaToplam();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKalemNo.Text) ||
                string.IsNullOrWhiteSpace(txtTedarikci.Text) ||
                string.IsNullOrWhiteSpace(txtMiktar.Text) ||
                string.IsNullOrWhiteSpace(txtBirimFiyat.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı");
                return;
            }

            if (!decimal.TryParse(txtMiktar.Text, out decimal miktar) ||
                !decimal.TryParse(txtBirimFiyat.Text, out decimal birimFiyat))
            {
                MessageBox.Show("Miktar ve birim fiyat sayısal olmalıdır.", "Hata");
                return;
            }

            decimal toplam = miktar * birimFiyat;

            using (var connection = new Microsoft.Data.Sqlite.SqliteConnection(
                Database.ConnectionString))
            {
                connection.Open();

                if (updateId == -1)
                {
                    // YENİ KAYIT
                    string query = @"
                INSERT INTO Purchases
                (ItemCode, Supplier, Quantity, UnitPrice, PurchaseDate, TotalPrice)
                VALUES
                (@ItemCode, @Supplier, @Quantity, @UnitPrice, @PurchaseDate, @TotalPrice)";

                    using (var command = new Microsoft.Data.Sqlite.SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemCode", txtKalemNo.Text);
                        command.Parameters.AddWithValue("@Supplier", txtTedarikci.Text);
                        command.Parameters.AddWithValue("@Quantity", miktar);
                        command.Parameters.AddWithValue("@UnitPrice", birimFiyat);
                        command.Parameters.AddWithValue("@PurchaseDate",
                            dtpTarih.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@TotalPrice", toplam);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Satın alma kaydı başarıyla eklendi.", "Başarılı");
                }
                else
                {
                    // MEVCUT KAYDI GÜNCELLE
                    string query = @"
                UPDATE Purchases
                SET ItemCode = @ItemCode,
                    Supplier = @Supplier,
                    Quantity = @Quantity,
                    UnitPrice = @UnitPrice,
                    PurchaseDate = @PurchaseDate,
                    TotalPrice = @TotalPrice
                WHERE Id = @Id";

                    using (var command = new Microsoft.Data.Sqlite.SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemCode", txtKalemNo.Text);
                        command.Parameters.AddWithValue("@Supplier", txtTedarikci.Text);
                        command.Parameters.AddWithValue("@Quantity", miktar);
                        command.Parameters.AddWithValue("@UnitPrice", birimFiyat);
                        command.Parameters.AddWithValue("@PurchaseDate",
                            dtpTarih.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@TotalPrice", toplam);
                        command.Parameters.AddWithValue("@Id", updateId);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Satın alma kaydı başarıyla güncellendi.", "Başarılı");
                }
            }

            this.Close();
        }
    }
}
