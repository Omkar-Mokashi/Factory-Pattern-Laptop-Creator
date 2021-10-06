using System;

namespace Factory_Pattern_Laptop_Creator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling the laptop factory and getting the different laptops.
            LaptopFactory laptopFactory = new LaptopFactory();

            ILaptop laptop1 = laptopFactory.GetLaptop("ASUS");
            Console.WriteLine(laptop1.GetLaptopDetails());

            ILaptop laptop2 = laptopFactory.GetLaptop("MSI");
            Console.WriteLine(laptop2.GetLaptopDetails());

            ILaptop laptop3 = laptopFactory.GetLaptop("HP");
            Console.WriteLine(laptop3.GetLaptopDetails());

            ILaptop laptop4 = laptopFactory.GetLaptop("DELL");
            Console.WriteLine(laptop4.GetLaptopDetails());
        }
    }
}
