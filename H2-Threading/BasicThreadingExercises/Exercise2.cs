using System;
using System.Collections.Generic;
using System.Text;

namespace H2_Threading
{
    class Exercise2
    {
        public void Say5TimesThreadEasy()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C#-trådning er nemt!");
            }
        }

        public void Say5TimesMoreThreads()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Også med flere tråde...");
            }
        }
    }
}
