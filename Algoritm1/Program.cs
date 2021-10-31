using System;

namespace Algoritm1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please inter number");
            var input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                for (int z = 1; z <= i; z++)
                {
                    if (z==1)   
                    {
                        Console.Write('\n');
                    }
                        Console.Write(z);
                }
            }
            Console.ReadKey();
        }
    }
}
