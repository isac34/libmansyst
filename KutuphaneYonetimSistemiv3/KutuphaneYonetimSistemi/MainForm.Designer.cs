namespace KutuphaneYonetimSistemi
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            userMenu = new ToolStripMenuItem();
            myBooksMenu = new ToolStripMenuItem();
            bookRequestMenu = new ToolStripMenuItem();
            logoutMenu = new ToolStripMenuItem();
            managementMenu = new ToolStripMenuItem();
            borrowMenu = new ToolStripMenuItem();
            memeberMenu = new ToolStripMenuItem();
            bookMenu = new ToolStripMenuItem();
            bookRequestAdminMenu = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            reportMenu = new ToolStripMenuItem();
            reportMainMenu = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { userMenu, managementMenu, reportMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(564, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // userMenu
            // 
            userMenu.DropDownItems.AddRange(new ToolStripItem[] { myBooksMenu, bookRequestMenu, logoutMenu });
            userMenu.Name = "userMenu";
            userMenu.Size = new Size(110, 20);
            userMenu.Text = "Kullanıcı Menüsü";
            // 
            // myBooksMenu
            // 
            myBooksMenu.Name = "myBooksMenu";
            myBooksMenu.Size = new Size(180, 22);
            myBooksMenu.Text = "Kitaplarım";
            myBooksMenu.Click += myBooksMenu_Click;
            // 
            // bookRequestMenu
            // 
            bookRequestMenu.Name = "bookRequestMenu";
            bookRequestMenu.Size = new Size(180, 22);
            bookRequestMenu.Text = "Kitap Talebi";
            bookRequestMenu.Click += bookRequestMenu_Click;
            // 
            // logoutMenu
            // 
            logoutMenu.Name = "logoutMenu";
            logoutMenu.Size = new Size(180, 22);
            logoutMenu.Text = "Çıkış Yap";
            logoutMenu.Click += logoutMenu_Click;
            // 
            // managementMenu
            // 
            managementMenu.DropDownItems.AddRange(new ToolStripItem[] { borrowMenu, memeberMenu, bookMenu, bookRequestAdminMenu, çıkışYapToolStripMenuItem });
            managementMenu.Name = "managementMenu";
            managementMenu.Size = new Size(107, 20);
            managementMenu.Text = "Yönetici Menüsü";
            // 
            // borrowMenu
            // 
            borrowMenu.Name = "borrowMenu";
            borrowMenu.Size = new Size(180, 22);
            borrowMenu.Text = "Ödünç Menüsü";
            borrowMenu.Click += borrowMenu_Click;
            // 
            // memeberMenu
            // 
            memeberMenu.Name = "memeberMenu";
            memeberMenu.Size = new Size(180, 22);
            memeberMenu.Text = "Üye Menüsü";
            memeberMenu.Click += memeberMenu_Click;
            // 
            // bookMenu
            // 
            bookMenu.Name = "bookMenu";
            bookMenu.Size = new Size(180, 22);
            bookMenu.Text = "Kitap Menüsü";
            bookMenu.Click += bookMenu_Click;
            // 
            // bookRequestAdminMenu
            // 
            bookRequestAdminMenu.Name = "bookRequestAdminMenu";
            bookRequestAdminMenu.Size = new Size(180, 22);
            bookRequestAdminMenu.Text = "Kitap Talepleri";
            bookRequestAdminMenu.Click += bookRequestAdminMenu_Click;
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(180, 22);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // reportMenu
            // 
            reportMenu.BackColor = Color.FromArgb(0, 64, 64);
            reportMenu.DropDownItems.AddRange(new ToolStripItem[] { reportMainMenu });
            reportMenu.Name = "reportMenu";
            reportMenu.Size = new Size(96, 20);
            reportMenu.Text = "Rapor Menüsü";
            reportMenu.Click += reportMenu_Click;
            // 
            // reportMainMenu
            // 
            reportMainMenu.Name = "reportMainMenu";
            reportMainMenu.Size = new Size(180, 22);
            reportMainMenu.Text = "Raporlar";
            reportMainMenu.Click += reportMainMenu_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(564, 389);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "İşlem Seçme Ekranı";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem userMenu;
        private ToolStripMenuItem managementMenu;
        private ToolStripMenuItem reportMenu;
        private ToolStripMenuItem borrowMenu;
        private ToolStripMenuItem memeberMenu;
        private ToolStripMenuItem bookMenu;
        private ToolStripMenuItem myBooksMenu;
        private ToolStripMenuItem bookRequestMenu;
        private ToolStripMenuItem logoutMenu;
        private ToolStripMenuItem bookRequestAdminMenu;
        private ToolStripMenuItem reportMainMenu;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}