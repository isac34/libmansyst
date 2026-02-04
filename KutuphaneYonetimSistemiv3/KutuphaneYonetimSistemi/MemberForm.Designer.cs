namespace KutuphaneYonetimSistemi
{
    partial class MemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            cmbRole = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            labelTitle = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            txtSearch = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.None;
            txtFirstName.BackColor = Color.FromArgb(217, 195, 176);
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtFirstName.ForeColor = Color.FromArgb(89, 64, 42);
            txtFirstName.Location = new Point(3, 313);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(120, 29);
            txtFirstName.TabIndex = 4;
            txtFirstName.Text = "İsim";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.None;
            txtLastName.BackColor = Color.FromArgb(217, 195, 176);
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtLastName.ForeColor = Color.FromArgb(89, 64, 42);
            txtLastName.Location = new Point(129, 313);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(120, 29);
            txtLastName.TabIndex = 5;
            txtLastName.Text = "Soyisim";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.BackColor = Color.FromArgb(217, 195, 176);
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPhone.ForeColor = Color.FromArgb(89, 64, 42);
            txtPhone.Location = new Point(255, 313);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(120, 29);
            txtPhone.TabIndex = 6;
            txtPhone.Text = "Telefon";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = Color.FromArgb(217, 195, 176);
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtEmail.ForeColor = Color.FromArgb(89, 64, 42);
            txtEmail.Location = new Point(381, 313);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(120, 29);
            txtEmail.TabIndex = 7;
            txtEmail.Text = "Mail";
            // 
            // cmbRole
            // 
            cmbRole.Anchor = AnchorStyles.None;
            cmbRole.BackColor = Color.FromArgb(217, 195, 176);
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbRole.ForeColor = Color.FromArgb(89, 64, 42);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Staff", "Member" });
            cmbRole.Location = new Point(507, 313);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(120, 29);
            cmbRole.TabIndex = 8;
            cmbRole.Text = "Rol Seçiniz";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.FromArgb(217, 195, 176);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(89, 64, 42);
            btnAdd.Location = new Point(3, 348);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.FromArgb(217, 195, 176);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.FromArgb(89, 64, 42);
            btnUpdate.Location = new Point(109, 348);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 40);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.FromArgb(217, 195, 176);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(89, 64, 42);
            btnDelete.Location = new Point(235, 348);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(692, 152);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(217, 188, 154);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 88);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.FromArgb(217, 188, 154);
            labelTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            labelTitle.ForeColor = SystemColors.ActiveCaptionText;
            labelTitle.Location = new Point(118, 21);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(342, 65);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Güncel Üyeler";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 188, 154);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 108);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(698, 293);
            panel2.TabIndex = 14;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(3, 126);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(692, 23);
            txtSearch.TabIndex = 14;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(661, 126);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 23);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(3, 111);
            label1.Name = "label1";
            label1.Size = new Size(84, 13);
            label1.TabIndex = 16;
            label1.Text = "Arama Çubuğu";
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(110, 113, 115);
            ClientSize = new Size(700, 400);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(txtSearch);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtPhone);
            Controls.Add(labelTitle);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox1);
            Controls.Add(cmbRole);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(panel1);
            Controls.Add(btnDelete);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(700, 400);
            MinimumSize = new Size(700, 400);
            Name = "MemberForm";
            Text = "MemberForm";
            Load += MemberForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private ComboBox cmbRole;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label labelTitle;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtSearch;
        private PictureBox pictureBox2;
        private Label label1;
    }
}