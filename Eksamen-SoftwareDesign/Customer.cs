using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NettButikk
{
    internal class Customer
    {
        private string customerName;
        private int customerWallet;
        private int customerTotalBalance;
        private CustomerDataBase customerData = new CustomerDataBase();

        public Customer()
        {
        }


        public Customer(string customerName, int customerWallet)
        {
            this.customerName = customerName;
            this.customerWallet = customerWallet;
        }

        public int CustomerTotalBalance { get { return customerTotalBalance; } set { customerTotalBalance = value; } }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public int CustomerWallet
        {
            get { return customerWallet; }
            set { customerWallet = value; }
        }

        public void DisplayCustomers()
        {
            WriteLine("==============================================");
            WriteLine("CUSTOMERS");
            CreateCustomer();
            WriteLine("Choose a Customer between 'a' or 'b'");
            string chosenCustomer = ReadLine();

            CustomerDataBase db_customer = new();
            db_customer.CreateDbAndTable();

            int firstCustomerId = db_customer.InsertCustomer("Jonas", 5000);
            int secondCustomerId = db_customer.InsertCustomer("Mohammed", 10000);

            Customer firstCustomerCreated = db_customer.ReadCustomer(firstCustomerId);
            Customer secondCustomerCreated = db_customer.ReadCustomer(secondCustomerId);



            if (chosenCustomer == "a")
            {
                WriteLine($"You choose '{firstCustomerCreated.CustomerName}'\n" + $"Your total Balance is: '{firstCustomerCreated.CustomerWallet}'\n");
                int CustomerTotalBalance = firstCustomerCreated.CustomerWallet;
                
            }

            if (chosenCustomer == "b")
            {
                WriteLine($"You choose '{secondCustomerCreated.CustomerName}'\n" + $"Your total Balance is: '{secondCustomerCreated.CustomerWallet}'\n");
                int CustomerTotalBalance = firstCustomerCreated.CustomerWallet;
            }
            WriteLine("==============================================");

        }

        public void CreateCustomer()
        {
            CustomerDataBase db_customer = new();
            db_customer.CreateDbAndTable();

            int firstCustomerId = db_customer.InsertCustomer("Jonas", 5000);
            int secondCustomerId = db_customer.InsertCustomer("Mohammed", 10000);

            Customer firstCustomerCreated = db_customer.ReadCustomer(firstCustomerId);
            Customer secondCustomerCreated = db_customer.ReadCustomer(secondCustomerId);

            Console.WriteLine($"First Customer:  '{firstCustomerCreated.CustomerName}'" + $" '{firstCustomerCreated.CustomerWallet}' kroner ");
            Console.WriteLine($"Secound Customer:  '{secondCustomerCreated.CustomerName}'" + $" '{secondCustomerCreated.CustomerWallet}' kroner ");
        }


    }

    
}
