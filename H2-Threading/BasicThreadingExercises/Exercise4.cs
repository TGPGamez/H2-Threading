using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace H2_Threading
{
    class Exercise4
    {
        static char ch = '*';
        public void PrinterThread()
        {
            while (true)
            {
                Console.Write(ch);
                Thread.Sleep(100);
            }
        }

        public void ReaderThread()
        {
            char temp;
            while (true)
            {
                try
                {
                    temp = Console.ReadLine().First();
                }
                catch (Exception)
                {
                    throw;
                }
                if (char.IsLetterOrDigit(temp))
                {
                    ch = temp;
                }
            }
        }
    }
}
