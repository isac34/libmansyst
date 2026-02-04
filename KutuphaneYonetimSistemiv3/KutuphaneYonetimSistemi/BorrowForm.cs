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
        private Member _member;
        private DataTable _allBorrows;
        private BindingSource _bsBorrows = new BindingSource();


        public BorrowForm(Member user)
        {
            InitializeComponent();
            _member = user;
        }
        private void HighlightLateBorrows()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["DueDate"].Value == null) continue;

                DateTime dueDate = Convert.ToDateTime(row.Cells["DueDate"].Value);

                if (dueDate < DateTime.Now)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                    row.DefaultCellStyle.Font =
                        new Font(dataGridView1.Font, FontStyle.Bold);
                }
            }
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            MemberService ms = new MemberService();
            BookService bs = new BookService();
            BorrowService brs = new BorrowService();

            cmbMember.DataSource = ms.GetMembers();
            cmbMember.DisplayMember = "FirstName"; 
            cmbMember.ValueMember = "MemberId";

            cmbBook.DataSource = bs.GetBooks();
            cmbBook.DisplayMember = "BookName";
            cmbBook.ValueMember = "BookId";

            _allBorrows = brs.GetActiveBorrows();
            _bsBorrows.DataSource = _allBorrows;
            dataGridView1.DataSource = _bsBorrows;
            HighlightLateBorrows();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_allBorrows == null) return;

            string filter = txtSearch.Text.Replace("'", "''");

            if (string.IsNullOrWhiteSpace(filter))
            {
                _bsBorrows.DataSource = _allBorrows;
            }
            else
            {
                _bsBorrows.Filter =
                    $"FirstName LIKE '%{filter}%' OR BookName LIKE '%{filter}%'";
            }

            HighlightLateBorrows();
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
            _allBorrows = service.GetActiveBorrows();
            _bsBorrows.DataSource = _allBorrows;
            HighlightLateBorrows();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen iade edilecek satırı seçin.");
                return;
            }

            int borrowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BorrowId"].Value);
            int bookId = (int)cmbBook.SelectedValue;

            BorrowService service = new BorrowService();
            service.ReturnBook(borrowId, bookId);

            MessageBox.Show("Kitap iade edildi");
            dataGridView1.DataSource = service.GetActiveBorrows();
            _allBorrows = service.GetActiveBorrows();
            _bsBorrows.DataSource = _allBorrows;
            HighlightLateBorrows();
        }

        private void dtDueDate_ValueChanged(object sender, EventArgs e)
        {
            // Şimdilik boş, isteğe bağlı kullanılabilir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

