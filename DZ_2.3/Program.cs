using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a = 3, b = 7;

            for (uint i = a; i <= b; ++i)
            {
                for (uint j = 0; j < i; ++j)
                {
                    Console.Write(i.ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
