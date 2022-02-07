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
            Console.WriteLine("0to10 series");
            for (i = 0; i <= 10; i++)
            {


                Console.WriteLine(i);

            }

            //0 to 100 print series with  even odd number
            Console.WriteLine("0 to 10 print series with  even odd number");
            for (j = 0; j <= 10; j++)
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

            // factorial program
            Console.WriteLine("factorial program");
            int fact = 1;
          
            for (int k= 1; k <=5; k++)
            {
                fact *= k; //fact=fact*i 
                // => fact variable value in 1st iteration= 1 ; 2nd iteration = 2; 3rd iteration= 6 ; 4th iteration= 24 ; 5th iteration= 120 ;
                // 5*4*3*2*1=120
            }
            Console.WriteLine(fact);

            Console.WriteLine("sum of all values program");
            //sum of ten numbers
            //1+2+3+4+5=15
            int sum = 0;
            for (int l = 0; l <= 5; l++)
            {
                sum += l;//sum =sum+ i;
                // => sum variable value in 1st iteration = 1; 2nd iteration 3; 3rd iteration = 6; 4th iteration=10; 5th iteration=15
                //1+2+3+4+5=15
            }
            Console.WriteLine(sum);



            Console.ReadKey();
        }
    }
}
