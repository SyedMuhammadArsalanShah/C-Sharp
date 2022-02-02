using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Variables_And_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //print statement 
            Console.Write("Laiba");
            Console.Write("Anas");

            //print statement with line break
            Console.WriteLine("Harryson");


            // Data types
            //string
            string str = "Misbah";
            Console.WriteLine(str);


            //character

            char character = 'A';
            Console.WriteLine(character);

            //integer
            int integer = 5;
            Console.WriteLine(integer);


            //double (decimal) 

            double doubl = 5.5;
            Console.WriteLine(doubl);

            // float(decimal)
            float floatt = 5.1f;
            Console.WriteLine(floatt);

            //long
            long lg = 50000000000000;
            Console.WriteLine(lg);

            //short 
            short st = 12;
            Console.WriteLine(st);

            //boolean
            bool iscSharpfun = true;
            Console.WriteLine(iscSharpfun);
            bool ispubgfun = false;
            Console.WriteLine(ispubgfun);


            //example  variable & DataType
            Console.WriteLine("Add program");
            int num1 = 50;
            int num2 = 50;
            int num3 = num1 + num2;
            Console.WriteLine("Answer is =" + num3);


            Console.ReadKey();




        }
    }
}
