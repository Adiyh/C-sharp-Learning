using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcalculator
{
    internal class Simpleinterst

    {
        public void calculateSimpleInterst()

        {
            int p = 0, t, r;
            int a, k, n;
            int b;
            int result = 0;
            Console.WriteLine("Enter Values Principle, Time, Interst");
            p = int.Parse(Console.ReadLine());
            t = int.Parse(Console.ReadLine());
            r = int.Parse(Console.ReadLine());

            result = (p * t * r) / 100;
            Console.WriteLine("Simple  Interest is " + result);


        }
        }
}
