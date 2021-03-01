using System;
using System.Collections.Generic;
using System.Text;

namespace H2_Threading
{
    class Exercise3
    {
        public void TemperaturGen()
        {
            int count = 0;
            while (count < 3)
            {
                int temp = new Random().Next(-20, 120);
                Console.WriteLine("Temperatur: " + temp);
                if (temp < 0 || temp > 100)
                {
                    Console.WriteLine("ALARM!");
                    count++;
                }
            }
        }
    }
}
