using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture01OperatorsWithIf_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a table value");
            int table = Convert.ToInt32(Console.ReadLine());
            int num1 = 1;
            //++  for  increment  value =1 ; value++;  value=2
            //--  for  decrement  value =2 ; value--;  value=1
            Console.WriteLine(table + "*" + num1 + "=" + (table * num1++));
            Console.WriteLine(table + "*" + num1 + "=" + (table * num1++));
            Console.WriteLine(table + "*" + num1 + "=" + (table * num1++));
            Console.WriteLine(table + "*" + num1 + "=" + (table * num1++));
            Console.WriteLine(table + "*" + num1 + "=" + (table * num1++));
            Console.WriteLine(table + "*" + num1 + "=" + (table * num1++));
            Console.WriteLine(table + "*" + num1 + "=" + (table * num1++));
            Console.WriteLine(table + "*" + num1 + "=" + (table * num1++));
            Console.WriteLine(table + "*" + num1 + "=" + (table * num1++));
            Console.WriteLine(table + "*" + num1 + "=" + (table * num1++));


            // Conditional Statement if/else

            Console.WriteLine();
            Console.WriteLine("enter a value positive & negative number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 > 0)
            {
                Console.WriteLine("positive number" + num2);
            }
            else
            {
                Console.WriteLine("negative  number" + num2);

            }

            Console.WriteLine("enter a value even & odd number");
            int checknum = Convert.ToInt32(Console.ReadLine());
            if (checknum % 2 == 0)
            {
                Console.WriteLine("Even number" + checknum);
            }
            else
            {
                Console.WriteLine("Odd  number" + checknum);


            }
            Console.WriteLine("enter a value Leap Year & Not Leapyear ");
            int checkyear = Convert.ToInt32(Console.ReadLine());
            if (checkyear % 4 == 0)
            {
                Console.WriteLine("Leap Year" + checkyear);
            }
            else
            {
                Console.WriteLine("Not a Leap Year" + checkyear);


            }

            Console.ReadKey();
        }
    }
}
