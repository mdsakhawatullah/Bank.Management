using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Management
{
    public class OrderItem
    {
        public MenuItem Item { get; set; }
        public int Quantity { get; set; }

        public OrderItem(MenuItem item, int quantity)
        { 
            Item = item;
            Quantity = quantity;
        }

        public double CalculateItemCost()
        {
            return Item.Price * Quantity;
        }

    }
}
