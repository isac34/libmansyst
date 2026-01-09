using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Kutuphane.DAL
{
    public class BookRequestDAL
    {
        MySqlConnection connection = new MySqlConnection(
            "server=172.21.54.253;database=26_132430042;uid=26_132430042;pwd=İnif123.;");

        public void AddRequest(int memberId, string bookName, string author)
        {
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(
                @"INSERT INTO BookRequests 
                  (MemberId, BookName, Author, RequestDate, Status)
                  VALUES (@mid, @book, @author, CURDATE(), 'Beklemede')",
                connection);

            cmd.Parameters.AddWithValue("@mid", memberId);
            cmd.Parameters.AddWithValue("@book", bookName);
            cmd.Parameters.AddWithValue("@author", author);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable GetAllRequests()
        {
            DataTable table = new DataTable();
            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(
                @"SELECT 
                    r.RequestId,
                    m.FirstName,
                    r.BookName,
                    r.Author,
                    r.RequestDate,
                    r.Status
                  FROM BookRequests r
                  JOIN Members m ON r.MemberId = m.MemberId",
                connection);

            da.Fill(table);
            connection.Close();
            return table;
        }

        public void UpdateStatus(int requestId, string status)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(
                "UPDATE BookRequests SET Status=@s WHERE RequestId=@id",
                connection);

            cmd.Parameters.AddWithValue("@s", status);
            cmd.Parameters.AddWithValue("@id", requestId);

            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
