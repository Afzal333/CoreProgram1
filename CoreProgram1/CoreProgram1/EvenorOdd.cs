using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProgram1
{
    public class EvenorOdd
    {
        public void EvenOdd()
        {
            Console.WriteLine("Enter the value to check Even or Odd");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
                Console.WriteLine("Given Number " + i + " is Even.");
            else
                Console.WriteLine("Given Number " + i + " is Odd.");
        }
    }
}
