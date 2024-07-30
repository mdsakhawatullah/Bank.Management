using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Management
{
    public class Restaurent
    {
        public List<MenuItem> MenuItems = new List<MenuItem>();
        public Order CurrentOrder = new Order();
        public string more { get; set; }

        public void DisplayMenu()
        {
            // Adding some default menu items
            MenuItems.Add(new MenuItem(1, "French Fries", 250.0));
            MenuItems.Add(new MenuItem(2, "Pizza", 800.0));
            MenuItems.Add(new MenuItem(3, "Salad", 500.0));
            MenuItems.Add(new MenuItem(4, "Coffee", 300.0));
            MenuItems.Add(new MenuItem(5, "Mojo", 60.0));
            MenuItems.Add(new MenuItem(6, "Water", 20.0));

            Console.WriteLine("-----Welcome To Our Restaurent-----");
            foreach(var item in MenuItems)
            {
                Console.WriteLine($"{item.Id}.  {item.Name} = {item.Price} Tk ");
            }
            Console.WriteLine("-------------------------------------");
        }

        public void TakeOrder()
        {
           
            while (true)
            {
               
                Console.WriteLine("Enter your choise (0 to exit): ");
                int itemNumber = int.Parse(Console.ReadLine());

                if (itemNumber == 0)
                    ExitSystem();

                if( itemNumber > 0 && itemNumber<= MenuItems.Count)
                {
                    Console.Write("Enter the quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                    CurrentOrder.AddItem(MenuItems[itemNumber - 1], quantity);

                    Console.WriteLine();
                    Console.WriteLine("Would you add anything else ? (Yes/No)");
                    more = Console.ReadLine();

                    if (more == "yes")
                        TakeOrder();
                    else if (more == "no")
                    {
                        CurrentOrder.GenerateBill();
                        ExitSystem();
                    }
                    else
                        Console.WriteLine("Invalid option");

                }
                else
                {
                    Console.WriteLine("Invalid menu item number. Please try again.");
                }
            }

            
        }



        public void ExitSystem()
        {
            Console.WriteLine("Exiting the system...");
            Environment.Exit(0);
        }


    }
}
