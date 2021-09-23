using System;
using System.Collections.Generic;

namespace DIO.AvaCloud.Domain
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public Customer Customer { get; set; }
    }
}
