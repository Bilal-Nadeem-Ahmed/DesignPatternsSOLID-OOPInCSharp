using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Coupling
{
    internal interface INotificationService
    {
        void SendNotification(string message);
    }
}
