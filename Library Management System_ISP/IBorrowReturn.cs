using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_ISP
{
    public interface IBorrowReturn
    {
        void BorrowBook(string bookId);
        void ReturnBook(string bookId);
    }
}
