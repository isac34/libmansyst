namespace KutuphaneYonetimSistemi
{
    partial class BookRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookRequestForm));
            txtBookName = new TextBox();
            txtAuthor = new TextBox();
            btnSend = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnExit = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtBookName.Location = new Point(110, 121);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(100, 29);
            txtBookName.TabIndex = 0;
            txtBookName.Text = "Kitap İsmi";
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAuthor.Location = new Point(231, 121);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 29);
            txtAuthor.TabIndex = 1;
            txtAuthor.Text = "Yazar İsmi";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(217, 195, 176);
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSend.Location = new Point(119, 156);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(221, 47);
            btnSend.TabIndex = 2;
            btnSend.Text = "Talep Gönder";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(110, 113, 115);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(65, 206);
            label4.Name = "label4";
            label4.Size = new Size(358, 21);
            label4.TabIndex = 6;
            label4.Text = "! Bütün istekleriniz tarafımızca incelenecektir.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(217, 188, 154);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 72);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(217, 188, 154);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.ForeColor = Color.FromArgb(89, 64, 42);
            textBox1.Location = new Point(110, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 53);
            textBox1.TabIndex = 8;
            textBox1.Text = "Kitap Talep Sayfası";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(110, 113, 115);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(45, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(412, 22);
            textBox2.TabIndex = 9;
            textBox2.Text = "Dilediğiniz kitapları aşağıdan bize ulaştırabilirsiniz.";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.OrangeRed;
            btnExit.Location = new Point(438, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(44, 24);
            btnExit.TabIndex = 15;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(110, 113, 115);
            panel1.Location = new Point(0, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 203);
            panel1.TabIndex = 16;
            // 
            // BookRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 188, 154);
            ClientSize = new Size(483, 282);
            Controls.Add(btnExit);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(btnSend);
            Controls.Add(txtAuthor);
            Controls.Add(txtBookName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BookRequestForm";
            Text = "Kitap İsteği";
            Load += BookRequestForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBookName;
        private TextBox txtAuthor;
        private Button btnSend;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnExit;
        private Panel panel1;
    }
}