using System;

namespace Algoritm4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please inter number");
            var input = Convert.ToInt32(Console.ReadLine());
            var print = string.Format(" ");

            for (int i = 1; i <= input; i++)
            {
                var x = input;
                while (x - i >= 1)
                {
                    Console.Write(print);
                    x--;
                }

                var z = 1;
                while (z <= i)
                {
                    Console.Write(z);
                    z++;
                }

                Console.WriteLine();
            }

            for (int j = input - 1; 1 <= j; j++)
            {
                var w = input;
                while (j - 3 >= 1)
                {
                    Console.Write(print);
                    j++;
                }

                var h = 1;
                while (h < j)
                {
                    Console.Write(h);
                    h++;
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
