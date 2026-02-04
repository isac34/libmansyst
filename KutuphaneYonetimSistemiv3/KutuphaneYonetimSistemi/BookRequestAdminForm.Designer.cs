namespace KutuphaneYonetimSistemi
{
    partial class BookRequestAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookRequestAdminForm));
            dataGridView1 = new DataGridView();
            btnApprove = new Button();
            btnReject = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(617, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.FromArgb(217, 195, 176);
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnApprove.ForeColor = Color.FromArgb(89, 64, 42);
            btnApprove.Location = new Point(217, 183);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(105, 54);
            btnApprove.TabIndex = 1;
            btnApprove.Text = "Onayla";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.FromArgb(217, 195, 176);
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnReject.ForeColor = Color.FromArgb(89, 64, 42);
            btnReject.Location = new Point(328, 183);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(105, 54);
            btnReject.TabIndex = 2;
            btnReject.Text = "Reddet";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(217, 188, 154);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 98);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(217, 188, 154);
            label1.Font = new Font("Segoe UI", 44.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(89, 64, 42);
            label1.Location = new Point(106, 20);
            label1.Name = "label1";
            label1.Size = new Size(593, 78);
            label1.TabIndex = 19;
            label1.Text = "Gelen Kitap İstekleri";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(89, 64, 42);
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(665, 0);
            button1.Name = "button1";
            button1.Size = new Size(34, 23);
            button1.TabIndex = 23;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 188, 154);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 105);
            panel1.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(110, 113, 115);
            panel2.Controls.Add(btnApprove);
            panel2.Controls.Add(btnReject);
            panel2.Location = new Point(0, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 291);
            panel2.TabIndex = 25;
            // 
            // BookRequestAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 188, 154);
            ClientSize = new Size(700, 400);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(700, 400);
            MinimumSize = new Size(700, 400);
            Name = "BookRequestAdminForm";
            Text = "Kitap İstekleri";
            Load += BookRequestAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnApprove;
        private Button btnReject;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
    }
}