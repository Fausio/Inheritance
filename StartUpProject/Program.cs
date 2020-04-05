using Inheritance;
using System;

namespace StartUpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   ○ Deriving a new class from an existing class is caled Inheritance.
                 ○ Existing class is called as Base64FormattingOptions class.
                 ○ New calss is called as derived class
                 ○ Everything from the base class gets inherited except private members 
                  
                            ############### Type Of Inheretances  #########
                 ○ Simgle Inheritance: If derived class has a single base class then it is called as single inheritance...i.e, A(Base) --> B (Derived)         
                 ○ Multilevel Inheritance: If a class is derived from a class which is already a derived class then it is called as multi level inheritance... i.e, A(Base) --> B (Derived) --> C(Derived) ...
                 ○ Multiple Inheritance: If a class is derived from more than one class then it is called as which is already a derived class thn it is called as multiple inheritanec i,e ... i.e, A(Base) --> B (Derived) --> C(Derived) ... 
                         
                            ############### Protected Members  #########    
                 ○ Procted members of a class can be inherited in the child class.
                 ○ Protected members of a class cannot be accessed from outside of a class.

                            ############### Constructor Chaining (Or) Base Keywords  #########    
                 ○ Default construtor of child class always invokes defoult construtor of base class.
                 ○ Calling the base class construtor from the child class construtor using base keyword is called as construtor chaining.
                 ○ base keyword is a default object of its base class
                 ◘ It also use to refer the members of base class from deriveed class
           
             * * */
            #region Simgle Inheritance classes
            //Customer customer = new Customer()
            //{
            //    CustomerId = 1,
            //    Name = "Fausio",
            //    Email = "Luisfausio@gmail.com"
            //};
            //customer.Details();

            //BankCustomer bankCustomer = new BankCustomer()
            //{
            //    CustomerId = 1,
            //    Name = "Luis",
            //    Email = "Luisfausio@gmail.com",
            //    AcountNumber = 951753456,
            //    Balance = 9999999999.07
            //};
            //bankCustomer.Details();
            //bankCustomer.BankCustomerDetails();
            #endregion
            #region Multilevel Inheritance classes

            LoanCustomer loanCustomer = new LoanCustomer(1,"Fausio","Luisfausio@gmail.com",951753456,99999.99,14.8);
            #endregion


            Console.ReadKey();
        }
    }
}
