using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Laptop_Creator
{
    public class HPLaptop : ILaptop
    {
        public string GetLaptopDetails()
        {
            return "This is a HP laptop!";
        }
    }
}
