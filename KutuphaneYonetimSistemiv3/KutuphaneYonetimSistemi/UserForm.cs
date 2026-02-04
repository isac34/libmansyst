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
using Kutuphane.BLL;
using Kutuphane.Entities;
using MySqlX.XDevAPI;
using KutuphaneYonetimSistemi;

namespace KutuphaneYonetimSistemi
{
    public partial class UserForm : Form
    {
        private Member _currentMember;
        private List<Book> _allBooks;
        private BindingSource _bsBooks = new BindingSource();

        private BookService _bookService = new BookService();
        private BorrowService _borrowService = new BorrowService();

        public UserForm(Member member)
        {
            InitializeComponent();
            _currentMember = member;
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            HideAllGrids();
            dgvBooks.Visible = true;
            LoadBooks();
        }

        // SADECE GRID'LERİ GİZLE
        private void HideAllGrids()
        {
            dgvBooks.Visible = false;
            dgvMyBooks.Visible = false;
        }


        // TÜM KİTAPLAR
        private void LoadBooks()
        {
            _allBooks = _bookService.GetBooks();

            _bsBooks.DataSource = _allBooks;
            dgvBooks.DataSource = _bsBooks;

            dgvBooks.Columns["BookId"].HeaderText = "Kitap Numarası";
            dgvBooks.Columns["BookName"].HeaderText = "Kitap Adı";
            dgvBooks.Columns["Author"].HeaderText = "Yazar";
            dgvBooks.Columns["Stock"].HeaderText = "Stok Durumu";
        }
        private void txtSearchBooks_TextChanged(object sender, EventArgs e)
        {
            if (_allBooks == null) return;

            string text = txtSearchBooks.Text.ToLower();

            if (string.IsNullOrWhiteSpace(text))
            {
                _bsBooks.DataSource = _allBooks;
                return;
            }

            var filtered = _allBooks
                .Where(b =>
                    (b.BookName ?? "").ToLower().Contains(text) ||
                    (b.Author ?? "").ToLower().Contains(text)
                )
                .ToList();

            _bsBooks.DataSource = filtered;
        }

        private void LoadMyBooks()
        {
            dgvMyBooks.DataSource = null;
            DataTable dt = _borrowService.GetByMemberId(_currentMember.MemberId);
            dgvMyBooks.DataSource = dt;

           
            foreach (DataGridViewRow row in dgvMyBooks.Rows)
            {
                
                if (row.Cells["Son Teslim Tarihi"].Value != null && row.Cells["Son Teslim Tarihi"].Value != DBNull.Value)
                {
                    DateTime dueDate = Convert.ToDateTime(row.Cells["Son Teslim Tarihi"].Value);

                    if (dueDate < DateTime.Now)
                    {
                        
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    
                        row.DefaultCellStyle.SelectionForeColor = Color.Red;

                        row.DefaultCellStyle.Font = new Font(dgvMyBooks.Font, FontStyle.Bold);
                    }
                }
            }
        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }

        private void btnBooks_Click_1(object sender, EventArgs e)
        {
            HideAllGrids();
            dgvBooks.Visible = true;
            LoadBooks();
        }

        private void btnMyBooks_Click_1(object sender, EventArgs e)
        {
            HideAllGrids();
            dgvMyBooks.Visible = true;
            LoadMyBooks();
        }

        private void btnRequest_Click_1(object sender, EventArgs e)
        {
            BookRequestForm frm = new BookRequestForm(_currentMember);
            frm.ShowDialog();
        }

        private void dgvMyBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMyBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            
        }
    }
}


