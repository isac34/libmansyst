namespace KutuphaneYonetimSistemi
{
    partial class BorrowForm
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbMember
            // 
            cmbMember.FormattingEnabled = true;
            cmbMember.Location = new Point(10, 242);
            cmbMember.Margin = new Padding(3, 2, 3, 2);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(133, 23);
            cmbMember.TabIndex = 0;
            // 
            // cmbBook
            // 
            cmbBook.FormattingEnabled = true;
            cmbBook.Location = new Point(149, 242);
            cmbBook.Margin = new Padding(3, 2, 3, 2);
            cmbBook.Name = "cmbBook";
            cmbBook.Size = new Size(133, 23);
            cmbBook.TabIndex = 1;
            // 
            // dtDueDate
            // 
            dtDueDate.Location = new Point(10, 287);
            dtDueDate.Margin = new Padding(3, 2, 3, 2);
            dtDueDate.Name = "dtDueDate";
            dtDueDate.Size = new Size(219, 23);
            dtDueDate.TabIndex = 2;
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(10, 314);
            btnBorrow.Margin = new Padding(3, 2, 3, 2);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(106, 22);
            btnBorrow.TabIndex = 3;
            btnBorrow.Text = "Ödünç Verildi";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(122, 314);
            btnReturn.Margin = new Padding(3, 2, 3, 2);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(108, 22);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Teslim Alındı";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 9);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(679, 214);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(149, 225);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 6;
            label1.Text = "Kitap İsmi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(10, 267);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 7;
            label2.Text = "Teslim Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(10, 225);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 8;
            label3.Text = "Üye Numarası";
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(700, 345);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnReturn);
            Controls.Add(btnBorrow);
            Controls.Add(dtDueDate);
            Controls.Add(cmbBook);
            Controls.Add(cmbMember);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "BorrowForm";
            Text = "Kitap Ödünç";
            Load += BorrowForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}