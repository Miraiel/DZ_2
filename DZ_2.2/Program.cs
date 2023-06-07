using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal capital = 1000.0000m;
            decimal capitalLimit = 1100.00m;
            float P = 0, Pmin = 0, Pmax = 25;
            Byte K = 0;
            bool res = false, range = false;


            while (res == false)
            {
                Console.Write("Input interest rate (float P) : ");
                string line = Console.ReadLine();
                res = float.TryParse(line, out P);
                if (res == false)
                    Console.WriteLine("\n  It is not a float.");
                else
                {
                    while (range == false)
                    {
                        if (P < Pmin || P > Pmax)
                        {
                            Console.WriteLine("\n P is out of range 0...25.");
                            res = false;
                            break;
                        }
                        else
                            range = true;
                    }
                }
            }
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Interest rate is " + P.ToString() + "%.\n");
            capital = decimal.Round(capital, 2);
            Console.WriteLine(string.Format(" Your capital is {0} bucks now.\n", capital.ToString()));

            do
            {
                capital += capital * (decimal)P / 100;
                capital = decimal.Round(capital, 2);
                K++;
                Console.WriteLine(string.Format("{0}\t{1}", K, capital));
            } while (capital < capitalLimit);

            Console.WriteLine(string.Format("\n\n So, your capital will reach {1} bucks just after {0} months.", K, capital));

            Console.ReadKey();
        }
    }
}
