using System;

namespace Algoritm6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please inter number");
            int input = Convert.ToInt32(Console.ReadLine());

            for (var i = 1; i <= input; i++)
            {
                for (var z = 1; z <= input; z++)
                {
                    if (i == z)
                    {
                        Console.Write("X");
                    }
                    if (z == input - i + 1)
                    {
                        Console.Write("X");
                    }
                    Console.Write("+");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
