using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcalculator
{
    internal class Arithmatic
    {
        public void calculatearithmatic()
        {

            int a=0, b, result = 0;
            try
            {
                Console.WriteLine("Enter 1st number");
                a = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {

                Console.WriteLine("Please Enter a valid number ") ;
                a = int.Parse(Console.ReadLine());
            }
            try
            {
                Console.WriteLine("Enter 2nd number");
                b = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter a valid number ");
                b = int.Parse(Console.ReadLine());
            }
            char op='\n'  ;



            try
            {
                Console.WriteLine("Enter the Operator");
                op = (char)Console.Read();
            }
            catch (ArithmeticException)
            {

                Console.WriteLine("Enter a valid operator");
                op = (char)Console.Read();
            }
            
            
            
          

            switch (op)
            {
                case '+':
                    Console.WriteLine(result = a + b);
                    break;
                case '-':
                    Console.WriteLine(result = a - b);
                    break;
                case '*':
                    Console.WriteLine(result = a * b);
                    break;
                case '/':
                    Console.WriteLine(result = a / b);
                    break;
              
            }
        }
    }
}