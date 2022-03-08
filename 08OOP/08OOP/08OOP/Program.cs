using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            //Car obj1 = new Car();
            //obj1.name = "civic";
            //obj1.plate = "ABC-123";
            //obj1.bname = "Honda";
            //obj1.model = 2001;
            //Console.WriteLine("name "+obj1.name);
            //Console.WriteLine("pname "+obj1.plate);
            //Console.WriteLine("bname "+obj1.bname);
            //Console.WriteLine("model "+obj1.model);

            Mobile mobile = new Mobile();
            // methodone() Mobile Ki class Ka wo method hai jo without parameter Hai
            mobile.methodone();
            // "methodtwo()" Mobile Ki class Ka wo method hai jo with parameter Hai
            // ab hum isko arguments dengy parameters ko value dena arguments kehlata hai 
            mobile.methodtwo("huawei", "nova3i", 220000);



            Mobile obj2 = new Mobile();
            obj2.methodtwo("huawei","nova3i",220000);

            Mobile obj3 = new Mobile();
            obj3.methodtwo("huawei1", "nova3i", 220000);

            Mobile obj4 = new Mobile();
            obj4.methodtwo("huawei2", "nova3i", 220000);
            Mobile obj5 = new Mobile();
            obj5.methodtwo("huawei3", "nova3i", 220000);
           

            Mobile obj6 = new Mobile();
            int uservalue = Convert.ToInt32(Console.ReadLine());
            obj6.sumi(uservalue);

            Console.ReadKey();


        }
    }
}
