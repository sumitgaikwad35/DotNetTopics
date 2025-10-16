using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTopics.EnumsExample
{
    internal class EnumOne
    {
        public int Ranks {  get; set; }
        public string Name { get; set; }
        public static string CheckRank(int rank)
        {
            
            switch (rank)
            {
                case (int)Rank.First:
                    return "First";
                case (int)Rank.Second:
                    return "Second";
                case (int)Rank.Third:
                    return "Third";
                default:
                    return "General";

            }

        }

        public enum Rank
        {
            First = 1,
            Second,
            Third
        }
    }
}
