using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Kutuphane.DAL;

namespace Kutuphane.BLL
{
    public class ReportService
    {
        ReportDAL dal = new ReportDAL();

        public DataTable LateBooks()
        {
            return dal.GetLateBooks();
        }

        public DataTable TopBooks()
        {
            return dal.GetTopBooks();
        }

        public DataTable TopMembers()
        {
            return dal.GetTopMembers();
        }
    }
}
