using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace H2_Threading
{
    class ExerciseThreadPool
    {
        public void task1(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 1 is being executed");
            }
        }

        public void task2(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 2 is being executed");
            }
        }





        public void ThreadPoolVsObjects()
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("With threadpool");
            stopwatch.Start();
            ProcessWithThreadPoolMethod();
            stopwatch.Stop();
            Console.WriteLine("The pool took: " + stopwatch.ElapsedTicks.ToString());

            stopwatch.Reset();

            Console.WriteLine("Thread objects");
            stopwatch.Start();
            ProcessWithThreadMethod();
            stopwatch.Stop();
            Console.WriteLine("The objects took: " + stopwatch.ElapsedTicks.ToString());
            Console.ReadKey();
        }

        private void ProcessWithThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }

        private void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }

        private void Process(object callback)
        {

        }
    }
}
