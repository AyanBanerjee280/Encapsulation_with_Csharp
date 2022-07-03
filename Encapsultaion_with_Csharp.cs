using System;
namespace Encapsulation_with_Csharp
{//Encapsulate data with GetBalance and SetBalance method
    class Account
    {
        int AccountBalance = 100;
        public void setBalance(int Amount)
        {
            if(Amount < 0)
            {
                Console.WriteLine("Negative values cannot be assigned.");
            }
            else
            {
                AccountBalance = Amount;
            }
        }
        public void getBalance()
        {
            Console.WriteLine("The balance in your account is " + AccountBalance + ".");
        }
    }
    class Encapsultaion_with_Csharp
    {
        static void Main(string[] args)
        {
            Account obj = new Account();
            obj.setBalance(4500);
            obj.getBalance();
            Console.ReadLine();
        }
    }
}
