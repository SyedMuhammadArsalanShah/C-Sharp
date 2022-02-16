using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture02BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Break Statement

            //    A Break statement breaks out of the loop at the current point or we can say that it terminates the loop condition.

            //    It is represented by break;

            //    Continue Statement

            //    A Continue statement jumps out of the current loop condition and jumps back to the starting of the loop code.

            //    It is represented by continue;


            ////continue or break;
            ////23
            for (int i = 0; i <= 5; i++)
            {
                if (i == 2)
                {
                    continue; //loop jump

                }
                if (i == 4)
                {
                    break;// forloop termination

                }
                Console.WriteLine("" + i);

            }


            Console.WriteLine("Enter a number And check isprime/ or not prime");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;
            //7/2;7/3;7/4;7/5;7/6;=

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }

            }
            if (isPrime)
            {
                Console.WriteLine("prime number");
            }
            else { Console.WriteLine("not a prime number"); }
            Console.ReadKey();
        }
    }
}
 