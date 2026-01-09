namespace KutuphaneYonetimSistemi
{
    partial class MyBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBooksForm));
            dgvMyBooks = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMyBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvMyBooks
            // 
            dgvMyBooks.BackgroundColor = SystemColors.ControlLightLight;
            dgvMyBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyBooks.GridColor = SystemColors.Window;
            dgvMyBooks.Location = new Point(12, 33);
            dgvMyBooks.Name = "dgvMyBooks";
            dgvMyBooks.Size = new Size(776, 405);
            dgvMyBooks.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "Üzerimdeki Kitaplar";
            // 
            // MyBooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvMyBooks);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MyBooksForm";
            Text = "Üzerimdeki Kitaplar";
            Load += MyBooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMyBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMyBooks;
        private Label label1;
    }
}