using System;
namespace Encapsulation
{
    class BookPrice
    {
        int price = 0;
        public int bookPrice
        {
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Negative values cannot be passed.");
                }
                else
                {
                    price = value;
                }
            }
            get
            {
                return price;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BookPrice obj = new BookPrice();
            obj.bookPrice = 500;
            Console.WriteLine("The price for the selected book is " + obj.bookPrice);
            Console.ReadLine();
        }
           
    }
}
