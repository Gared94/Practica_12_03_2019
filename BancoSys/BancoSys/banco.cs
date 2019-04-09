using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSys
{
    class banco
    {

        clientes obj;
        clientes obj1;
        clientes obj2;

        public banco() 
        {
            obj = new clientes("Jose");
            obj1 = new clientes("Daniel");
            obj2 = new clientes("Juana");
        }
        public void operar()
        {
            obj.depositar(40000000);
            obj1.depositar(-300);
            obj2.depositar(0.01);
            obj.depositar(200);
            obj.retirar(100);
            obj1.depositar(-300);
            obj1.depositar(1000);
            obj.retirar(400);
        }
        public void depositoTotal()
        {
            Console.WriteLine("Total cliente 1 " + obj.nombre +" "+ obj.retornarMonto());
            Console.WriteLine("Total cliente 2 " + obj1.nombre + " " + obj1.retornarMonto());
            Console.WriteLine("Total cliente 3 " + obj2.nombre + " " + obj2.retornarMonto());
        }

    }
}
