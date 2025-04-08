using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Newcalculator
{
    internal class DemoCalculator
    {
       
        public void Calculatorfunction()
        {
            int k;
            Console.WriteLine("Choose the Operation you want to perform");
            Console.WriteLine("1.Arithmatic");
            Console.WriteLine("2.Simple Interest");
            Console.WriteLine("3.Compound Interest");
            
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your choice (1-3):");
                    k = int.Parse(Console.ReadLine());

                    
                    if (k >= 1 && k <= 3)
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1 and 3.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            if (k == 1)
            {
                Arithmatic ar = new Arithmatic();
                ar.calculatearithmatic();
               

            }
            else if (k == 2)
            {
                Simpleinterst si = new Simpleinterst();
                si.calculateSimpleInterst();
            }
            else if (k == 3)
                {
                 CompoundInterst ci = new CompoundInterst();
                ci.calculateCInterst();

                }
         
         
            

        }




    }
}

