using System;

namespace Algoritm3
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
                for (int y = i; y <= input-1; y++)  
                {
                    Console.Write(print);
                }

                for (int d = 1; d < i; d++)
                {
                    Console.Write(d);
                }

                for (int j = i; j > 0; j--)
                {
                    Console.Write(j);
                }
          
                Console.WriteLine();
            }

            for (int i = input - 1; i >= 1; i--)
            {
                for (int y = i; y <= input - 1; y++) 
                {
                    Console.Write(print);
                }

                for (int h = 1; h < i; h++)
                {
                    
                    Console.Write(h);
                }

                for (int j = i; j > 0; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
