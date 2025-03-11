using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_ISP
{
    public class Librarian : IBorrowReturn, ISearchable, IManageInventory
    {
        public void BorrowBook(string bookId)
        {
            // Implementation to borrow a book.
            Console.WriteLine($"Member Borrow Book, BookId: {bookId}");
        }

        public void RemoveBook(string bookId)
        {
            // Implementation to return a book.
            Console.WriteLine($"Member Return Book, BookId: {bookId}");
        }
        public void AddBook(Book book)
        {
            // Implementation to add a book.
            Console.WriteLine($"Librarian Add Book, {book}");
        }

        public void ReturnBook(string bookId)
        {
            // Implementation to remove a book.
            Console.WriteLine($"Librarian Remove Book, BookId: {bookId}");
        }

        public void SearchCatalog(string searchTerm)
        {
            // Implementation to search books.
            Console.WriteLine($"Librarian Search Book, Search Catalog: {searchTerm}");
        }
    }
}
