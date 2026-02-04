namespace KutuphaneYonetimSistemi
{
    partial class BookForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            panelMain = new Panel();
            btnBack = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            txtSearch = new TextBox();
            txtStock = new TextBox();
            txtAuthor = new TextBox();
            txtBookName = new TextBox();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(217, 188, 154);
            panelMain.Controls.Add(btnBack);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(pictureBox1);
            panelMain.Controls.Add(panel1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(700, 400);
            panelMain.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(89, 64, 42);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(660, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(34, 23);
            btnBack.TabIndex = 7;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(89, 64, 42);
            label1.Location = new Point(140, 20);
            label1.Name = "label1";
            label1.Size = new Size(500, 50);
            label1.TabIndex = 8;
            label1.Text = "Güncel Kitaplar Listesi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(20, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 70);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(110, 113, 115);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(txtAuthor);
            panel1.Controls.Add(txtBookName);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 300);
            panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(653, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 23);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(20, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 13);
            label2.TabIndex = 8;
            label2.Text = "Arama Çubuğu";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(660, 23);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtStock.Location = new Point(391, 192);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(135, 35);
            txtStock.TabIndex = 3;
            txtStock.Text = "Kitap Stoğu";
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtAuthor.Location = new Point(241, 192);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(144, 35);
            txtAuthor.TabIndex = 2;
            txtAuthor.Text = "Kitabın Yazarı";
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtBookName.Location = new Point(135, 192);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(100, 35);
            txtBookName.TabIndex = 1;
            txtBookName.Text = "Kitap Adı";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(660, 140);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(217, 195, 176);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnAdd.Location = new Point(189, 233);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 37);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(217, 195, 176);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnDelete.Location = new Point(270, 233);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 37);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(217, 195, 176);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnUpdate.Location = new Point(351, 233);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 37);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(110, 113, 115);
            ClientSize = new Size(700, 400);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(700, 400);
            MinimumSize = new Size(700, 400);
            Name = "BookForm";
            StartPosition = FormStartPosition.CenterParent;
            Load += BookForm_Load;
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private DataGridView dataGridView1;
        private TextBox txtBookName;
        private TextBox txtAuthor;
        private TextBox txtStock;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnBack;
        private Label label1;
        private PictureBox pictureBox1;

        // Yardımcı metotlar
        private void StyleTextBox(TextBox tb, string placeholder, int x, int y)
        {
            tb.Text = placeholder;
            tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            tb.Location = new System.Drawing.Point(x, y);
            tb.Size = new System.Drawing.Size(150, 30);
            tb.Multiline = true;
        }

        private void StyleActionButton(Button btn, string text, int x, int y, EventHandler clickEvent)
        {
            btn.Text = text;
            btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btn.Size = new System.Drawing.Size(110, 40);
            btn.Location = new System.Drawing.Point(x, y);
            btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#D9C3B0");
            btn.ForeColor = System.Drawing.ColorTranslator.FromHtml("#59402A");
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += clickEvent;

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#D9BC9A");
            };
            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#D9C3B0");
            };
        }

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox txtSearch;
    }
}
