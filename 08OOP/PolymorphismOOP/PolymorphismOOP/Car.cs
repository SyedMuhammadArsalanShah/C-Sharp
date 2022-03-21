using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOOP
{
    class Car
    {

        /* 
         In C# we can use 3 types of keywords for Method Overriding:
         virtual keyword:

         This modifier or keyword use within base class method. It is used to modify a 
         method in base class for overridden that particular method in the derived class.

         override:

         This modifier or keyword use with derived class method.
         It is used to modify a virtual or abstract method into derived 
         class which presents in base class.
             
             
         base Keyword: 
         This is used to access members of the base class from derived class.
         It basically used to access constructors and methods or functions of the base class. 
         The base keyword cannot use within a static method. Base keyword specifies which constructor of the base class
         should be invoked while creating the instances of the derived class.

         Use of Base keyword: 
          Call methods or functions of base class from derived class.
          Call constructor internally of base class at the time of inheritance.

         
             */


        public string name, modelno, platenumber;

        public virtual void runstop(string name, string modelno, string platenumber)
        {

            this.name = name;
            this.modelno = modelno;
            this.platenumber = platenumber;

            Console.WriteLine("My car name  " + name);
            Console.WriteLine("My model number  " + modelno);
            Console.WriteLine("My plateNumber   " + platenumber);

        }




    }
}
