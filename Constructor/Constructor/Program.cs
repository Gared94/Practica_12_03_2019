using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static Opr obj,obj2,obj3;
        static void Main(string[] args)
        {
            obj = new Opr();
            obj2 = new Opr(30);
            obj3 = new Opr(21, " test");
            obj2.mostrar();
            obj3.mostrar1();
            Console.ReadLine();
        }
    }
}
