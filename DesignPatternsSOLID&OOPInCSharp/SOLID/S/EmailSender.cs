using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.SOLID.S
{
    internal class EmailSender
    {
        public EmailSender() { }

        public void SendEmail(string email, string message)
        {
           Console.WriteLine($"sending email to {email}: {message}");
        }
    }
}
