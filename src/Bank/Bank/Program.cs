﻿using Bank.Presentation;
using System;
class Program
{
    
    static void Main()
    {
        
        Console.WriteLine("************** Bank *****************");
        Console.WriteLine("::Login Page::");

        
        string userName = null, password = null;

       
        Console.Write("Username: ");
        userName = Console.ReadLine();

        
        if (userName != "")
        {
            Console.Write("Password: ");
            password = Console.ReadLine();
        }

        
        if (userName == "system" && password == "admin")
        {
            
            int mainMenuChoice = -1;

            do
            {
                
                Console.WriteLine("\n:::Main menu:::");
                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Accounts");
                Console.WriteLine("3. Funds Transfer");
                Console.WriteLine("4. Funds Transfer Statement");
                Console.WriteLine("5. Account Statement");
                Console.WriteLine("0. Exit");

               
                Console.Write("Enter choice: ");
                mainMenuChoice = int.Parse(Console.ReadLine());

                
                switch (mainMenuChoice)
                {
                    case 1: CustomersMenu(); break;
                    case 2: AccountsMenu(); break;
                    case 3: 
                        break;
                    case 4: 
                        break;
                    case 5: 
                        break;
                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            Console.WriteLine("Invalid username or password");
        }

        
        Console.WriteLine("Thank you! Visit again.");
        Console.ReadKey();
    }

    static void CustomersMenu()
    {
        
        int customerMenuChoice = -1;

       
        do
        {
            Console.WriteLine("\n:::Customers menu:::");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Delete Customer");
            Console.WriteLine("3. Update Customer");
            Console.WriteLine("4. Search Customers");
            Console.WriteLine("5. View Customers");
            Console.WriteLine("0. Back to Main Menu");

           
            Console.Write("Enter choice: ");
            customerMenuChoice = Convert.ToInt32(Console.ReadLine());

            
            switch (customerMenuChoice)
            {
                case 1: CustomersPresentation.AddCustomer(); break;
                case 5: CustomersPresentation.ViewCustomers(); break;
            }
        } while (customerMenuChoice != 0);
    }


    static void AccountsMenu()
    {
        //variable to store accounts menu choice
        int accountsMenuChoice = -1;

        //do-while loop starts
        do
        {
            //print  accounts menu
            Console.WriteLine("\n:::Accounts menu:::");
            Console.WriteLine("1. Add Account");
            Console.WriteLine("2. Delete Account");
            Console.WriteLine("3. Update Account");
            Console.WriteLine("4. View Accounts");
            Console.WriteLine("0. Back to Main Menu");

            //accept accounts menu choice
            Console.Write("Enter choice: ");
            accountsMenuChoice = Convert.ToInt32(Console.ReadLine());
        } while (accountsMenuChoice != 0);
    }
}


