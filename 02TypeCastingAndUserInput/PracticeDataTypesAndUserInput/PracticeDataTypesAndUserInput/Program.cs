using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDataTypesAndUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add program");
            Console.WriteLine("enter a first value");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second value");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = num1 + num2;
            Console.WriteLine("Answer is =" + num3);



            Console.WriteLine("Subtract program");
            Console.WriteLine("enter a first value");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second value");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int num6 = num4 - num5;
            Console.WriteLine("Answer is =" + num6);

            Console.WriteLine("Multiply program");
            Console.WriteLine("enter a first value");
            int num7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second value");
            int num8 = Convert.ToInt32(Console.ReadLine());
            int num9 = num8 * num7;
            Console.WriteLine("Answer is =" + num9);

            Console.WriteLine("Divide program");
            Console.WriteLine("enter a first value");
            int num10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second value");
            int num11 = Convert.ToInt32(Console.ReadLine());
            int num12 = num10 / num11;
            Console.WriteLine("Answer is =" + num12);
            Console.ReadKey();
        }
    }
}
