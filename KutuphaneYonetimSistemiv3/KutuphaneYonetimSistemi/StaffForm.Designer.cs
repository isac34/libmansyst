namespace KutuphaneYonetimSistemi
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            btnExit = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelIslem = new Panel();
            btnBooks = new Button();
            btnBorrows = new Button();
            btnRequest = new Button();
            btnMembers = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(89, 64, 42);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Location = new Point(880, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(68, 34);
            btnExit.TabIndex = 24;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(217, 188, 154);
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(89, 64, 42);
            label1.Location = new Point(361, 9);
            label1.Name = "label1";
            label1.Size = new Size(466, 50);
            label1.TabIndex = 28;
            label1.Text = "Kütüphane Görevli Ekranı";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(217, 188, 154);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 160);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // panelIslem
            // 
            panelIslem.Anchor = AnchorStyles.None;
            panelIslem.BackColor = Color.White;
            panelIslem.Location = new Point(15, 11);
            panelIslem.Name = "panelIslem";
            panelIslem.Size = new Size(700, 400);
            panelIslem.TabIndex = 5;
            // 
            // btnBooks
            // 
            btnBooks.FlatAppearance.BorderColor = Color.Snow;
            btnBooks.FlatAppearance.BorderSize = 0;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBooks.ForeColor = Color.White;
            btnBooks.Location = new Point(-5, 21);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(220, 60);
            btnBooks.TabIndex = 0;
            btnBooks.Text = "Kitap İşlemleri";
            btnBooks.TextAlign = ContentAlignment.MiddleLeft;
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click_1;
            // 
            // btnBorrows
            // 
            btnBorrows.FlatAppearance.BorderColor = Color.Snow;
            btnBorrows.FlatAppearance.BorderSize = 0;
            btnBorrows.FlatStyle = FlatStyle.Flat;
            btnBorrows.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBorrows.ForeColor = Color.White;
            btnBorrows.Location = new Point(-5, 87);
            btnBorrows.Name = "btnBorrows";
            btnBorrows.Size = new Size(220, 60);
            btnBorrows.TabIndex = 1;
            btnBorrows.Text = "Ödünç İade İşlemleri";
            btnBorrows.TextAlign = ContentAlignment.MiddleLeft;
            btnBorrows.UseVisualStyleBackColor = true;
            btnBorrows.Click += btnBorrows_Click;
            // 
            // btnRequest
            // 
            btnRequest.FlatAppearance.BorderColor = Color.Snow;
            btnRequest.FlatAppearance.BorderSize = 0;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRequest.ForeColor = Color.White;
            btnRequest.Location = new Point(0, 219);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(220, 60);
            btnRequest.TabIndex = 3;
            btnRequest.Text = "Kitap Talepleri";
            btnRequest.TextAlign = ContentAlignment.MiddleLeft;
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click;
            // 
            // btnMembers
            // 
            btnMembers.FlatAppearance.BorderColor = Color.Snow;
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMembers.ForeColor = Color.White;
            btnMembers.Location = new Point(-2, 153);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(220, 60);
            btnMembers.TabIndex = 4;
            btnMembers.Text = "Üye İşlemleri";
            btnMembers.TextAlign = ContentAlignment.MiddleLeft;
            btnMembers.UseVisualStyleBackColor = true;
            btnMembers.Click += btnMembers_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(149, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 53);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(149, 153);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 53);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(149, 219);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 53);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(89, 64, 42);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnMembers);
            panel1.Controls.Add(btnRequest);
            panel1.Controls.Add(btnBorrows);
            panel1.Controls.Add(btnBooks);
            panel1.Location = new Point(0, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 387);
            panel1.TabIndex = 29;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(149, 87);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(53, 53);
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(110, 113, 115);
            panel2.Controls.Add(panelIslem);
            panel2.Location = new Point(218, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(730, 424);
            panel2.TabIndex = 30;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 188, 154);
            ClientSize = new Size(945, 500);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(945, 500);
            MinimumSize = new Size(945, 500);
            Name = "StaffForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Yönetim Sistemi";
            Load += StaffForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMyBooks;
        private DataGridView dgvMyBooks;
        private Button btnExit;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Panel panelIslem;
        private Button btnBooks;
        private Button btnBorrows;
        private Button btnRequest;
        private Button btnMembers;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox5;
    }
}