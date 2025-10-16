using DotNetTopics.EnumsExample;
using DotNetTopics.ParallelProgramming;
using System;
using System.Collections.Generic;

namespace DotNetTopics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello Form Main");
            //ParallelClass.RunParallelFor();
            //ParallelClass.RunParallelForEach();

            List<EnumOne> student = new List<EnumOne>
            {
                new EnumOne{ Name= "Sumit" , Ranks = 1},
                new EnumOne{ Name = "Vishal" , Ranks = 2},
                new EnumOne{ Name = "Dnyaneshwar" , Ranks = 3},
                new EnumOne{ Name = "Aditya" , Ranks = 4}
            };

            foreach (var item in student)
            {
                Console.WriteLine($"{item.Name}'rank = {EnumOne.CheckRank(item.Ranks)}");
            }

            Console.ReadKey();
        }
    }
}
