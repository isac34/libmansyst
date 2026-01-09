using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Kutuphane.DAL
{
    public class ReportDAL
    {
        MySqlConnection connection = new MySqlConnection(
            "server=172.21.54.253;database=26_132430042;uid=26_132430042;pwd=İnif123.;");

        
        public DataTable GetLateBooks()
        {
            DataTable table = new DataTable();
            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(
                @"SELECT CONCAT(m.FirstName, ' ', m.LastName) AS FullName,bo.BookName,
                 b.DueDate,
                 DATEDIFF(CURDATE(), b.DueDate) AS LateDays
                 FROM Borrows b
                 JOIN Members m ON b.MemberId = m.MemberId
                 JOIN Books bo ON b.BookId = bo.BookId
                  WHERE b.ReturnDate IS NULL
                 AND b.DueDate < CURDATE()",connection);

            da.Fill(table);
            connection.Close();
            return table;
        }

      
        public DataTable GetTopBooks()
        {
            DataTable table = new DataTable();
            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(
                @"SELECT 
                    bo.BookName,
                    COUNT(*) AS BorrowCount
                  FROM Borrows b
                  JOIN Books bo ON b.BookId = bo.BookId
                  GROUP BY bo.BookName
                  ORDER BY BorrowCount DESC",
                connection);

            da.Fill(table);
            connection.Close();
            return table;
        }

       
        public DataTable GetTopMembers()
        {
            DataTable table = new DataTable();
            connection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(
                @"SELECT 
            CONCAT(m.FirstName, ' ', m.LastName) AS FullName,
            COUNT(*) AS BorrowCount
          FROM Borrows b
          JOIN Members m ON b.MemberId = m.MemberId
          GROUP BY m.FirstName, m.LastName
          ORDER BY BorrowCount DESC",
                connection);

            da.Fill(table);
            connection.Close();
            return table;
        }
    }
}
