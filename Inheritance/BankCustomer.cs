using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class BankCustomer : Customer
    {
        protected int AcountNumber { get; set; }
        protected double Balance { get; set; }


        public void BankCustomerDetails()
        {
            Console.WriteLine("Acount number:{0}, Balance:{1}", this.AcountNumber, this.Balance);
        }

        public BankCustomer()
        {
            Console.WriteLine("Bank Customer");
        }


        public BankCustomer(int CustomerId, string Name, string Email, int AcountNumber, double Balance)
            : base(CustomerId, Name, Email)
        {
            this.AcountNumber = AcountNumber;
            this.Balance = Balance;
        }

    }
}
