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

            //Mobile mobile = new Mobile();
            ////misbah() Mobile Ki class Ka wo method hai jo without parameter Hai
            //mobile.misbah();
            //// "laiba(string m , string brand, int price)" Mobile Ki class Ka wo method hai jo with parameter Hai
            //// ab hum isko arguments dengy parameters ko value dena arguments kehlata hai 
            //mobile.laiba("huawei", "nova3i", 220000);



            //Mobile obj2 = new Mobile();
            //obj2.laiba("huawei","nova3i",220000);

            //Mobile obj3 = new Mobile();
            //obj3.laiba("huawei1", "nova3i", 220000);

            //Mobile obj4 = new Mobile();
            //obj4.laiba("huawei2", "nova3i", 220000);

            //Mobile obj5 = new Mobile();
            //obj5.laiba("huawei3", "nova3i", 220000);
           
            //Mobile obj6 = new Mobile();
            //int uservalue = Convert.ToInt32(Console.ReadLine());
            //obj6.harry(uservalue);




            Mobile primeNumbers = new Mobile();
            primeNumbers.anas(5);
 
            //constructor

            Signup misbah = new Signup("misbah@gmail.com","loginmisbah");
            Signup Laiba = new Signup("Laiba@gmail.com","loginmisbah","03031234567");
            Signup Harry= new Signup("harry@gmail.com","loginmisbah","03031234567","house in france ");

            Console.ReadKey();
        }
    }
}
