using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08OOP
{
 public class Mobile
    {
        // field/variables;
        public string model;
        public string brand;
        public int price;
        //Constructor no return type & name same as class name

        public Mobile() { }
        public Mobile(int num)
        {
            int Prime = 0;// checker

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Prime = 1;
                    break;
                }
            }
            //If isPrime is true then the number is prime else not
            if (Prime == 0)
            {
                Console.WriteLine(num + " is  a Prime Number");
            }
            else
            {
                Console.WriteLine(num + " is not a Prime Number");
            }



        }



        //returntype methodname(){}
        public void misbah()
        {
            Console.WriteLine("best phone ");


        }
        // returntype methodname(parameters){}
        public void laiba(string m , string brand, int price)
        {
            // this keyword is used to refer to the current
            //instance of the class. It is used to access 
            //members from the constructors, instance methods,
            //and instance accessors.this keyword is also used 
            //to track the instance which is invoked to perform 
            //some calculation or further processing related to 
            //that instance. Following are the different ways to 
            //use ‘this’ keyword in C# :
          
            this.model = m;
            this.brand = brand;
            this.price = price ;
            Console.WriteLine(model +brand+price);
        }
        public void harry(int num)
        {
         
               int sum = 0;
           
                //num = 5;
                for (int h =1; h <= num; h++)
                {
                    sum += h; 
                    
                }
            Console.WriteLine(num + " = result of this submission is = "+sum);
                

         
        }


      public  int anas(int num)//5
        {
            int Prime = 0;// checker

            for (int i = 2; i < num ; i++)
            {
                if (num % i == 0)
                {
                    Prime = 1;
                    break;
                }
            }
            //If isPrime is true then the number is prime else not
            if (Prime==0)
            {
                Console.WriteLine(num + " is  a Prime Number");
            }
            else
            {
                Console.WriteLine(num + " is not a Prime Number");
            }
            return num;


        }

    }
}
