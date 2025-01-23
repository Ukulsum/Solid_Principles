using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_managementofbooksinalibrary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LibraryBook book = new LibraryBook
            {
                Title = "SOLID Principle",
                Author = "Pranaya Rout",
                ISBN = 125478
            };

            LibraryLogger logger = new LibraryLogger();
            book.AddBook();
            logger.Log($"Added {book.Title} by {book.Author}");

            book.DeleteBook();
            logger.Log($"Deleted {book.Title} by {book.Author}");

            Console.ReadKey();
        }
    }
}
