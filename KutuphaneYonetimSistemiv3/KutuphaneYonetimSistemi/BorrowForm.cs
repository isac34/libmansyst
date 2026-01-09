using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kutuphane.BBL;
using Kutuphane.Entities;
using Microsoft.VisualBasic.ApplicationServices;

namespace KutuphaneYonetimSistemi
{

    public partial class BorrowForm : Form
    {
        Member _user;
        public BorrowForm(Member user)
        {
            InitializeComponent();
            _user = user;
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            MemberService ms = new MemberService();
            BookService bs = new BookService();
            BorrowService brs = new BorrowService();

            cmbMember.DataSource = ms.GetMembers();
            cmbMember.DisplayMember = "FirstName" + "LastName";
            cmbMember.ValueMember = "MemberId";

            cmbBook.DataSource = bs.GetBooks();
            cmbBook.DisplayMember = "BookName";
            cmbBook.ValueMember = "BookId";

            dataGridView1.DataSource = brs.GetActiveBorrows();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow
            {
                MemberId = (int)cmbMember.SelectedValue,
                BookId = (int)cmbBook.SelectedValue,
                DueDate = dtDueDate.Value
            };

            BorrowService service = new BorrowService();
            service.BorrowBook(borrow);

            MessageBox.Show("Kitap ödünç verildi");
            dataGridView1.DataSource = service.GetActiveBorrows();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int borrowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BorrowId"].Value);

            int bookId = (int)cmbBook.SelectedValue;

            BorrowService service = new BorrowService();
            service.ReturnBook(borrowId, bookId);

            MessageBox.Show("Kitap iade edildi");
            dataGridView1.DataSource = service.GetActiveBorrows();

        }

        
    }
}
