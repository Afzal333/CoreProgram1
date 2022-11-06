using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProgram1
{
    public class PrimeFactor
    {
        public void Factor()
        {
            int count =0;
            Console.WriteLine("Enter number to find PrimeFactors");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                if(num % i == 0)
                {
                    for(int j = 1; j <= i; j++)
                    {
                        if(i%j == 0)
                        {
                            count++;
                        }
                    }
                    if(count == 2)
                    {
                        Console.WriteLine("Prime Factor of number"+" "+ num+ " is:- "+i);
                    }
                    count = 0;
                }
            }
        }
    }
}
