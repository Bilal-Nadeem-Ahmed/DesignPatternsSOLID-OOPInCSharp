using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("sending email...");
            Disconnect();
        }
        // by having all these private a user does not need to know or the implementation 
        // all they know is they can send an email 
        // advantage is we can extend the functionality internally and it wont effect any previous implementation

        private void Connect()
        {
            Console.WriteLine("Conecting to email server...");
        }
        private void Authenticate()
        {
            Console.WriteLine("Authenticating...");
        }
        private void Disconnect()
        {
            Console.WriteLine("Disconnecting from email server...");
        }
    }
}
