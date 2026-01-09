using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kutuphane.BLL;
using Kutuphane.Entities;
using Microsoft.VisualBasic.ApplicationServices;
namespace KutuphaneYonetimSistemi
{
    public partial class BookRequestForm : Form
    {
        Member _user;
        public BookRequestForm(Member user)
        {
            InitializeComponent();
            _user = user;
        }

        private void BookRequestForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            BookRequestService service = new BookRequestService();

            service.AddRequest(_user.MemberId,txtBookName.Text,txtAuthor.Text);
            MessageBox.Show("Kitap talebiniz alındı 👍");
            txtBookName.Clear();
            txtAuthor.Clear();
        }
    }
}
