using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    class Car
    {


        public string name, modelno, platenumber;

        public virtual void runstop(string name, string modelno, string platenumber)
        {

            this.name = name;
            this.modelno = modelno;
            this.platenumber = platenumber;

            Console.WriteLine("My car name  "+ name);
            Console.WriteLine("My model number  "+ modelno);
            Console.WriteLine("My plateNumber   "+ platenumber);

        }

     
    }
}
