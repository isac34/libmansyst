namespace KutuphaneYonetimSistemi
{
    partial class OverdueReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverdueReportForm));
            dgvLate = new DataGridView();
            label1 = new Label();
            dgvTopBooks = new DataGridView();
            dgvTopMembers = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvLate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTopBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTopMembers).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLate
            // 
            dgvLate.BackgroundColor = SystemColors.ControlLightLight;
            dgvLate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLate.Location = new Point(46, 39);
            dgvLate.Margin = new Padding(3, 2, 3, 2);
            dgvLate.Name = "dgvLate";
            dgvLate.RowHeadersWidth = 51;
            dgvLate.Size = new Size(295, 293);
            dgvLate.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 22);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 1;
            label1.Text = "Getirilmemiş Kitaplar";
            // 
            // dgvTopBooks
            // 
            dgvTopBooks.BackgroundColor = SystemColors.ControlLightLight;
            dgvTopBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopBooks.Location = new Point(347, 39);
            dgvTopBooks.Name = "dgvTopBooks";
            dgvTopBooks.Size = new Size(295, 293);
            dgvTopBooks.TabIndex = 2;
            // 
            // dgvTopMembers
            // 
            dgvTopMembers.BackgroundColor = SystemColors.ControlLightLight;
            dgvTopMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopMembers.Location = new Point(648, 39);
            dgvTopMembers.Name = "dgvTopMembers";
            dgvTopMembers.Size = new Size(295, 293);
            dgvTopMembers.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 21);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 4;
            label2.Text = "En Çok Alınan Kitaplar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(648, 22);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 5;
            label3.Text = "En Aktif Üyeler";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvLate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dgvTopBooks);
            groupBox1.Controls.Add(dgvTopMembers);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1134, 455);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // OverdueReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(1429, 639);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "OverdueReportForm";
            Text = "Rapor Ekranı";
            Load += OverdueReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLate).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTopBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTopMembers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLate;
        private Label label1;
        private DataGridView dgvTopBooks;
        private DataGridView dgvTopMembers;
        private Label label2;
        private Label label3;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private GroupBox groupBox1;
    }
}