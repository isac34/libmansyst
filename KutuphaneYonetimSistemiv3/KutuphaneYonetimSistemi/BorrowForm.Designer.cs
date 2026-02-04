namespace KutuphaneYonetimSistemi
{
    partial class BorrowForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowForm));
            cmbMember = new ComboBox();
            cmbBook = new ComboBox();
            dtDueDate = new DateTimePicker();
            btnBorrow = new Button();
            btnReturn = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            txtSearch = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cmbMember
            // 
            cmbMember.BackColor = Color.White;
            cmbMember.ForeColor = Color.FromArgb(13, 13, 13);
            cmbMember.FormattingEnabled = true;
            cmbMember.Location = new Point(75, 213);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(133, 23);
            cmbMember.TabIndex = 11;
            // 
            // cmbBook
            // 
            cmbBook.BackColor = Color.White;
            cmbBook.ForeColor = Color.FromArgb(13, 13, 13);
            cmbBook.FormattingEnabled = true;
            cmbBook.Location = new Point(221, 213);
            cmbBook.Name = "cmbBook";
            cmbBook.Size = new Size(133, 23);
            cmbBook.TabIndex = 10;
            // 
            // dtDueDate
            // 
            dtDueDate.CalendarForeColor = Color.FromArgb(13, 13, 13);
            dtDueDate.CalendarMonthBackground = Color.FromArgb(217, 195, 176);
            dtDueDate.Location = new Point(360, 210);
            dtDueDate.Name = "dtDueDate";
            dtDueDate.Size = new Size(219, 23);
            dtDueDate.TabIndex = 9;
            dtDueDate.ValueChanged += dtDueDate_ValueChanged;
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.FromArgb(217, 195, 176);
            btnBorrow.FlatAppearance.BorderSize = 0;
            btnBorrow.FlatStyle = FlatStyle.Flat;
            btnBorrow.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnBorrow.ForeColor = Color.Black;
            btnBorrow.Location = new Point(186, 242);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(133, 32);
            btnBorrow.TabIndex = 8;
            btnBorrow.Text = "Ödünç Verildi";
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(217, 195, 176);
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnReturn.ForeColor = Color.Black;
            btnReturn.Location = new Point(325, 242);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(108, 32);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Teslim Alındı";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(217, 195, 176);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(110, 113, 115);
            dataGridView1.Location = new Point(10, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(678, 137);
            dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(110, 113, 115);
            label1.ForeColor = Color.White;
            label1.Location = new Point(75, 192);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 3;
            label1.Text = "Üye İsmi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(110, 113, 115);
            label2.ForeColor = Color.White;
            label2.Location = new Point(360, 192);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 4;
            label2.Text = "Teslim Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(110, 113, 115);
            label3.ForeColor = Color.White;
            label3.Location = new Point(221, 192);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Kitap İsmi";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(217, 188, 154);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 72);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(89, 64, 42);
            label4.Location = new Point(126, 2);
            label4.Name = "label4";
            label4.Size = new Size(453, 65);
            label4.TabIndex = 1;
            label4.Text = "Aktif Ödünç Listesi";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(89, 64, 42);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(654, 2);
            button1.Name = "button1";
            button1.Size = new Size(34, 23);
            button1.TabIndex = 0;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(110, 113, 115);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnBorrow);
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(cmbMember);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbBook);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtDueDate);
            panel1.Location = new Point(0, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 332);
            panel1.TabIndex = 12;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(10, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(678, 23);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(217, 195, 176);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(654, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 23);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 188, 154);
            ClientSize = new Size(700, 400);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(700, 400);
            MinimumSize = new Size(700, 400);
            Name = "BorrowForm";
            Text = "Kitap Ödünç";
            Load += BorrowForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMember;
        private ComboBox cmbBook;
        private DateTimePicker dtDueDate;
        private Button btnBorrow;
        private Button btnReturn;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Button button1;
        private Panel panel1;
        private TextBox txtSearch;
        private PictureBox pictureBox2;
    }
}
