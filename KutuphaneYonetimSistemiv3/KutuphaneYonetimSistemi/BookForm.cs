using Kutuphane.BBL;
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
    public partial class BookForm : Form
    {
        private Member _user;
        private DataTable _booksTable;
        private List<Book> _bookList;
        private BindingSource _bs = new BindingSource();
        public BookForm(Member user)
        {
            InitializeComponent();
            _user = user;
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            BookService service = new BookService();
            _bookList = service.GetBooks();

            _bs.DataSource = _bookList;
            dataGridView1.DataSource = _bs;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string text = txtSearch.Text.ToLower();

            var filtered = _bookList
                .Where(b =>
                    b.BookName.ToLower().Contains(text) ||
                    b.Author.ToLower().Contains(text))
                .ToList();

            _bs.DataSource = filtered;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBookName.Text == "" || txtAuthor.Text == "" || txtStock.Text == "")
                {
                    MessageBox.Show("Tüm alanları doldurun");
                    return;
                }

                Book book = new Book
                {
                    BookName = txtBookName.Text,
                    Author = txtAuthor.Text,
                    Stock = int.Parse(txtStock.Text)
                };

                BookService service = new BookService();
                service.AddBook(book);

                MessageBox.Show("Kitap eklendi");
                dataGridView1.DataSource = service.GetBooks();
                _bookList = service.GetBooks();
                _bs.DataSource = _bookList;
            }
            catch (FormatException)
            {
                MessageBox.Show("Stok sadece sayı olmalıdır");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silinecek kitabı seçin");
                    return;
                }

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BookId"].Value);
                BookService service = new BookService();
                service.DeleteBook(id);

                MessageBox.Show("Kitap silindi");
                dataGridView1.DataSource = service.GetBooks();
                _bookList = service.GetBooks();
                _bs.DataSource = _bookList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookName.Text = dataGridView1.CurrentRow.Cells["BookName"].Value.ToString();
            txtAuthor.Text = dataGridView1.CurrentRow.Cells["Author"].Value.ToString();
            txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen kitap seçin");
                    return;
                }

                Book book = new Book
                {
                    BookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BookId"].Value),
                    BookName = txtBookName.Text,
                    Author = txtAuthor.Text,
                    Stock = int.Parse(txtStock.Text)
                };

                BookService service = new BookService();
                service.UpdateBook(book);

                MessageBox.Show("Kitap güncellendi");
                dataGridView1.DataSource = service.GetBooks();
                _bookList = service.GetBooks();
                _bs.DataSource = _bookList;
            }
            catch (FormatException)
            {
                MessageBox.Show("Stok alanına sadece sayı girin");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }
    }
}
