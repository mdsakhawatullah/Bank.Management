using System;

namespace Restaurant.Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurent restaurant = new Restaurent();

            restaurant.DisplayMenu();
            restaurant.TakeOrder();
               

            
        }
    }

}