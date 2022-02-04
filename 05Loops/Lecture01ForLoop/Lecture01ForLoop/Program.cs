using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture01ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {            //for loop
            //for(initialization ;condition; increment/decrement){}
            int i, j;
            //0to10 series
            for (i = 0; i <= 10; i++)
            {


                Console.WriteLine("laiba" + i);

            }

            //0 to 100 print series with  even odd number
            for (j = 0; j <= 100; j++)
            {

                if (j % 2 == 0)
                {
                    Console.WriteLine("even" + j);
                }
                else
                {
                    Console.WriteLine("odd" + j);

                }



            }



            Console.ReadKey();
        }
    }
}
