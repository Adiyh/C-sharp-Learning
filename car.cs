using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Typesofconstructor
{
    internal class car
    {
        static string model;
        static car()
        {
            model = "Victus";
            Console.WriteLine(model);
        }
    }
}
