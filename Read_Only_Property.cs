using System;
namespace Encapsulation_with_Csharp
{//Read Only Property of Encapsulation
    class Account
    {
        int AccountBalance = 40000;
        public int Balance
        {
            get
            {
                return AccountBalance;
            }
        }
    }
    class Encapsultaion_with_Csharp2
    {
        static void Main(string[] args)
        {
            Account obj = new Account();
            Console.WriteLine("The balance in your account is " + obj.Balance);
            Console.ReadLine();
        }
    }
}
