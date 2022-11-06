using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProgram1
{
    public class LargestNumber
    {
        public void ThirdLargestNumber()
        {
            Console.WriteLine("Enter the Three Numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a + " is Larger than " + b + " and " + c);
                if (a > c)
                {
                    Console.WriteLine(a + " is Larger than " + b + " and " + c);
                }
            }
            else if (b > c)
            {
                Console.WriteLine(b + " is Larger than " + a + " and " + c);
            }
            else
            {
                Console.WriteLine(c + " is Larger than " + a + " and " + b);
            }
        }
    }
}
