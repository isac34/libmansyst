namespace KutuphaneYonetimSistemi
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            dataGridView1 = new DataGridView();
            txtBookName = new TextBox();
            txtAuthor = new TextBox();
            txtStock = new TextBox();
            btnAdd = new Button();
            label1 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 11);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(789, 141);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(10, 180);
            txtBookName.Margin = new Padding(3, 2, 3, 2);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(110, 23);
            txtBookName.TabIndex = 1;
            txtBookName.Text = "Kitap Adı";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(10, 207);
            txtAuthor.Margin = new Padding(3, 2, 3, 2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(110, 23);
            txtAuthor.TabIndex = 2;
            txtAuthor.Text = "Kitap Yazarı";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(10, 234);
            txtStock.Margin = new Padding(3, 2, 3, 2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(110, 23);
            txtStock.TabIndex = 3;
            txtStock.Text = "Kitap Stoğu";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 261);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 64, 64);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(10, 163);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 5;
            label1.Text = "Kitap Ekle";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(98, 261);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(186, 261);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(806, 305);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(txtStock);
            Controls.Add(txtAuthor);
            Controls.Add(txtBookName);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookForm";
            Text = "Kitap Ekranı";
            Load += BookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtBookName;
        private TextBox txtAuthor;
        private TextBox txtStock;
        private Button btnAdd;
        private Label label1;
        private Button btnDelete;
        private Button btnUpdate;
    }
}