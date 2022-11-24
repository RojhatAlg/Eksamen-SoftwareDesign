using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NettButikk
{
    internal class Customer
    {
        private string customerName;
        private string customerWallet;

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

    }
}
