namespace KutuphaneYonetimSistemi
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            panelIslem = new Panel();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnBorrows = new Button();
            btnMembers = new Button();
            btnReports = new Button();
            pictureBox4 = new PictureBox();
            btnRequest = new Button();
            btnBooks = new Button();
            btnExit = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panelIslem
            // 
            panelIslem.BackColor = Color.White;
            panelIslem.Location = new Point(233, 88);
            panelIslem.Name = "panelIslem";
            panelIslem.Size = new Size(700, 550);
            panelIslem.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 195, 176);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnBorrows);
            panel1.Controls.Add(btnMembers);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnRequest);
            panel1.Controls.Add(btnBooks);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 500);
            panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(89, 64, 42);
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(180, 242);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 43);
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(217, 188, 154);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(89, 64, 42);
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(183, 440);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(40, 40);
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(89, 64, 42);
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(180, 308);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(89, 64, 42);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(164, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 53);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnBorrows
            // 
            btnBorrows.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBorrows.Location = new Point(0, 242);
            btnBorrows.Name = "btnBorrows";
            btnBorrows.Size = new Size(220, 60);
            btnBorrows.TabIndex = 2;
            btnBorrows.Text = "Ödünç İade İşlemleri";
            btnBorrows.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnMembers
            // 
            btnMembers.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnMembers.Location = new Point(0, 308);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(220, 60);
            btnMembers.TabIndex = 3;
            btnMembers.Text = "Üye İşlemleri";
            btnMembers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnReports.Location = new Point(0, 440);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(220, 60);
            btnReports.TabIndex = 5;
            btnReports.Text = "Raporlar";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(180, 374);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // btnRequest
            // 
            btnRequest.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnRequest.Location = new Point(0, 374);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(220, 60);
            btnRequest.TabIndex = 4;
            btnRequest.Text = "Kitap Talepleri";
            btnRequest.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBooks
            // 
            btnBooks.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnBooks.Location = new Point(0, 137);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(220, 60);
            btnBooks.TabIndex = 1;
            btnBooks.Text = "Kitap İşlemleri";
            btnBooks.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(89, 64, 42);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(900, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(45, 30);
            btnExit.TabIndex = 3;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(217, 188, 154);
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(89, 64, 42);
            label1.Location = new Point(220, 0);
            label1.Name = "label1";
            label1.Size = new Size(725, 80);
            label1.TabIndex = 2;
            label1.Text = "Kütüphane Yönetici Ekranı";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(110, 113, 115);
            ClientSize = new Size(947, 641);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            Controls.Add(panelIslem);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1000, 700);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelIslem;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnBooks;
        private Button btnBorrows;
        private Button btnMembers;
        private Button btnRequest;
        private Button btnReports;
        private Button btnExit;
        private Label label1;

        // BUTON STİLİ YARDIMCI METODU
        private void StyleMenuButton(Button btn, string text, int index)
        {
            btn.BackColor = ColorTranslator.FromHtml("#D9C3B0");
            btn.ForeColor = ColorTranslator.FromHtml("#59402A");
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btn.Text = text;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(15, 0, 0, 0);
            btn.Size = new Size(220, 60);
           

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = ColorTranslator.FromHtml("#D9BC9A");
                btn.ForeColor = ColorTranslator.FromHtml("#59402A");
            };
            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = ColorTranslator.FromHtml("#D9C3B0");
                btn.ForeColor = ColorTranslator.FromHtml("#59402A");
            };
        }
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
    }
}
