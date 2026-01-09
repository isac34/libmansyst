using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Kutuphane.Entities;

public class MemberDAL : DbConnection
{
    public List<Member> GetAllMembers()
    {
        List<Member> members = new List<Member>();
        connection.Open();

        MySqlCommand cmd = new MySqlCommand(
            "SELECT * FROM Members", connection);

        MySqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            members.Add(new Member
            {
                MemberId = Convert.ToInt32(dr["MemberId"]),
                FirstName = dr["FirstName"].ToString(),
                LastName = dr["LastName"].ToString(),
                Phone = dr["Phone"].ToString(),
                Email = dr["Email"].ToString(),
                Role = dr["Role"].ToString(),


            });
        }

        connection.Close();
        return members;
    }

    public void AddMember(Member member)
    {
        connection.Open();

        MySqlCommand cmd = new MySqlCommand(
            "INSERT INTO Members (FirstName, LastName, Phone, Email, Role, RegisterDate)" +
            "VALUES (@fn, @ln, @ph, @em, @role, CURDATE())",
            connection);

        cmd.Parameters.AddWithValue("@fn", member.FirstName);
        cmd.Parameters.AddWithValue("@ln", member.LastName);
        cmd.Parameters.AddWithValue("@ph", member.Phone);
        cmd.Parameters.AddWithValue("@em", member.Email);
        cmd.Parameters.AddWithValue("@role", member.Role);
        cmd.ExecuteNonQuery();
        connection.Close();
    }
    

    public void UpdateMember(Member member)
    {
        connection.Open();

        MySqlCommand cmd = new MySqlCommand(
            "UPDATE Members SET FirstName=@fn, LastName=@ln, Phone=@ph, Email=@em, Role=@role WHERE MemberId=@id",
            connection);

        cmd.Parameters.AddWithValue("@fn", member.FirstName);
        cmd.Parameters.AddWithValue("@ln", member.LastName);
        cmd.Parameters.AddWithValue("@ph", member.Phone);
        cmd.Parameters.AddWithValue("@em", member.Email);
        cmd.Parameters.AddWithValue("@role", member.Role);
        cmd.Parameters.AddWithValue("@id", member.MemberId);

        cmd.ExecuteNonQuery();
        connection.Close();
    }

    public void DeleteMember(int memberId)
    {
        connection.Open();

        MySqlCommand cmd = new MySqlCommand(
            "DELETE FROM Members WHERE MemberId=@id",connection);

        cmd.Parameters.AddWithValue("@id", memberId);
        cmd.ExecuteNonQuery();

        connection.Close();
    }
    public Member Login(string username, string password)
    {
        connection.Open();

        MySqlCommand cmd = new MySqlCommand(
            "SELECT * FROM Members WHERE Username=@u AND Password=@p",connection);

        cmd.Parameters.AddWithValue("@u", username);
        cmd.Parameters.AddWithValue("@p", password);

        MySqlDataReader dr = cmd.ExecuteReader();

        Member member = null;

        if (dr.Read())
        {
            member = new Member
            {
                MemberId = Convert.ToInt32(dr["MemberId"]),
                FirstName = dr["FirstName"].ToString(),
                LastName = dr["LastName"].ToString(),
                Role = dr["Role"].ToString(),
                Username = dr["Username"].ToString(),
                Password = dr["Password"].ToString()
            };
        }

        connection.Close();
        return member;
         }
    
}


