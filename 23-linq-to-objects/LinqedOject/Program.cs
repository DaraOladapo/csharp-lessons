using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqedOject
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] scores = new int[] { 97, 92, 81, 60 };
            IEnumerable<int> scoreQuery =
            from score in scores
            where score > 80
            select score;
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }

        }
    }
}
