using System;
namespace Encapsulation
{
    class car
    {
        int mileage = 0;
        public void setMileage(int km)
        {

            if (km < 15)
            {
                Console.WriteLine("Mileage is too low.");
            }
            else
            {
                mileage = km;
            }
        }
        public void getMileage()
        {
            Console.WriteLine("The mileage of this car is " + mileage + " kmpl.");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            car obj = new car();
            obj.setMileage(21);
            obj.getMileage();
            Console.ReadLine();
        }
    }
}
