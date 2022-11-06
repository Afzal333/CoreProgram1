using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProgram1
{
    public class SwapTwoNumbers
    {
        public void Swap()
        {
            Console.WriteLine("Enter the First Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swap a={0} & b={1}",a,b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swap a={0} & b={1}",a,b);
        }       
    }
}
