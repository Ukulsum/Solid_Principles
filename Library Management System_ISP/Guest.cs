using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_ISP
{
    public class Guest : ISearchable
    {
        public void SearchCatalog(string searchTerm)
        {
            // Implementation to search books.
            Console.WriteLine($"Guest Search Book, Search Catalog: {searchTerm}");
        }
    }
}
