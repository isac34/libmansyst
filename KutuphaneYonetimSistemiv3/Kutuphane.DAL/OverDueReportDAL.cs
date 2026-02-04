using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kutuphane.DAL
{
    public class ReportDAL
    {
        MySqlConnection connection = new MySqlConnection(
            "server=172.21.54.253;database=26_132430042;uid=26_132430042;pwd=İnif123.;");

        public (int Toplam, int Oduncte) GetKitapStatuSayilari()
        {
            int toplam = 0;
            int oduncte = 0;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

              
                string q1 = "SELECT SUM(Stock) FROM Books";
                using (MySqlCommand cmd1 = new MySqlCommand(q1, connection))
                {
                    toplam = Convert.ToInt32(cmd1.ExecuteScalar());
                }
                string q2 = "SELECT COUNT(*) FROM Borrows WHERE ReturnDate IS NULL";
                using (MySqlCommand cmd2 = new MySqlCommand(q2, connection))
                {
                    oduncte = Convert.ToInt32(cmd2.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception("Kitap sayıları alınırken hata oluştu: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return (toplam, oduncte);
        }
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
        public DataTable GetBorrowStats()
        {
            DataTable table = new DataTable();
            using (MySqlConnection conn = new MySqlConnection("server = 172.21.54.253; database = 26_132430042; uid = 26_132430042; pwd = İnif123.; "))
            {
                string query = @"SELECT DATE(BorrowDate) as Tarih, COUNT(*) as Adet 
                         FROM Borrows 
                         WHERE BorrowDate >= DATE_SUB(CURDATE(), INTERVAL 30 DAY)
                         GROUP BY DATE(BorrowDate) 
                         ORDER BY Tarih ASC";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(table);
            }
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
