using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Management
{
    public class Order
    {
        List<OrderItem> OrderItems = new List<OrderItem>();

        public void AddItem(MenuItem item, int qunatity)
        {
            OrderItems.Add(new OrderItem(item, qunatity));

        }

        public double CalculateTotal()
        {
            double total = 0;

            foreach(var orderItem in OrderItems)
            {
                total += orderItem.CalculateItemCost();
            }

            return total;
        }

        public void DisplayOrder()
        {
            foreach(var orderItem in OrderItems)
            {
                Console.WriteLine($"{orderItem.Item.Name} ---- {orderItem.Quantity} x {orderItem.Item.Price} = {orderItem.CalculateItemCost()}");
            }
        }

        public void GenerateBill()
        {
            Console.WriteLine();
            DisplayOrder();
            Console.WriteLine($"----- Total Bill = {CalculateTotal()} Tk");
            Console.WriteLine();
        }
    }
}
