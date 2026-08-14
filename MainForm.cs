using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PurchasingManagementApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnYeniSatinAlma_Click(object sender, EventArgs e)
        {
            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKayitlar_Click(object sender, EventArgs e)
        {
            PurchaseListForm purchaseListForm = new PurchaseListForm();
            purchaseListForm.ShowDialog();
        }

        private void btnAnaliz_Click(object sender, EventArgs e)
        {
            AnalysisForm analysisForm = new AnalysisForm();
            analysisForm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
