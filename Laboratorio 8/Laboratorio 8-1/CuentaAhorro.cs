using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8_1
{
    public class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(string prmtIdCuenta) : base(prmtIdCuenta)
        {
        }

        public override void CalcularIntereses()
        {
            System.Console.WriteLine("CuentaAhorro.CalcularInteres() efectuado para la cuenta {0}", getIdCuenta());
        }
    }
}
