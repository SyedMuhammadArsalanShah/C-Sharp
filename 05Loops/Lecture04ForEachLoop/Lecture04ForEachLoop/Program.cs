using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture04ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {



            int[] a = { 10, 10, 20, 30, 90 };//five values 

            char[] array = { 'H', 'a', 'r', 'r', 'y' };
        
            foreach (char z in array)
            {
                Console.WriteLine(z);
            }
            int[] array1 = { 55, 68, 74, 94, 184, 1000, 0, 1000 };

            foreach (int z in array1)
            {
                if (z % 2 == 0)
                {
                    Console.WriteLine("Even" + z);
                }
                else
                {
                    Console.WriteLine("Odd" + z);
                }
            }



            Console.ReadKey();//




        }
    }
}
