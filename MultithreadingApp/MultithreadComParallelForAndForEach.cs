using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingApp
{
    class MultithreadComParallelForAndForEach
    {
        static void WorkOnItem(object item)
        {
            Console.WriteLine($"Iniciando task {item}",item);
            Thread.Sleep(100);
            Console.WriteLine($"Encerrada task {item}",item);
        }

        public static void Mainx(string[] args)
        {
            var items = Enumerable.Range(0,500);
            Parallel.ForEach(items, item => {
                WorkOnItem(item);
            });

            Parallel.For(0, items.Count(), i =>
            {
                WorkOnItem(items.ToArray()[i]);
            });
        }
    }
}
