using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Coupling
{
    internal class SmsSender: INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending SMS with message: " + message);
        }
    }
   
}
