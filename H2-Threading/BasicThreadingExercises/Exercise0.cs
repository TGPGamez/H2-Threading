using System;
using System.Collections.Generic;
using System.Text;

namespace H2_Threading
{
    class Exercise0
    {
        public void WorkThreadFunction()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Simple Thread");
            }
        }
    }
}
