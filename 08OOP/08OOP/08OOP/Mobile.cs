using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08OOP
{
 public   class Mobile
    {
        public string model;
        public string brand;
      
        public int price;





        // data type methodname(){}
        public void methodone()
        {
            Console.WriteLine("best phone ");


        }
        // data type methodname(parameters){}
        public void methodtwo(string model , string brand, int price)
        {
            this.model = model;
            this.brand = brand;
            this.price = price ;
            Console.WriteLine(model+brand+price);

      
        }
        public void sumi(int num)
        {
         
                int sum = 0;
           
                //num = 5;
                for (int h = 1; h <= num; h++)
                {
                    sum += h; 
                    
                }
            Console.WriteLine(num + " = result of this submission is = "+sum);
                

         
        }


    }
}
