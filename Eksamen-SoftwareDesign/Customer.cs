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
            
            
            CustomerDataBase db_customer = new();
            db_customer.CreateDbAndTable();

            int firstCustomerId = db_customer.InsertCustomer("Jonas", 5000);

            Customer firstCustomerCreated = db_customer.ReadCustomer(firstCustomerId);
            WriteLine("==============================================");
            WriteLine("CUSTOMER");
            WriteLine("==============================================");
            WriteLine($"Welcome {firstCustomerCreated.CustomerName}!");
            WriteLine("==============================================");           
            WriteLine($"Name: '{firstCustomerCreated.CustomerName}'\n" + $"Your total Balance is: '${firstCustomerCreated.CustomerWallet}'");        
            WriteLine("==============================================");

            int CustomerTotalBalance = firstCustomerCreated.CustomerWallet;
        }


    }

    
}
