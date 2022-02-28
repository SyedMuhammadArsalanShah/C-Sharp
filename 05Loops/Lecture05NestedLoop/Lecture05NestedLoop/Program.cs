using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture05NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program 1");
            for (int f = 1; f <= 5; f++)
            {
                for (int e = 1; e <= 5; e++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            Console.WriteLine("Program 2");
            for (int k = 0; k < 5; k++)
            {
                for (int l = 0; l <= k; l++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("");
            }

            Console.WriteLine("program 3");
            for (int l = 1; l <= 5; l++)
            {

                for (int m = l; m <= 5; m++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= l; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Program 4");

            for (int g = 1; g <= 5; g++)
            {

                for (int h = 1; h <= g; h++)
                {

                    Console.Write(g);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("program 5");
            for (int jj = 5; jj > 0; jj--)
            {

                for (int ii = 1; ii <= jj; ii++)
                {

                    Console.Write("*");
                }
                Console.WriteLine("");

            }
            Console.WriteLine("program 6");
            for (int o = 1; o <= 5; o++)
            {
                for (int p = o; p <= 5; p++)
                {
                    Console.Write(" ");
                }
                for (int a = 1; a <=o; a++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine("");

            }
            Console.WriteLine("program 7");
            for (int v = 5; v > 0; v--)
            {
                for (int u = v; u <= 5; u++)
                {
                    Console.Write(" ");
                }

                for (int a = 1; a <= v; a++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine("");

            }
            Console.WriteLine("program 8");
            Console.WriteLine("Enter Any number");
            int row = Convert.ToInt32(Console.ReadLine());

            int i, j;
            for (i = 0; i <= row - 1; i++)
            {

                for (j = 0; j <= i; j++)
                {
                    if (i % 2 != 0)
                    {
                        continue;
                    }
                    Console.Write("*" + " ");
                }
                Console.WriteLine("");
            }
            for (i = row - 1; i > 0; i--)
            {
                for (j = 0; j < i - 1; j++)
                {
                    if (i % 2 != 0)
                    {
                        continue;
                    }
                    Console.Write("*" + " ");
                }
                Console.WriteLine(" ");
            }


            Console.ReadKey();
        }
    }
}
