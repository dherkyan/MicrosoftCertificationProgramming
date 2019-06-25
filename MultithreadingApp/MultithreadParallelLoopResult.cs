using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingApp
{
    class MultithreadParallelLoopResult
    {
        static void WorkOnItem(object item)
        {
            Console.WriteLine($"Iniciando task {item}", item);
            Thread.Sleep(100);
            Console.WriteLine($"Encerrada task {item}", item);
        }

        public static void Mainx(string[] args)
        {
            var items = Enumerable.Range(0, 500).ToArray();

            ParallelLoopResult result = Parallel.For(0,items.Count(),(int i, ParallelLoopState loopState) =>
            {
                if (i == 200)
                {
                    loopState.Stop();
                    //loopState.Break();
                    //loopState.Stop();
                    //loopState.Break();
                    WorkOnItem(items[i]);
                }
            });

            Console.WriteLine("Completado: "+ result.IsCompleted);
            Console.WriteLine("Items: "+result.LowestBreakIteration);
        }
    }
}
