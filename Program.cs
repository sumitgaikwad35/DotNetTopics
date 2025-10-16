using DotNetTopics.EnumsExample;
using DotNetTopics.ParallelProgramming;
using System;

namespace DotNetTopics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello Form Main");
            ParallelClass.Run();
            
            Console.ReadKey();
        }
    }
}
