using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.OopPrinciples.Coupling
{
    internal class Order: IOrder
    {
        private readonly INotificationService _notificationService;
        public Order(INotificationService notificationService) 
        {
            _notificationService = notificationService;
        }
        public void PlaceOrder()
        {
            // add order to db ....

            _notificationService.SendNotification("Your order has been placed successfully.");
        }
    }
}
