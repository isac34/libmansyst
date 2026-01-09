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
using Microsoft.VisualBasic.ApplicationServices;
using MySqlX.XDevAPI;
namespace KutuphaneYonetimSistemi
{
    public partial class MyBooksForm : Form
    {
        Member _user;
        public MyBooksForm(Member user)
        {
            InitializeComponent();
           _user = user;
            

        }
          private void MyBooksForm_Load(object sender, EventArgs e)
        {
            
            BorrowService service = new BorrowService();
            int id = _user.MemberId;
            dgvMyBooks.DataSource = service.GetActiveBorrows();
        }
        
       
        
    }
}
