using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8_3
{
    internal class CuentaBancaria
    {
        public decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }

            set
            {
                if (value >= 0)
                {
                    saldo = value;
                }
                else
                {
                    throw new ArgumentException("El saldo no puede ser negativo.");
                }
            }
        }
    }
}
