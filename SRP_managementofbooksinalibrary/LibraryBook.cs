using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SRP_managementofbooksinalibrary
{
    public class LibraryBook
    {
        public string Title {  get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }


        public void AddBook()
        {
            //Logic to add the book to the library's system
            Console.WriteLine("Book Added to the Library");
        }

        public void DeleteBook()
        {
            //Logic to delete the book from the library's system
            Console.WriteLine("Book Deleted from the Library");
        }
    }
}
