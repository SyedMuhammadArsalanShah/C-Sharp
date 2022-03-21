using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOOP
{
    class Brand : Car
    {
        public override void runstop(string name, string modelno, string platenumber)
        {
            base.runstop(name, modelno, platenumber);


              name = "mehran";
              modelno = "1986";
              platenumber = "abc-123";


            Console.WriteLine("Child Name Car"+name);
            Console.WriteLine("Child Model Number"+name);
            Console.WriteLine("Child PlateNumber"+name);


        }
    }
}
