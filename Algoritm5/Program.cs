using System;

namespace Algoritm5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please inter number M");
            var inputM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please inter number N");
            var inputN = Convert.ToInt32(Console.ReadLine());

            for(var i= inputM;i<=inputN;i++)
            {
                for(var j= inputM; j <= inputN;j++)
                {
                    Console.Write(i*j+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();        
        }
    }
}
