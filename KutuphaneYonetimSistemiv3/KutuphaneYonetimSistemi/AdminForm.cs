using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kutuphane.Entities;

namespace KutuphaneYonetimSistemi
{
    public partial class AdminForm : Form
    {

        Color bgMain = ColorTranslator.FromHtml("#6E7173");
        Color accent = ColorTranslator.FromHtml("#D9BC9A");
        Color titleClr = ColorTranslator.FromHtml("#59402A");
        Color cardBg = ColorTranslator.FromHtml("#D9C3B0");
        Color textClr = ColorTranslator.FromHtml("#0D0D0D");

        private Member _currentUser;
        private void StyleMenuButton(Button btn)
        {
            btn.BackColor = titleClr;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Height = 45;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(15, 0, 0, 0);

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = accent;
                btn.ForeColor = titleClr;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = titleClr;
                btn.ForeColor = Color.White;
            };
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

            this.BackColor = bgMain;
            this.Font = new Font("Segoe UI", 10);
            this.MaximizeBox = false;

            panel1.BackColor = titleClr;

            panelIslem.BackColor = cardBg;

            StyleMenuButton(btnBooks);
            StyleMenuButton(btnBorrows);
            StyleMenuButton(btnMembers);
            StyleMenuButton(btnRequest);
            StyleMenuButton(btnReports);

            btnExit.BackColor = ColorTranslator.FromHtml("#8B2E2E");
            btnExit.ForeColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
        }

        public AdminForm(Member user)
        {
            InitializeComponent();
            _currentUser = user;
            this.Load += AdminForm_Load;
            btnBooks.Click += btnBooks_Click;
            btnBorrows.Click += btnBorrows_Click;
            btnMembers.Click += btnMembers_Click;
            btnRequest.Click += btnRequest_Click;
            btnReports.Click += btnReports_Click;
            btnExit.Click += btnExit_Click;

        }
        private void OpenFormInPanel(Form frm)
        {
            panelIslem.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.None;

            frm.Width = 700;
            frm.Height = 400;

            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);

            panelIslem.Controls.Add(frm);
            frm.Show();
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new BookForm(_currentUser));
        }

        private void btnBorrows_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new BorrowForm(_currentUser));

        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new MemberForm(_currentUser));

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new BookRequestAdminForm());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new OverdueReportForm());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
