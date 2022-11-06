using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProgram1
{
    public class QuotientAndRemainder
    {
        public void DivRem()
        {
            Console.WriteLine("Enter the dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int result;

            int quotient = Math.DivRem(dividend,divisor,out result);
            Console.WriteLine("Quotient is " + quotient);
            Console.WriteLine("Remainder is " + result);
        }
    }
}
