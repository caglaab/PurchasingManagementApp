namespace PurchasingManagementApp
{
    partial class MainForm
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
            lblBaslik = new Label();

            SuspendLayout();

            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Name = "lblBaslik";
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "PURCHASING MANAGEMENT";

            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchasing Management";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
    }
}