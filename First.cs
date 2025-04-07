using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Typesofconstructor;

namespace Typesofconstructor
{
    public class First
    {
        int a;
        int b;
        static First()
        {
            Console.WriteLine("Static Constructor is created");
        }
        public First()
        {
            Console.WriteLine("NON static constructor");
        }
     
        public First(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void firstmethod()
        {
            Console.WriteLine("Welcome to Hassan");
            Console.WriteLine(a + " " + b); // Added space between a and b
        }
    }
}
