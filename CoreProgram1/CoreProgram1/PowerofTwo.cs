using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProgram1
{
    public class PowerofTwo
    {
        public void Power(int num)
        {
            for(int i=0; i <= num; i++)
            {
                Console.WriteLine("2^"+i+" = "+Math.Pow(2,i));
            }
        }    
    }
}
