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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(109, 62);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(100, 23);
            txtBookName.TabIndex = 0;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(224, 62);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(109, 91);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(206, 23);
            btnSend.TabIndex = 2;
            btnSend.Text = "Talep Gönder";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(109, 44);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 3;
            label1.Text = "Kitabın İsmi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(224, 44);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 4;
            label2.Text = "Yazar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(437, 15);
            label3.TabIndex = 5;
            label3.Text = "Kitap Talep Sayfasına Hoş Geldiniz! Buradan Dilediğiniz kitapları bize iletebilirsiniz. ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(12, 214);
            label4.Name = "label4";
            label4.Size = new Size(243, 15);
            label4.TabIndex = 6;
            label4.Text = "! Bütün istekleriniz tarafımızca incelenecektir.";
            // 
            // BookRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(486, 238);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(txtAuthor);
            Controls.Add(txtBookName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BookRequestForm";
            Text = "Kitap İsteği";
            Load += BookRequestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBookName;
        private TextBox txtAuthor;
        private Button btnSend;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}