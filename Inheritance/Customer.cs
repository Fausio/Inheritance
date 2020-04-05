using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Customer
    {
        protected int CustomerId { get; set; }
        protected string Name { get; set; }
        protected string Email { get; set; }

        public void Details()
        {
            Console.WriteLine("ID:{0}, Name:{1}, Email{2}", this.CustomerId, this.Name, this.Email);
        }

        public Customer()
        {
            Console.WriteLine("Customer Construtor");
        }

        public Customer(int CustomerId, string Name, string Email)
        {
            this.CustomerId = CustomerId;
            this.Name = Name;
            this.Email = Email;

        }
    }
}
