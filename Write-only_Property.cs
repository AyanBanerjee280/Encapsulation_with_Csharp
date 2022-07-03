using System;
namespace Encapsulation_with_Csharp
{//Write-only property
    class Account
    {
        int AccountBalance = 4;
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
            
        }
    }
    class get_set_method
    {
        static void Main(string[] args)
        {
            Account obj = new Account();
            obj.Balance = -55;
            
            Console.ReadLine();
        }
    }
}
