using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_Laptop_Creator
{
    public class LaptopFactory
    {
        public ILaptop GetLaptop(string laptopName)
        {
            if (string.IsNullOrEmpty(laptopName))
                return null;
            else if (laptopName.ToUpper().Equals("ASUS"))
                return new AsusLaptop();
            else if (laptopName.ToUpper().Equals("HP"))
                return new HPLaptop();
            else if (laptopName.ToUpper().Equals("DELL"))
                return new DELLLaptop();
            else if (laptopName.ToUpper().Equals("MSI"))
                return new MSILaptop();
            return null;
        }
    }
}
