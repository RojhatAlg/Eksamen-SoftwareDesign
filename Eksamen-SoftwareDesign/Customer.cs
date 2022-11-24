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
        private string customerWallet;

        public Customer()
        {
        }

        public Customer(string customerName, string customerWallet)
        {
            this.customerName = customerName;
            this.customerWallet = customerWallet;
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string CustomerWallet
        {
            get { return customerWallet; }
            set { customerWallet = value; }
        }

        public void DisplayCustomers()
        {
            WriteLine("==============================================");
            WriteLine("CUSTOMERS");
            CreateCustomer();
            WriteLine("==============================================");

        }

        private void CreateCustomer()
        {
            CustomerDataBase db_customer = new();
            db_customer.CreateDbAndTable();

            int firstCustomerId = db_customer.InsertCustomer("Mohammed", "2500");
            int secondCustomerId = db_customer.InsertCustomer("Jonas", "1500");

            Customer firstCustomerCreated = db_customer.ReadCustomer(firstCustomerId);
            Customer secondCustomerCreated = db_customer.ReadCustomer(secondCustomerId);

            Console.WriteLine($"First Customer:  '{firstCustomerCreated.CustomerName}'" + $" '{firstCustomerCreated.CustomerWallet}' kroner ");
            Console.WriteLine($"Secound Customer:  '{secondCustomerCreated.CustomerName}'" + $" '{secondCustomerCreated.CustomerWallet}' kroner ");
        }


    }

    
}
