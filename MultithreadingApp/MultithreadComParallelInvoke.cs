using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingApp
{
    class MultithreadComParallelInvoke
    {
        static void Task1()
        {
            Console.WriteLine("Task 1 iniciada...");
            Thread.Sleep(1000 * 4);
            Console.WriteLine("Task 1 encerrada...");
        }

        static void Task2()
        {
            Console.WriteLine("Task 2 iniciada...");
            Thread.Sleep(1000 * 3);
            Console.WriteLine("Task 2 encerrada...");
        }

        static void Mainx(string[] args)
        {
            Parallel.Invoke( ()=> Task1(), ()=> Task2());
            Console.WriteLine("Threads encerradas");
        }
    }
}
