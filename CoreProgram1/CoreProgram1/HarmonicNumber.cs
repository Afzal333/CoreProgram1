using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProgram1
{
    public class HarmonicNumber
    {
        public void Calculate(int num)
        {
            float result =0;
            for (int i = 1; i <= num; i++)
            {
                Console.Write("1/{0} + ", i);
                result += 1/(float)i;
            }
            Console.WriteLine("....."+ "\n");
            Console.WriteLine("Sum of Series upto {0} term : {1}",num,result);
        }
    }
}
