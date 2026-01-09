using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Kutuphane.DAL;

namespace Kutuphane.BLL
{
    public class BookRequestService
    {
        BookRequestDAL dal = new BookRequestDAL();

        public void AddRequest(int memberId, string bookName, string author)
        {
            dal.AddRequest(memberId, bookName, author);
        }

        public DataTable GetAllRequests()
        {
            return dal.GetAllRequests();
        }

        public void Approve(int requestId)
        {
            dal.UpdateStatus(requestId, "Onaylandı");
        }

        public void Reject(int requestId)
        {
            dal.UpdateStatus(requestId, "Reddedildi");
        }
    }
}
