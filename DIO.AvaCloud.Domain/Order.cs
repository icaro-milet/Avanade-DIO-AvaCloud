using System;
using System.Collections.Generic;

namespace DIO.AvaCloud.Domain
{
    public class Order : EntityBase
    {
        public DateTime OrderDate { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public Customer Customer { get; set; }

        public override bool Validate()
        {
            return OrderItems.Count > 0;
        }
    }
}
