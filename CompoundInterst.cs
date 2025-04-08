using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcalculator
{
    internal class CompoundInterst

    {
        public void calculateCInterst()
        {
            int p = 0, t, r;
            int a, k, n;
            int b;
            int result = 0;
            Console.WriteLine("Enter the Future Amount :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Principal amount :");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Percentage :");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the No of times interest compounded per year :");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Time in years :");
            t = int.Parse(Console.ReadLine());

            result = (int)(p * Math.Pow((1 + (double)r / 100 / n), n * t));

            Console.WriteLine("Compound Interest is " + (result - b));
        }
    }
}
