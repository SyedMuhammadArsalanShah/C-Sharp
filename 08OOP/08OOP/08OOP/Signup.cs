using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08OOP
{
    class Signup
    {


        // 
        //empty constructor
        public Signup() { }
        // sign(datatype) of parameter
        public Signup(int num) { }
        public Signup(float num) { }
        // number of parameter
 

        public Signup(string email, string pass) {

            Console.WriteLine("wellcome in our app" +email);

        }
        public Signup(string email,string pass,string number) {
            Console.WriteLine("wellcome in our app" + email);

        }

        public Signup(string email, string pass, string number, string address)
        {

            Console.WriteLine("wellcome in our app" + email);

        }



       


      

    }
}
