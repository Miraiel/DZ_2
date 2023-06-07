using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.Write("Enter iteger A: ");
            string line1 = Console.ReadLine();
            A = Convert.ToInt32(line1);


            Console.Write("Enter iteger B: ");
            string line2 = Console.ReadLine();
            B = int.Parse(line2);


            Console.Write("Enter iteger C: ");
            string line3 = Console.ReadLine();
            bool res = int.TryParse(line3, out C);             
            if (res == false)
            {
                Console.WriteLine("String is not a number");
                Console.ReadKey();
                return;
            }
            else
            {
                if (C > A || C > B)
                {
                    Console.WriteLine("There is no space for square.");
                }
                else
                {
                    int X = A / C * B / C;
                    Console.WriteLine("\n\nThere are {3} squares ({2}x{2}) on your rectangle ({0}x{1}).\nFree (non occupied by squares) space of the rectangle is {4}.", A, B, C, X, (A * B) - C * C * X);
                }
            }

            Console.ReadKey();
        }
    }
}
