using System;

namespace Algoritm8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please inter number");
            int input = Convert.ToInt32(Console.ReadLine());
            int result=Fibunachi(input);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static int Fibunachi(int n)
        {
            if (n > 2)
            {
                return Fibunachi(n - 1) + Fibunachi(n - 2);
            }
            else
            {
                return 1;
            }
        }
    }
}
