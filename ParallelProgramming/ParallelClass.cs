using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DotNetTopics.ParallelProgramming
{
    internal class ParallelClass
    {
        public static void RunParallelFor ()
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
                Thread.Sleep(1000);
            });
        }

        public static void RunParallelForEach()
        {
            List<string> fruits = new List<string>{ "Apple", "Banana", "Mango", "Orange" };
            //Parallel.ForEach(fruits, Fruit);
            Parallel.ForEach(fruits, fruit =>
            {
                Console.WriteLine($"Processing {fruit} on thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            });
        }
        public static void Fruit(string fruit)
        {
            Console.WriteLine($"Processing {fruit} on thread {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
        }
    }
}
