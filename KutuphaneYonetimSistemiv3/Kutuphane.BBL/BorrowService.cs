using Kutuphane.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BorrowService
{
    BorrowDAL dal = new BorrowDAL();

    public void BorrowBook(Borrow borrow)
    {
        dal.BorrowBook(borrow);
    }

    public void ReturnBook(int borrowId, int bookId)
    {
        dal.ReturnBook(borrowId, bookId);
    }

    public DataTable GetActiveBorrows()
    {
        return dal.GetActiveBorrows();
    }
    public DataTable GetOverdueBorrows()
    {
        return dal.GetOverdueBorrows();
    }
    private BorrowDAL _borrowDal = new BorrowDAL();
    public DataTable GetByMemberId(int memberId)
    {
        return _borrowDal.GetByMemberId(memberId);
    }

}
