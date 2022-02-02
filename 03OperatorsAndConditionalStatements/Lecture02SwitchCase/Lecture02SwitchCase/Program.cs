using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture02SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            char vowels = Convert.ToChar(Console.ReadLine());
            switch (vowels)
            {
                case 'A':
                case 'a':
                    {
                        Console.WriteLine("its a vowel");
                        break;
                    }
                case 'I':
                case 'i':
                    {
                        Console.WriteLine("its a vowel");
                        break;
                    }
                case 'O':
                case 'o':
                    {
                        Console.WriteLine("its a vowel");
                        break;
                    }
                case 'U':
                case 'u':
                    {
                        Console.WriteLine("its a vowel");
                        break;
                    }
                case 'E':
                case 'e':
                    {
                        Console.WriteLine("its a vowel");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("its not a vowel");
                        break;
                    }
            }


            Console.ReadKey();

        }
    }
}
