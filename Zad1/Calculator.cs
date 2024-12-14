using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public static class Calculator
    {
        public static void Comparator(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("Equal (X = Y)");
            }
            else if (x > y)
            {
                Console.WriteLine("Greater (X > Y)");
            }
            else
            {
                Console.WriteLine("Lesser (X < Y)");
            }
        }
    }
}
