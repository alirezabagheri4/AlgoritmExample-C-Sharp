using System;

namespace Algoritm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please inter number");
            var input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                for (int z = 1; z <= input - i; z++)
                {
                    Console.Write(" ");
                }

                for (int z = 1; z <= i; z++)
                {
                    Console.Write(z);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}