using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSys
{
    class clientes
    {
        public string nombre;
        public double monto;
        public clientes()
        {
            nombre = "";
            monto=0;
        }

        public clientes(string nom)
        {
            this.nombre = nom;
            this.monto = 0;
        }

        public void depositar(double monto)
        {
            this.monto = this.monto + monto;
        }
        public void retirar(double monto)
        {
            this.monto = this.monto - monto;
        }
        public double retornarMonto() {
            return monto;
        }
    }
}
