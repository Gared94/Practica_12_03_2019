using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSys
{
    class Program
    {
        static void Main(string[] args)
        {
            banco ban = new banco();
            ban.operar();
            ban.depositoTotal();
            Console.ReadKey();
        }
    }
}
