using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please inter number");
            int input = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[input, input];

            for (var i = 1; i <= input; i++)
            {
                for (var z = 1; z <= input; z++)
                {
                    array[i - 1, z - 1] = i * z;
                }
            }

            for (var i = 0; i < input; i++)
            {
                for (var z = 0; z < input; z++)
                {
                    Console.Write(array[i, z] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
