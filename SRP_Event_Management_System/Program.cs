using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Event_Management_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Event concert = new Event { Name = "Rock Concert", Date = DateTime.Now.AddDays(30), Location = " City Arena" };

            EventStorage storage = new EventStorage();
            storage.SaveEvent(concert);

            EventPromoter promoter = new EventPromoter();
            promoter.ShareOnSocialMedia(concert);

            Console.ReadKey();
        }
    }
}
