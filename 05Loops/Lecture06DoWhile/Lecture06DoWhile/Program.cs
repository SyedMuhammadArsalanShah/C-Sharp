using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture06DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 0;
            do
            {
                Console.WriteLine("laiba " + l);

                l++;

            } while (l <= 10);



            Console.ReadKey();


        }
    }
}
