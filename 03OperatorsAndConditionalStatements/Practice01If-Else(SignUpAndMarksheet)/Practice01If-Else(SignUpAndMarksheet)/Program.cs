using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01If_Else_SignUpAndMarksheet_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select An option  Y or N");
            char check = Convert.ToChar(Console.ReadLine());
            if (check == 'y' || check == 'Y')
            {
                Console.WriteLine("SignUp ");
                Console.WriteLine("Enter Your Name ");
                string nameS = Console.ReadLine();
                Console.WriteLine("Enter Your Email ");
                string emailS = Console.ReadLine();
                Console.WriteLine("Enter Your Password ");
                string passS = Console.ReadLine();
                Console.WriteLine("Account Successfully Created ");
                Console.WriteLine("Login");
                Console.WriteLine("Enter Your Email ");
                string emailL = Console.ReadLine();
                Console.WriteLine("Enter Your Password ");
                string passL = Console.ReadLine();
                if (emailS == emailL && passS == passL)
                {
                    Console.WriteLine("Welcome To My Application");

                    Console.WriteLine("Select An option Y or N For Marksheet");
                    char check1 = Convert.ToChar(Console.ReadLine());
                    if (check1 == 'y' || check1 == 'Y')
                    {
                        Console.WriteLine("Enter Student Name ");
                        string sname = Console.ReadLine();
                        Console.WriteLine("Enter Class Name ");
                        string cname = Console.ReadLine();
                        Console.WriteLine("Enter Roll Number  ");
                        int rollnumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter English ");
                        double english = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Urdu ");
                        double urdu = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Math ");
                        double math = Convert.ToDouble(Console.ReadLine());
                        double obttotal = english + urdu + math;
                        double per = obttotal * 100 / 300;
                        if (per <= 100 && per >= 80)
                        {
                            Console.WriteLine("grade = A+" + "percentage =" + per + "total 300 out of =" + obttotal);
                        }
                        else if (per <= 79 && per >= 70)
                        {
                            Console.WriteLine("grade = A" + "percentage =" + per + "total 300 out of =" + obttotal);
                        }
                        else if (per <= 69 && per >= 60)
                        {
                            Console.WriteLine("grade = B" + "percentage =" + per + "total 300 out of =" + obttotal);
                        }
                        else if (per <= 59 && per >= 50)
                        {
                            Console.WriteLine("grade = C" + "percentage =" + per + "total 300 out of =" + obttotal);
                        }
                        else if (per <= 49 && per >= 40)
                        {
                            Console.WriteLine("grade = D" + "percentage =" + per + "total 300 out of =" + obttotal);
                        }
                        else
                        {
                            Console.WriteLine("grade = Fail" + "percentage =" + per + "total 300 out of =" + obttotal);
                        }



                    }

                    else if (check1 == 'n' || check1 == 'N')
                    {
                        Console.WriteLine("you can't continue ");
                    }

                    else
                    {
                        Console.WriteLine("Invalid option");
                    }


                }
                else { Console.WriteLine("incorrect Email or pass"); }






            }
            else if (check == 'n' || check == 'N')
            {

                Console.WriteLine("you can't continue   ");
            }
            else { Console.WriteLine("Oops! you select an invalid option "); }


            Console.ReadKey();
        }
    }
}
