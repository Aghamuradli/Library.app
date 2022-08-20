using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "b", "a", "b", "b", "c", "c" };
            Dictionary<string, int> dic = new Dictionary<string,int>();
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        count++;
                }
                if (!dic.ContainsKey(array[i]))
                    dic.Add(array[i], count);
            }
            foreach (var item in dic)
                Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
