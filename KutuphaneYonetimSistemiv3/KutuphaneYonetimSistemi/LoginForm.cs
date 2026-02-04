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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace KutuphaneYonetimSistemi
{
    public partial class LoginForm : Form
    {

        Color bgMain = ColorTranslator.FromHtml("#6E7173");
        Color accent = ColorTranslator.FromHtml("#D9BC9A");
        Color titleClr = ColorTranslator.FromHtml("#59402A");
        Color cardBg = ColorTranslator.FromHtml("#D9C3B0");
        Color textClr = ColorTranslator.FromHtml("#0D0D0D");
        private void LoginForm_Load(object sender, EventArgs e)
        {

            this.BackColor = bgMain;
            this.Font = new Font("Segoe UI", 10);


            panel1.BackColor = cardBg;
            panel1.ForeColor = titleClr;
            panel1.Font = new Font("Segoe UI", 11, FontStyle.Bold);


            txtUsername.BackColor = Color.White;
            txtUsername.ForeColor = textClr;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;


            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = textClr;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.UseSystemPasswordChar = true;


            btnLogin.BackColor = accent;
            btnLogin.ForeColor = titleClr;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Segoe UI", 10, FontStyle.Bold);


            btnLogin.MouseEnter += (s, ev) =>
            {
                btnLogin.BackColor = titleClr;
                btnLogin.ForeColor = Color.White;
            };

            btnLogin.MouseLeave += (s, ev) =>
            {
                btnLogin.BackColor = accent;
                btnLogin.ForeColor = titleClr;
            };
        }

        public LoginForm()
        {
            InitializeComponent();
            this.Load += LoginForm_Load;
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

            this.Hide();

            if (user.Role == "Admin")
            {
                new AdminForm(user).Show();
            }
            else if (user.Role == "Staff")
            {
                new StaffForm(user).Show();
            }
            else
            {
                new UserForm(user).Show();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
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

            this.Hide();

            if (user.Role == "Admin")
            {
                new AdminForm(user).Show();
            }
            else if (user.Role == "Staff")
            {
                new StaffForm(user).Show();
            }
            else
            {
                new UserForm(user).Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
