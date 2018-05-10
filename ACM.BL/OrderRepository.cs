using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order();

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2008, 5, 1, 8, 6, 32, new TimeSpan(1, 0, 0));
            }

            return order;
        }

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            if (orderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(1, 0, 0));
                orderDisplay.ShippingAddress = new Address()
                {
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };

                orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();

                if (orderId == 10)
                {
                    var orderDisplayItem = new OrderDisplayItem()
                    {
                        ProductName = "Sunflowers",
                        PuchasePrice = 15.96M,
                        OrderQuantity = 2
                    };
                    orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);

                    orderDisplayItem = new OrderDisplayItem()
                    {
                        ProductName = "Rake",
                        PuchasePrice = 6M,
                        OrderQuantity = 1
                    };
                    orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
                }
            }
            return orderDisplay;
        }

        public bool Save(Order order)
        {
            var success = true;

            if (order.HasChanges && order.IsValid)
            {
                if (order.IsNew)
                {
                }
                else
                {

                }
            }
            return success;
        }
    }
}
