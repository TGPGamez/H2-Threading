using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace H2_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 0
            //Exercise0 ex0 = new Exercise0();
            //Thread thread = new Thread(new ThreadStart(ex0.WorkThreadFunction));
            //thread.Start();
            //Console.Read();

            //EXERCISE 1
            //Exercise1 ex1 = new Exercise1();
            //Thread thread = new Thread(new ThreadStart(ex1.Say5Times));
            //thread.Start();
            //Console.Read();

            //EXERCISE 2
            //Exercise2 ex2 = new Exercise2();
            //Thread thread1 = new Thread(new ThreadStart(ex2.Say5TimesThreadEasy));
            //Thread thread2 = new Thread(new ThreadStart(ex2.Say5TimesMoreThreads));
            //thread1.Start();
            //Thread.Sleep(1000);
            //thread2.Start();
            //Console.Read();

            //EXERCISE 3
            //Exercise3 ex3 = new Exercise3();
            //Thread thread = new Thread(new ThreadStart(ex3.TemperaturGen));
            //thread.Start();
            //while (thread.IsAlive)
            //{
            //    Thread.Sleep(10000);
            //}
            //Console.WriteLine("Alarm-tråd termineret!");

            //EXERCISE 4
            //Exercise4 ex4 = new Exercise4();
            //Thread thread1 = new Thread(new ThreadStart(ex4.ReaderThread));
            //Thread thread2 = new Thread(new ThreadStart(ex4.PrinterThread));
            //thread1.Start();
            //thread2.Start();

            //ThreadPool Exercise
            //ExerciseThreadPool etp = new ExerciseThreadPool();
            //for (int i = 0; i < 2; i++)
            //{
            //    ThreadPool.QueueUserWorkItem(new WaitCallback(etp.task1));
            //    ThreadPool.QueueUserWorkItem(new WaitCallback(etp.task2));
            //}
            //Console.Read();

            //PoolVsObjects
            //ExerciseThreadPool etp = new ExerciseThreadPool();
            //etp.ThreadPoolVsObjects();


        }
    }
}
