using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotNetTopics.ParallelProgramming
{
    internal class ParallelClass
    {
        public static void Run()
        {
            Console.WriteLine("C# For Loop");
            int number = 10;
            for (int count = 0; count < number; count++)
            {               
                Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.WriteLine("Parallel For Loop");
            Parallel.For(0, number, count =>
            {
                Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");               
                Thread.Sleep(10000);
            });
        }
    }
}
