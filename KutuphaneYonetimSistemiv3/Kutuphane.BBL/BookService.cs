using System.Data;
using Kutuphane.Entities;
using static DbConnection;

namespace Kutuphane.BBL
{
    public class BookService
    {
        BookDAL dal = new BookDAL();

        public List<Book> GetBooks()
        {
            return dal.GetAllBooks();
        }
        
        
        public void AddBook(Book book)
        {
            if (book.Stock < 1)
            throw new Exception("Stok birin altında olamaz");

            dal.AddBook(book);
        }
        public void DeleteBook(int bookId)
        {
            dal.DeleteBook(bookId);
        }
        public void UpdateBook(Book book)
        {
            if (book.Stock < 0)
            throw new Exception("Stok negatif olamaz");
            dal.UpdateBook(book);
        }


    }
}
