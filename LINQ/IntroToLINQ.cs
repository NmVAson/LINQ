using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal static class IntroToLinq
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ohhi!");
            
            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6 };
            var evenNumbers = 
                    from num in numbers
                    where num % 2 == 0 
                    select num;

            Console.WriteLine(string.Join(",", evenNumbers));
        }
    }
}