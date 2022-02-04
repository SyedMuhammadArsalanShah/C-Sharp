using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yes or no prgram
            //Create account
            //Option to user - if user gives y or Y
            //Then
            //: Username
            //: Email
            // : Password
            //Verify -
            //Than it will move to
            //It will ask login
            //And username, password I
            //Switch case
            //1 = MarkSheet
            //2 = calculator
            //3 = alphabet lower case and lower case
            //4 = even odd
            //5 = leap year
            //6 = 2 table

            //code
            Console.WriteLine("Select yes or no");
            string ans = Console.ReadLine();

            if (ans == "yes" || ans == "Yes")
            {
                Console.WriteLine("SignUp");
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your email");
                string email = Console.ReadLine();

                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();
                Console.WriteLine("Account sucessfully created");

                Console.WriteLine("Login");
                Console.WriteLine("Enter your email");
                string email_ = Console.ReadLine();

                Console.WriteLine("Enter your password");
                string pass = Console.ReadLine();

                if (email == email_ && password == pass)
                {
                    Console.WriteLine("Welcome to my Application");
                    Console.WriteLine("YOU COULD GET \n 1=marksheet \n 2=calculator  \n 3=alphabets(lowercase and uppercase \n 4=even odd \n 5=leap year \n 6=table of 2)");

                    char op = Convert.ToChar(Console.ReadLine());

                    switch (op)
                    {
                        case '1':
                            {
                                Console.WriteLine("Marksheet");

                                Console.WriteLine("Enter Student name");
                                string n = Console.ReadLine();

                                Console.WriteLine("Enter Maths number");
                                Double num = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Enter Physics number");
                                Double num1 = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Enter Computer number");
                                Double num2 = Convert.ToDouble(Console.ReadLine());
                                double total, per;
                                total = num + num1 + num2;
                                per = total / 300 * 100;

                                Console.WriteLine("Total" + total);
                                Console.WriteLine("Percentage " + per);

                                if (per >= 80 && per <= 100)
                                {
                                    Console.WriteLine("Grade is A+");

                                }

                                else if (per >= 70 && per <= 79)
                                {
                                    Console.WriteLine("Grade is A");

                                }

                                else if (per >= 60 && per <= 69)
                                {
                                    Console.WriteLine("Grade is B");

                                }

                                else if (per >= 50 && per <= 59)
                                {
                                    Console.WriteLine("Grade is C");

                                }

                                else if (per >= 40 && per <= 49)
                                {
                                    Console.WriteLine("Grade is D");

                                }
                                else { Console.WriteLine("Fail"); }


                                break;

                            }

                        case '2':
                            { 

                            Console.WriteLine(" 1.Press 1 for Addition \n 2.Press 2 for Subtraction \n 3.Press 3 for Multiplication \n 4.Press 4 for Division");
                            Console.WriteLine("enter any option 1-4");
                            int number = Convert.ToInt32(Console.ReadLine());

                            switch (number)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Enter number 1");
                                        int number1 = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter number 2");
                                        int number2 = Convert.ToInt32(Console.ReadLine());
                                        int number3 = number1 + number2;
                                        Console.WriteLine("Addittion of " + number1 + " + " + number2 + " is :" + number3);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Enter number 1");
                                        int number4 = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter number 2");
                                        int number5 = Convert.ToInt32(Console.ReadLine());
                                        int number6 = number4 - number5;
                                        Console.WriteLine("Subtraction of " + number4 + " - " + number5 + " is :" + number6);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Enter number 1");
                                        int number7 = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter number 2");
                                        int number8 = Convert.ToInt32(Console.ReadLine());
                                        int number9 = number7 * number8;
                                        Console.WriteLine("Multiplication of " + number7 + " * " + number8 + " is :" + number9);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("Enter number 1");
                                        int number10 = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter number 2");
                                        int number11 = Convert.ToInt32(Console.ReadLine());
                                        if ((number10 % number11) == 0)
                                        {
                                            int number12 = number10 / number11;
                                            Console.WriteLine("Division of " + number10 + " / " + number11 + " is :" + number12);
                                        }
                                        else
                                        {
                                            double number12 = (double)number10 / number11;
                                            Console.WriteLine("Division of " + number10 + " / " + number11 + " is :" + Math.Round(number12, 2));
                                        }
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Invalid Option");
                                        break;
                                    }

                            }

                            break;
                    }

                        case '3':
                            { 
                            Console.WriteLine("Select capital or small alphabet");
                            char ch = Convert.ToChar(Console.ReadLine());

                            if (ch >= 65 && ch <= 90)
                            {
                                Console.WriteLine("It's a upper case");
                            }
                            else if (ch >= 97 && ch <= 122)
                            {
                                Console.WriteLine("It's a lower case");
                            }

                            else
                            {
                                Console.WriteLine("Invalid option");
                            }


                            break;
                                }
                        case '4':
                            Console.WriteLine("Choose even or odd number");
                            int check = Convert.ToInt32(Console.ReadLine());

                            if (check % 2 == 0)
                            {
                                Console.WriteLine("Even number  " + check);

                            }
                            else
                            {
                                Console.WriteLine("Odd number  " + check);
                            }

                            break;
                        case '5':
                            {
                                Console.WriteLine("Select year");
                                int check1 = Convert.ToInt32(Console.ReadLine());

                                if (check1 % 4 == 0)
                                {
                                    Console.WriteLine("It's a leap year  " + check1);

                                }
                                else
                                {
                                    Console.WriteLine("It's not a leap year  " + check1);
                                }
                            }
                            break;
                        case '6':
                            Console.WriteLine("Enter table value");
                            int table = Convert.ToInt32(Console.ReadLine());
                            int tb = 1;
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));
                            Console.WriteLine(table + "*" + tb + "=" + (table * tb++));

                            break;


                    }
                }

                else
                {
                    Console.WriteLine("Incorrect email or password");
                }

            }
            else
            {
                Console.WriteLine("Invalid operation");

            }
            Console.ReadKey();



        }
    }
}
