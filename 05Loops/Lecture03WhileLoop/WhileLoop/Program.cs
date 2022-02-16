using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            while (i<10)
            {

                Console.WriteLine("count"+i);

                i++;
            }
            //// even odd
            int j = 0;
            while (j < 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
                j++;
            }

            //prime number
            int k = 2;//loop initialization
            int num = 15;
            int checker = 0;
            // Convert.ToInt32(Console.ReadLine())

            //15/2 1st iteration
            //15/3 2nd iteration
            //15/4 2nd iteration
            //15/5 2nd iteration
            //15/6 2nd iteration

            while (k < num)
            {
                if (num % k == 0)
                {
                    checker = 1;

                    break;
                }

                k++;
            }
            if (checker == 0)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine("it not a prime number");
            }

            Console.ReadKey();

        }
    }
}
