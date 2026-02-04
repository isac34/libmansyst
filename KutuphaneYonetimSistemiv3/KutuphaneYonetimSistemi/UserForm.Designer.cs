namespace KutuphaneYonetimSistemi
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            btnExit = new Button();
            dgvBooks = new DataGridView();
            dgvMyBooks = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnBooks = new Button();
            btnRequest = new Button();
            btnMyBooks = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            txtSearchBooks = new TextBox();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMyBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(89, 64, 42);
            btnExit.ForeColor = SystemColors.ControlLight;
            btnExit.Location = new Point(838, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(44, 24);
            btnExit.TabIndex = 14;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // dgvBooks
            // 
            dgvBooks.BackgroundColor = Color.Snow;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(267, 4);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(615, 263);
            dgvBooks.TabIndex = 15;
            // 
            // dgvMyBooks
            // 
            dgvMyBooks.BackgroundColor = Color.Snow;
            dgvMyBooks.BorderStyle = BorderStyle.None;
            dgvMyBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyBooks.Location = new Point(267, 4);
            dgvMyBooks.Name = "dgvMyBooks";
            dgvMyBooks.Size = new Size(615, 263);
            dgvMyBooks.TabIndex = 16;
            dgvMyBooks.CellContentClick += dgvMyBooks_CellContentClick;
            dgvMyBooks.CellFormatting += dgvMyBooks_CellFormatting;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(217, 188, 154);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 98);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(217, 188, 154);
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(89, 64, 42);
            label1.Location = new Point(106, 0);
            label1.Name = "label1";
            label1.Size = new Size(714, 65);
            label1.TabIndex = 19;
            label1.Text = "Hoş geldiniz, iyi günler dileriz.";
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.FromArgb(89, 64, 42);
            btnBooks.FlatAppearance.BorderSize = 0;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Italic);
            btnBooks.ForeColor = SystemColors.ControlLight;
            btnBooks.Location = new Point(0, 137);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(258, 70);
            btnBooks.TabIndex = 21;
            btnBooks.Text = "Bütün Kitaplar";
            btnBooks.TextAlign = ContentAlignment.MiddleLeft;
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click_1;
            // 
            // btnRequest
            // 
            btnRequest.BackColor = Color.FromArgb(89, 64, 42);
            btnRequest.FlatAppearance.BorderSize = 0;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Italic);
            btnRequest.ForeColor = Color.White;
            btnRequest.Location = new Point(0, 275);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(258, 63);
            btnRequest.TabIndex = 22;
            btnRequest.Text = "Kitap Talebi Oluştur";
            btnRequest.TextAlign = ContentAlignment.MiddleLeft;
            btnRequest.UseVisualStyleBackColor = false;
            btnRequest.Click += btnRequest_Click_1;
            // 
            // btnMyBooks
            // 
            btnMyBooks.BackColor = Color.FromArgb(89, 64, 42);
            btnMyBooks.FlatAppearance.BorderSize = 0;
            btnMyBooks.FlatStyle = FlatStyle.Flat;
            btnMyBooks.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Italic);
            btnMyBooks.ForeColor = Color.White;
            btnMyBooks.Location = new Point(0, 206);
            btnMyBooks.Name = "btnMyBooks";
            btnMyBooks.Size = new Size(258, 71);
            btnMyBooks.TabIndex = 23;
            btnMyBooks.Text = "Üstümdeki Kitaplar";
            btnMyBooks.TextAlign = ContentAlignment.MiddleLeft;
            btnMyBooks.UseVisualStyleBackColor = false;
            btnMyBooks.Click += btnMyBooks_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(89, 64, 42);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(193, 137);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(89, 64, 42);
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(193, 206);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(89, 64, 42);
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(193, 275);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(68, 63);
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(89, 64, 42);
            panel1.Location = new Point(0, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 36);
            panel1.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(89, 64, 42);
            panel2.Location = new Point(0, 338);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 29);
            panel2.TabIndex = 28;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(110, 113, 115);
            panel3.Controls.Add(dgvMyBooks);
            panel3.Controls.Add(dgvBooks);
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(882, 296);
            panel3.TabIndex = 29;
            // 
            // txtSearchBooks
            // 
            txtSearchBooks.Location = new Point(267, 77);
            txtSearchBooks.Name = "txtSearchBooks";
            txtSearchBooks.Size = new Size(615, 23);
            txtSearchBooks.TabIndex = 30;
            txtSearchBooks.TextChanged += txtSearchBooks_TextChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(846, 77);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 23);
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 59);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 32;
            label2.Text = "Arama Çubuğu";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(217, 188, 154);
            ClientSize = new Size(882, 393);
            Controls.Add(label2);
            Controls.Add(pictureBox5);
            Controls.Add(txtSearchBooks);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnMyBooks);
            Controls.Add(btnRequest);
            Controls.Add(btnBooks);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Kullanım Sistemi";
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMyBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button2;
        private Button btnExit;
        private DataGridView dgvBooks;
        private DataGridView dgvMyBooks;
        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonMyBooks;
        private Button btnBooks;
        private Button btnRequest;
        private Button btnMyBooks;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtSearchBooks;
        private PictureBox pictureBox5;
        private Label label2;
    }
}