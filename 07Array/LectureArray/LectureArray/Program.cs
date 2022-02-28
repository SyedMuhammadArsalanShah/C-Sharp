using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureArray
{
    class Program
    {
        static void Main(string[] args)
        {

            //datatype array
            string[] aa = { "misbah", "karachi", "laiba" };
            Console.WriteLine(aa[2]);

            //int array 
            string[] laiba = new string[5];
            laiba[0] = "misbah";
            laiba[1] = "misbah98";
            laiba[2] = "misbah56";
            laiba[3] = "karachi ";
            laiba[4] = "lion";

            Console.WriteLine(laiba[2]);


            string[] harry = new string[] { "misbah", "karachi", "laiba" };


            string[] anas = new string[3] { "misbah", "karachi", "laiba" };

            string[] ammna = anas;
            Console.WriteLine(ammna[1]);


            // your task questions 


            Console.WriteLine("Program  Number Two");


            int[] a = { 1, 255, 3, 4, 5 };
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Enter" + i + "Number");
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            int k = a.Length - 1;
            int[] ord = new int[5];
            for (int j = 0; j < a.Length; j++)
            {

                ord[j] = a[k];

                k--;
                Console.WriteLine(ord[j] + " index " + j);
            }


            Console.WriteLine("Program Number Three");
            int[] check = new int[5];
            for (int i = 0; i < check.Length; i++)
            {
                Console.WriteLine("Enter Number");
                check[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Check how many times your number has been Printed");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < check.Length; i++)
            {

                if (check[i] == num2)
                {
                    count++;
                }





            }
            if (count != 0)
            {
                Console.WriteLine("your number = " + num2 + " : Print = " + count + " times ");

            }
            else
            {
                Console.WriteLine("your number = " + num2 + "not print in array");
            }










            Console.ReadKey();
        }
    }
}
