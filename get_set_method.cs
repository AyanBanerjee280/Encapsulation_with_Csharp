using System;
namespace Encapsulation_with_Csharp
{//Read Only Property of Encapsulation
    class Account
    {
        int AccountBalance = 40000;
        public int Balance
        {
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Negative values cannot be passed.");
                }
                else
                {
                    AccountBalance = value;
                }
            }
            get
            {
                return AccountBalance;
            }
        }
    }
    class Read_Only_Property
    {
        static void Main(string[] args)
        {
            Account obj = new Account();
            obj.Balance = -55;
            Console.WriteLine("The balance in your account is " + obj.Balance);
            Console.ReadLine();
        }
    }
}
