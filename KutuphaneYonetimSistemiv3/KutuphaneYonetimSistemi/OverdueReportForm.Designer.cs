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
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1 = new Panel();
            btnShowLate = new Button();
            label1 = new Label();
            label5 = new Label();
            lblMainTitle = new Label();
            panel2 = new Panel();
            btnShowBooks = new Button();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            btnShowMembers = new Button();
            label6 = new Label();
            label2 = new Label();
            pnlStats = new Panel();
            pnlDetails = new Panel();
            dgvReportDetails = new DataGridView();
            labelToplamKitap = new Label();
            labelOdunctekiKitap = new Label();
            panel4 = new Panel();
            label7 = new Label();
            pnlPie = new Panel();
            label10 = new Label();
            label9 = new Label();
            panel5 = new Panel();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportDetails).BeginInit();
            panel4.SuspendLayout();
            pnlPie.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 195, 176);
            panel1.Controls.Add(btnShowLate);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 127);
            panel1.TabIndex = 0;
            // 
            // btnShowLate
            // 
            btnShowLate.FlatAppearance.BorderSize = 0;
            btnShowLate.FlatStyle = FlatStyle.Flat;
            btnShowLate.Location = new Point(0, 104);
            btnShowLate.Name = "btnShowLate";
            btnShowLate.Size = new Size(222, 23);
            btnShowLate.TabIndex = 0;
            btnShowLate.Text = "Tamamını Gör";
            btnShowLate.UseVisualStyleBackColor = true;
            btnShowLate.Click += btnShowLate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(208, 86);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(3, 6);
            label5.Name = "label5";
            label5.Size = new Size(191, 26);
            label5.TabIndex = 5;
            label5.Text = "Geciken Kitap Sayısı";
            // 
            // lblMainTitle
            // 
            lblMainTitle.AutoSize = true;
            lblMainTitle.FlatStyle = FlatStyle.Flat;
            lblMainTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMainTitle.Location = new Point(9, 133);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(240, 15);
            lblMainTitle.TabIndex = 1;
            lblMainTitle.Text = "Son 30 Günün Günlük Kitap Ödünç Grafiği\r\n";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 195, 176);
            panel2.Controls.Add(btnShowBooks);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(478, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 127);
            panel2.TabIndex = 1;
            // 
            // btnShowBooks
            // 
            btnShowBooks.FlatAppearance.BorderSize = 0;
            btnShowBooks.FlatStyle = FlatStyle.Flat;
            btnShowBooks.Location = new Point(0, 99);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(218, 28);
            btnShowBooks.TabIndex = 7;
            btnShowBooks.Text = "Tamamını Gör";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(228, 30);
            label4.TabIndex = 4;
            label4.Text = "En Çok Ödünç Alınan ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(-1, 51);
            label3.Name = "label3";
            label3.Size = new Size(105, 45);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(217, 195, 176);
            panel3.Controls.Add(btnShowMembers);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(240, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 127);
            panel3.TabIndex = 1;
            // 
            // btnShowMembers
            // 
            btnShowMembers.FlatAppearance.BorderSize = 0;
            btnShowMembers.FlatStyle = FlatStyle.Flat;
            btnShowMembers.Location = new Point(-1, 101);
            btnShowMembers.Name = "btnShowMembers";
            btnShowMembers.Size = new Size(219, 30);
            btnShowMembers.TabIndex = 6;
            btnShowMembers.Text = "Tamamını Gör";
            btnShowMembers.UseVisualStyleBackColor = true;
            btnShowMembers.Click += btnShowMembers_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(149, 26);
            label6.TabIndex = 6;
            label6.Text = "En Aktif Üyeler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(-1, 49);
            label2.Name = "label2";
            label2.Size = new Size(105, 45);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // pnlStats
            // 
            pnlStats.Location = new Point(9, 146);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(674, 248);
            pnlStats.TabIndex = 2;
            // 
            // pnlDetails
            // 
            pnlDetails.Controls.Add(dgvReportDetails);
            pnlDetails.Location = new Point(6, 149);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(674, 246);
            pnlDetails.TabIndex = 3;
            pnlDetails.Visible = false;
            // 
            // dgvReportDetails
            // 
            dgvReportDetails.BackgroundColor = SystemColors.ButtonFace;
            dgvReportDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportDetails.Location = new Point(9, 3);
            dgvReportDetails.Name = "dgvReportDetails";
            dgvReportDetails.Size = new Size(665, 242);
            dgvReportDetails.TabIndex = 0;
            // 
            // labelToplamKitap
            // 
            labelToplamKitap.AutoSize = true;
            labelToplamKitap.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelToplamKitap.Location = new Point(0, 41);
            labelToplamKitap.Name = "labelToplamKitap";
            labelToplamKitap.Size = new Size(211, 86);
            labelToplamKitap.TabIndex = 4;
            labelToplamKitap.Text = "label7";
            labelToplamKitap.Click += labelToplamKitap_Click;
            // 
            // labelOdunctekiKitap
            // 
            labelOdunctekiKitap.AutoSize = true;
            labelOdunctekiKitap.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelOdunctekiKitap.Location = new Point(2, 41);
            labelOdunctekiKitap.Name = "labelOdunctekiKitap";
            labelOdunctekiKitap.Size = new Size(213, 86);
            labelOdunctekiKitap.TabIndex = 5;
            labelOdunctekiKitap.Text = "label8";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(217, 195, 176);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(labelToplamKitap);
            panel4.Location = new Point(6, 419);
            panel4.Name = "panel4";
            panel4.Size = new Size(228, 127);
            panel4.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(216, 26);
            label7.TabIndex = 6;
            label7.Text = "Stoktaki Toplam Kitap ";
            // 
            // pnlPie
            // 
            pnlPie.Controls.Add(label9);
            pnlPie.Location = new Point(471, 419);
            pnlPie.Name = "pnlPie";
            pnlPie.Size = new Size(236, 127);
            pnlPie.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(471, 398);
            label10.Name = "label10";
            label10.Size = new Size(184, 26);
            label10.TabIndex = 8;
            label10.Text = "Stok/Ödünç Grafiği";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 5;
            label9.Text = "label9";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(217, 195, 176);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(labelOdunctekiKitap);
            panel5.Location = new Point(243, 419);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 127);
            panel5.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(214, 26);
            label8.TabIndex = 7;
            label8.Text = "Ödünç Verilen Kitaplar";
            // 
            // OverdueReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(110, 113, 115);
            ClientSize = new Size(700, 550);
            Controls.Add(label10);
            Controls.Add(panel5);
            Controls.Add(pnlPie);
            Controls.Add(panel4);
            Controls.Add(pnlStats);
            Controls.Add(pnlDetails);
            Controls.Add(lblMainTitle);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(700, 550);
            MinimumSize = new Size(700, 550);
            Name = "OverdueReportForm";
            Text = "Rapor Ekranı";
            Load += OverdueReportForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnlDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportDetails).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pnlPie.ResumeLayout(false);
            pnlPie.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel pnlStats;
        private Panel pnlDetails;
        private Button btnShowLate;
        private Button btnShowBooks;
        private Button btnShowMembers;
        private DataGridView dgvReportDetails;
        private Label lblMainTitle;
        private Label labelToplamKitap;
        private Label labelOdunctekiKitap;
        private Panel panel4;
        private Panel pnlPie;
        private Label label9;
        private Panel panel5;
        private Label label7;
        private Label label10;
        private Label label8;
    }
}