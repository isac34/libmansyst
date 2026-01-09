using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.Entities;

public class MemberService
{
    MemberDAL dal = new MemberDAL();

    public List<Member> GetMembers()
    {
        return dal.GetAllMembers();
    }

    public void AddMember(Member member)
    {
        if (member.FirstName == "" || member.LastName == "")
            throw new Exception("Ad ve Soyad zorunlu");

        dal.AddMember(member);
    }

    public void UpdateMember(Member member)
    {
        dal.UpdateMember(member);
    }

    public void DeleteMember(int id)
    {
        dal.DeleteMember(id);
    }
    public Member Login(string username, string password)
    {
        return dal.Login(username, password);
    }

}