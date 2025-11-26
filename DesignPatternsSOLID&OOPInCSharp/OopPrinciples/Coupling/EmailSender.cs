using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Coupling
{
    internal class EmailSender: INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending email with message: " + message);
        }
    }
}
