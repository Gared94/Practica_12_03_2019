using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Opr
    { private double monto;
        private string nombre;


        //constructor 1
        public Opr()
        {
            this.monto=0;
            this.nombre="";
        }
            //Constructor 2
            public Opr(int val1)
            {
                monto = val1;
                
            }

        //Constructor 3
            public Opr(int val1, string nom)
            {
                monto = val1;
                nombre = nom;

            }
            public void mostrar()
            {
                Console.WriteLine(monto);

            }
            public void mostrar1()
            {
                Console.WriteLine(monto+nombre);

            }

    }
}
