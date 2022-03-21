using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Brand brand = new Brand();
            brand.runstop("civic", "2022", "xyz-789");
            Console.ReadKey();



        }
    }
}
