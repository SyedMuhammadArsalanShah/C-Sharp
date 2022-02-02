using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureTypeCastingtAndUserInput
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            //TypeCasting
            //automatically(implicit ,import) type casting
            //char->int->float->double

            int abc = 5;  // Automatic casting: int to double
            double num1 = 5;
            Console.WriteLine(abc);//5
            Console.WriteLine(num1);//5



            //manualy(explicit ,export) type casting
            //double->float->int->char

            double abcd = 5.5;
            int num = (int)abcd; //double to int
            Console.WriteLine(abcd);//5.5
            Console.WriteLine(num);//5


            //user input
            Console.WriteLine("enter a User name");
            string studentName = Console.ReadLine();// user input
            Console.WriteLine(studentName);
            Console.WriteLine("enter your age");


            //type conversion with methods
            int age = Convert.ToInt32(Console.ReadLine()); //convert string to int
            Console.WriteLine(age);


            //example user input & type Casting
            Console.WriteLine("Add program");
            Console.WriteLine("enter a first value");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second value");
            int value2 = Convert.ToInt32(Console.ReadLine());
            int value3 = value1 + value2;
            Console.WriteLine("Answer is =" + value3);
            Console.ReadKey();
        }
    }
}
