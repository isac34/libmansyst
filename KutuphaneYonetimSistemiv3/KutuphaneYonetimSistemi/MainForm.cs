using Kutuphane.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KutuphaneYonetimSistemi
{
    public partial class MainForm : Form
    {
        Member _user;

        public MainForm(Member user)
        {
            InitializeComponent();
            _user = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Hepsini kapat
            managementMenu.Visible = false;
            reportMenu.Visible = false;
            userMenu.Visible = false;

            // 🔴 ADMIN
            if (_user.Role == "Admin")
            {
                managementMenu.Visible = true;
                reportMenu.Visible = true;
                userMenu.Visible = false;
            }

            // 🟠 STAFF
            else if (_user.Role == "Staff")
            {
                managementMenu.Visible = true;
                reportMenu.Visible = false;
                userMenu.Visible = true;
            }

            // 🟢 MEMBER
            else if (_user.Role == "Member")
            {
                managementMenu.Visible = false;
                reportMenu.Visible = false;
                userMenu.Visible = true;
            }
        }

        private void bookMenu_Click(object sender, EventArgs e)
        {
            BookForm frm = new BookForm(_user);
            frm.ShowDialog();
        }

        private void memeberMenu_Click(object sender, EventArgs e)
        {
            MemberForm frm = new MemberForm(_user);
            frm.ShowDialog();
        }

        private void borrowMenu_Click(object sender, EventArgs e)
        {
            BorrowForm frm = new BorrowForm(_user);
            frm.ShowDialog();
        }

        private void reportMenu_Click(object sender, EventArgs e)
        {
            OverdueReportForm frm = new OverdueReportForm();
            frm.ShowDialog();
        }

        private void myBooksMenu_Click(object sender, EventArgs e)
        {
            new MyBooksForm(_user).ShowDialog();
        }

        private void bookRequestMenu_Click(object sender, EventArgs e)
        {
            new BookRequestForm(_user).ShowDialog();
        }

        private void logoutMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void bookRequestAdminMenu_Click(object sender, EventArgs e)
        {
            new BookRequestAdminForm().ShowDialog();
        }

        private void reportMainMenu_Click(object sender, EventArgs e)
        {
            new OverdueReportForm().ShowDialog();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
