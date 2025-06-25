using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSOLIDPrinciples.DIP
{
    public class NotificationService
    {
        private readonly EmailSender _emailSender;
        //NotificationService class that directly depends on a EmailSender class.
        public NotificationService()
        {
            _emailSender = new EmailSender(); //tightly coupled 
        }
        private readonly IMessageSender _messageSender;
        public NotificationService(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

       

    }
    public interface IMessageSender
    {
        void SendMessage(string message);
    }
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            //send email logic
        }
    }

    internal class Demo1
    {
    }
}
