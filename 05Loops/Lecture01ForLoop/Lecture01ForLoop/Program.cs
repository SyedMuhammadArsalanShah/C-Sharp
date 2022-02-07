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
       //     //for(initialization ;condition; increment/decrement){}
       //     int i, j;
       //     //0to10 series
       //     for (i = 0; i <= 10; i++)
       //     {


       //         Console.WriteLine("laiba" + i);

       //     }

       //     //0 to 100 print series with  even odd number
       //     for (j = 0; j <= 100; j++)
       //     {

       //         if (j % 2 == 0)
       //         {
       //             Console.WriteLine("even" + j);
       //         }
         
       //else
       //         {
       //             Console.WriteLine("odd" + j);

       //         }



       //     }

            // factorial loop 
            int fact = 1;
            // 5*4*3*2*1=120
            for (int i= 1; i <=5; i++)
            {
                fact*= i;  //fact=fact*i  =ist iteration= 1 ;2nd iteration 2;3rd= 6 4th= 24 ;5th 120 
            }
            Console.WriteLine(fact);

            int fact1 = 0;
            //sum of ten numbers
            //1+2+3+4+5+6+7+8+9+10
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());
            for (int i = value1; i <= value2; i++)
            {
                fact1 += i; //fact1 
            }
            Console.WriteLine(fact1);  //fact=fact+i = ist iteration = 1; 2nd iteration 3; 3rd = 6 4th = 10; 5th 15
            //


            Console.ReadKey();
        }
    }
}
