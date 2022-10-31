using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProgram1
{
    public class FlipCoin
    {
        public void play(float num)
        {
            Random random = new Random();
            float head = 0;
            for(int i = 0; i < num; i++)
            {
               int  coin = random.Next(1,3);
                if(coin == 1)
                {
                    head += 1;
                }
            }
            float percent = head / num;
            Console.WriteLine(percent);
        }
    }
}
