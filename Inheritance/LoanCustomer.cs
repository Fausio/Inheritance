using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class LoanCustomer : BankCustomer
    {
        protected double LoanAmount { get; set; }

        public LoanCustomer()
        {
            Console.WriteLine("Loan Customer Construtor");
        }

        public LoanCustomer(int CustomerId, string Name, string Email, int AcountNumber, double Balance, double LoanAmount)
            : base(CustomerId, Name, Email, AcountNumber, Balance)

        {
            this.LoanAmount = LoanAmount;
        }
    }
}
