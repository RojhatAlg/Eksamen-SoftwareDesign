using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NettButikk
{
    internal class Money
    {
        private static int totalCost;
        public static int totalBalance;
        private CustomerDataBase customerData = new CustomerDataBase();
        private Customer customer = new Customer();

        


        public static int TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public static int TotalBalance
        {
            get { return totalBalance; }
            set { totalBalance = value; }
        }

        





        public int ReturnTotal()
        {
            int customerId = customerData.InsertCustomer(customer.CustomerName, customer.CustomerWallet);
            Customer thisCustomer = customerData.ReadCustomer(customerId);
            TotalBalance = thisCustomer.CustomerWallet;



            return TotalBalance;
        }










    }

}
