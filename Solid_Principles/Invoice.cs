using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    public class Invoice
    {
        public long InvAmount { get; set; }
        public DateTime InvDate { get; set; }
        private ILogger fileLogger;
        private MailSender emailSender;
        public Invoice()
        {
            fileLogger = new Logger();
            emailSender = new MailSender();
        }

        public void AddInvoice()
        {
            try
            {
                fileLogger.Info("Add method Start");
                // Here we need to write the Code for adding invoice
                // Once the Invoice has been added, then send the  mail
                emailSender.EMailFrom = "ukfarhana@gmail.com";
                emailSender.EMailTo = "hello23@gmail.com";
                emailSender.EMailSubject = "Single Responsibility Principle";
                emailSender.EMailBody = "A class should have only one reason to change";
                emailSender.SendEmail();
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error Occurred while Generating Invoice", ex);
            }
        }

        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
                fileLogger.Info("Delete Invoice Start at @" + DateTime.Now);
            }
            catch(Exception ex)
            {
                fileLogger.Error("Error Occurred while Deleting Invoice", ex);
            }
        }
    }
}
