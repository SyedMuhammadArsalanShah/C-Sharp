using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = Convert.ToChar(Console.ReadLine());
            if ((character >= 65 && character <= 90) || (character >= 97 && character <= 122))
            {
                Console.WriteLine("its a alphabet" + character);
                Console.WriteLine("now you can change your alphabet by clicking yes ");
                String checker = Console.ReadLine();
                if (checker == "Yes" || checker == "yes")
                {

                    if (character >= 65 && character <= 90)
                    {
                        char lower = (char)(character + 32);

                        Console.WriteLine("Lowercase =" + lower);

                    }
                    else if (character >= 97 && character <= 122)
                    {
                        char upper = (char)(character - 32);

                        Console.WriteLine("Uppercase =" + upper);

                    }
                }
                else { Console.WriteLine("Thank You now you can go"); }
            }
            else if (character >= 48 && character <= 57)
            {
                Console.Write("its a number");
            }
            else if ((character >= 32 && character <= 64) || (character >= 91 && character <= 96) || (character >= 123 && character <= 126) || (character >= 145 && character <= 152))
            {
                Console.WriteLine("its a symbol");
            }
            else { Console.WriteLine("invalid syntax"); }
            Console.ReadKey();
        }
    }
}
