using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_ISP
{
    public class Member : IBorrowReturn, ISearchable
    {
        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void BorrowBook(string bookId)
        {
            // Implementation to borrow a book.
            Console.WriteLine($"Member Borrow Book, BookId: {bookId}");
        }

        public void RemoveBook(string BookId)
        {
            // Implementation to return a book.
            Console.WriteLine($"Member Return Book, BookId: {BookId}");
        }

        public void ReturnBook(string bookId)
        {
            throw new NotImplementedException();
        }
    }
}
