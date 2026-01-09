using Kutuphane.Entities;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MemberService service = new MemberService();

            Member user = service.Login(
                txtUsername.Text,
                txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                return;
            }

            MainForm main = new MainForm(user);
            main.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
