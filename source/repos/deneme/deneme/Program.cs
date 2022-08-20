using System;
using System.Collections.Generic;
using System.Linq;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var numbers2 = numbers.Select(i => i);
            var numbers3 = numbers.Where(i => i % 2 == 0).OrderBy(i => i);
            //var numbers3 = numbers.Where(i => i % 2 == 0).OrderByDescending(i => i); ---> coxdan aza dogru siralayir
            foreach (int i in numbers3)
            {
                Console.WriteLine(i);
            }



            //try
            //{
            //    int[] myNumbers = { 1, 2, 3 };
            //    Console.WriteLine(myNumbers[10]);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("asdcdas");
            //}




        }
    }
}
/