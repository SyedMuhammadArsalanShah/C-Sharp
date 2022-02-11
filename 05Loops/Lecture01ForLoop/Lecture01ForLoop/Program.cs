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
        {
            //  int abc = 1;

            ////for loop
            ////for(initialization ;condition; increment/decrement){}
            //int i, j;
            ////i++ => i+=1; =>i=i+1;
            ////0to5 series
            //Console.WriteLine("0to10 series");
            //for (i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine(i);

            //    //1stiteration =0;2nd iteration =1;3rd iteration =2;4thiteration =3; 5th iteration 4;
            //}
            //Console.WriteLine("0 to 4 series");
            //for (i = 0; i <= 5; i+=2)
            //{
            //    Console.WriteLine(i);

            //    //1stiteration =0;2nd iteration =2;3rd iteration =4;
            //}
            //Console.WriteLine("0 to series");
            //for (i = 1; i <= 5; i*= 2)
            //{
            //    Console.WriteLine(i);

            //    //1stiteration =1;2nd iteration =2;3rd iteration =4;
            //}
            //////0 to 100 print series with  even odd number
            //Console.WriteLine("0 to 10 print series with  even odd number");
            //for (j = 0; j <= 10; j++) 
            //{

            //    if (j % 2 == 0)
            //    {
            //        Console.WriteLine("even" + j);
            //    }

            //    else
            //    {
            //        Console.WriteLine("odd" + j);

            //    }



            //}

            ////factorial program
            //Console.WriteLine("factorial program");
            //int fact = 1;

            //for (int k = 1; k <= 6; k++)
            //{
            //    fact *= k; //fact=fact*k 
            //    // => fact variable value in 1st iteration= 1 ; 2nd iteration = 2; 3rd iteration= 6 ; 4th iteration= 24 ; 5th iteration= 120 ;6th iteration= 720 ;
            //    // 5*4*3*2*1=120
            //}
            //Console.WriteLine(fact);

            //Console.WriteLine("sum of all values program");
            ////sum of ten numbers
            ////1+2+3+4+5=15
            //int sum = 0;
            //for (int l = 1; l <= 5; l++)
            //{
            //    sum += l;//sum =sum+ l;
            //    // => sum variable value in 1st iteration = 1; 2nd iteration 3; 3rd iteration = 6; 4th iteration=10; 5th iteration=15
            //    //1+2+3+4+5=15
            //}
            //Console.WriteLine(sum);

            // Console.WriteLine("enter the number and check your number how many time your number has been  printed");
            // int check = Convert.ToInt32(Console.ReadLine());//2
            // int count = 0;// this is  an counter its value will incremnet when value of  'check' is equals to inputvalue
            // for (int m = 1; m <=10; m++)
            // {
            //     Console.WriteLine("Input the "+m+" number");//m denote value of iteration 
            //     int inputvalue = Convert.ToInt32(Console.ReadLine());//2
            //     if (check == inputvalue)
            //     {
            //         count++;//From here, the counter value will increases. 

            //     }
            // }
            //Console.WriteLine("your number" +check+ "has been printed "+count+" times");




            ////continue or break;
            ////23
            //for (int i = 0; i <= 5; i++)
            //{
            //    if (i==2)
            //    {
            //        continue; //loop jump

            //    }
            //    if (i==4)
            //    {
            //        break;// forloop termination

            //    }
            //    Console.WriteLine("" + i);

            //}


            //Console.WriteLine("Enter a number And check isprime/ or not prime");
            //int num = Convert.ToInt32(Console.ReadLine());

            //bool isPrime =true;
            ////7/2;7/3;7/4;7/5;7/6;=

            //for (int i =2 ; i <num; i++)
            //{
            //    if (num%i==0)
            //    {
            //        isPrime = false;
            //        break;
            //    }

            //}
            //if (isPrime)
            //{
            //    Console.WriteLine("prime number");
            //}
            //else { Console.WriteLine("not a prime number"); }
            

            Console.ReadKey();
        }
    }
}
