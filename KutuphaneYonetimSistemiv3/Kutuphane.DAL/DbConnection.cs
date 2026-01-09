using Kutuphane.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DbConnection
{
    protected MySqlConnection connection = new MySqlConnection("server=172.21.54.253;database=26_132430042;uid=26_132430042;pwd=İnif123.;");
    
    
    public class BookDAL : DbConnection
    {
        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Books", connection);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                books.Add(new Book
                {
                    BookId = Convert.ToInt32(dr["BookId"]),
                    BookName = dr["BookName"].ToString(),
                    Author = dr["Author"].ToString(),
                    Stock = Convert.ToInt32(dr["Stock"])
                });
            }

            connection.Close();
            return books;
        }
        public void AddBook(Book book)
        {
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO Books (BookName, Author, Stock) VALUES (@name, @author, @stock)",
                connection);

            cmd.Parameters.AddWithValue("@name", book.BookName);
            cmd.Parameters.AddWithValue("@author", book.Author);
            cmd.Parameters.AddWithValue("@stock", book.Stock);

            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }

    public void DeleteBook(int bookId)
    {
        connection.Open();

        MySqlCommand cmd = new MySqlCommand(
            "DELETE FROM Books WHERE BookId = @id",
            connection);

        cmd.Parameters.AddWithValue("@id", bookId);
        cmd.ExecuteNonQuery();

        connection.Close();
    }
    public void UpdateBook(Book book)
    {
        connection.Open();

        MySqlCommand cmd = new MySqlCommand(
            "UPDATE Books SET BookName=@name, Author=@author, Stock=@stock WHERE BookId=@id",
            connection);

        cmd.Parameters.AddWithValue("@name", book.BookName);
        cmd.Parameters.AddWithValue("@author", book.Author);
        cmd.Parameters.AddWithValue("@stock", book.Stock);
        cmd.Parameters.AddWithValue("@id", book.BookId);

        cmd.ExecuteNonQuery();
        connection.Close();
    }
}
