using System;
using System.Collections.Generic;

namespace algo
{
    class Program
    {
        static IEnumerable<int> f(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                yield return i;
            }

            for (int i = x - 1; i > 0; i--)
            {
                yield return i;
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            foreach (var i in f(n))
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }

                foreach (var j in f(i))
                {
                    Console.Write($"{j}");
                }

                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
