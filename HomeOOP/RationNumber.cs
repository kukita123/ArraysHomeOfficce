using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeOOP
{
    class RationNumber
    {
        int numerator;
        int denominator;

        public RationNumber()
        {
            denominator = 1;
        }
        public RationNumber(int numerator, int denominator)
        {
            if (denominator != 0)
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
            else
            {
                Console.WriteLine("Wrong denominator, it can not be 0, setting it to 1");
                this.numerator = numerator;
                this.denominator = 1;                  
            }
        }
        public void DisplayData()
        {
            Console.WriteLine("The rational number is: {0}/{1}",this.numerator,this.denominator);
        }
    }
}
