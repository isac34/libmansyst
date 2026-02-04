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
    public partial class StaffForm : Form
    {
        private Member _currentUser;

        public StaffForm(Member user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void btnBooks_Click_1(object sender, EventArgs e)
        {
            OpenFormInPanel(new BookForm(_currentUser));
        }

        private void btnBorrows_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new BorrowForm(_currentUser));
        }

        private void btnMembers_Click_1(object sender, EventArgs e)
        {
            OpenFormInPanel(new MemberForm(_currentUser));
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new BookRequestAdminForm());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show(); 
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {

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
    }


}
