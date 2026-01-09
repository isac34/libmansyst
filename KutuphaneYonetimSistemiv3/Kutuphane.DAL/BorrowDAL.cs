using Kutuphane.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BorrowDAL : DbConnection
{
    public void BorrowBook(Borrow borrow)
    {
        connection.Open();

        MySqlCommand cmd = new MySqlCommand(
            "INSERT INTO Borrows (BookId, MemberId, BorrowDate, DueDate) " +
            "VALUES (@bookId, @memberId, CURDATE(), @dueDate)",
            connection);

        cmd.Parameters.AddWithValue("@bookId", borrow.BookId);
        cmd.Parameters.AddWithValue("@memberId", borrow.MemberId);
        cmd.Parameters.AddWithValue("@dueDate", borrow.DueDate);

        cmd.ExecuteNonQuery();

        // Stok düş
        MySqlCommand stockCmd = new MySqlCommand(
            "UPDATE Books SET Stock = Stock - 1 WHERE BookId=@id",
            connection);
        stockCmd.Parameters.AddWithValue("@id", borrow.BookId);
        stockCmd.ExecuteNonQuery();

        connection.Close();
    }

    public void ReturnBook(int borrowId, int bookId)
    {
        connection.Open();

        MySqlCommand cmd = new MySqlCommand(
            "UPDATE Borrows SET ReturnDate = CURDATE() WHERE BorrowId=@id",
            connection);
        cmd.Parameters.AddWithValue("@id", borrowId);
        cmd.ExecuteNonQuery();

        // Stok arttır
        MySqlCommand stockCmd = new MySqlCommand(
            "UPDATE Books SET Stock = Stock + 1 WHERE BookId=@bid",
            connection);
        stockCmd.Parameters.AddWithValue("@bid", bookId);
        stockCmd.ExecuteNonQuery();

        connection.Close();
    }

    public DataTable GetActiveBorrows()
    {
        DataTable table = new DataTable();
        connection.Open();

        MySqlDataAdapter da = new MySqlDataAdapter(
            @"SELECT b.BorrowId,m.FirstName,m.LastName,bo.BookName,b.BorrowDate,b.DueDate
              FROM Borrows b
              JOIN Members m ON b.MemberId = m.MemberId
              JOIN Books bo ON b.BookId = bo.BookId
              WHERE b.ReturnDate IS NULL",connection);

        da.Fill(table);
        connection.Close();
        return table;
    }
    public DataTable GetOverdueBorrows()
    {
        DataTable table = new DataTable();
        connection.Open();

        MySqlDataAdapter da = new MySqlDataAdapter(
            @"SELECT 
            b.BorrowId,
            m.FirstName,
            m.LastName,
            bo.BookName,
            b.BorrowDate,
            b.DueDate
          FROM Borrows b
          JOIN Members m ON b.MemberId = m.MemberId
          JOIN Books bo ON b.BookId = bo.BookId
          WHERE b.ReturnDate IS NULL
            AND b.DueDate < CURDATE()",
            connection);

        da.Fill(table);
        connection.Close();

        return table;
    }
}
