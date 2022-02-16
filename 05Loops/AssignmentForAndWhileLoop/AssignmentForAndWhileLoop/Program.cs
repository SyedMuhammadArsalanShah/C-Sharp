using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentForAndWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question no 1
            int j;

            for ( j= 10; j >= -12; j--)
            {

            }
            Console.WriteLine(j);
            Console.WriteLine("sentence count");
            string sen = Console.ReadLine();
            string[] word = sen.Split();
            int i;
            int count = 0;

            for (i = 0; i < sen.Length; i++)
            {

                count++;
            }
            Console.WriteLine("alphabets=:" + count);
            for (i = 0; i < word.Length; i++)
            {

            }

            Console.WriteLine("words= :" + i);




            //Question no 2

            Console.WriteLine("Enter your birth and current year");

            int Ybirth = Convert.ToInt32(Console.ReadLine());
            int Ycurrent = Convert.ToInt32(Console.ReadLine());
            int cal = Ycurrent - Ybirth; //2022-2001=21
            int month = cal * 12;//21*12
            int weeks = month * 4;
            int days = weeks * 7;
            int hours = days * 24;
            int min = hours * 60;
            int sec = min * 60;

            if (Ybirth < Ycurrent)
            {

                Console.WriteLine("your age is " + cal);
                Console.WriteLine("your months are " + month);
                Console.WriteLine("your weeks are " + weeks);
                Console.WriteLine("your days are " + days);
                Console.WriteLine("your hours are " + hours);
                Console.WriteLine("your min are " + min);
                Console.WriteLine("your sec are " + sec);

            }



            //Question no 3

            int count_ = 0;
            int count1_ = 0;
            for (int num = 1; num <= 10; num++)
            {
                Console.WriteLine("Input the " + num + " number");
                int inputvalue = Convert.ToInt32(Console.ReadLine());
                if (inputvalue % 2 == 0)
                {
                    Console.WriteLine("EVEN");
                    count_++;

                }
                else
                {
                    Console.WriteLine("ODD");
                    count1_++;
                }
            }
            if (count_ != 0)
            {

                Console.WriteLine("Total even numbers=" + count_);
            }
            else
            {
                Console.WriteLine("There are no even numbers in list");
            }
            if (count1_ != 0)
            {
                Console.WriteLine("Total odd numbers=" + count1_);

            }
            else
            {
                Console.WriteLine("There are no odd numbers in list");
            }



            ////Question no 4
            int high = Int32.MinValue;//-2147483647
            int low = Int32.MaxValue;//2147483647

            for (int m = 1; m <= 10; m++)
            {
                Console.WriteLine("Enter " + m + "number");
                int sum = Convert.ToInt32(Console.ReadLine());//7

                if (sum > high)
                {
                    high = sum;//7  1st iteration =7 
                }
                if (sum < low)
                {
                    low = sum;
                }
            }
            Console.WriteLine("Highest value " + high);
            Console.WriteLine("Lowest value " + low);


            Console.ReadKey();




        }
    }
}
