using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8_8
{
    internal class Template : iTemplate
    {
        public void ponerVariable(string nombre, string var)
        {
            Console.WriteLine("Método poner poner variable {0} : {1}", nombre, var);
        }

        public void verHtml(string template)
        {
            Console.WriteLine(template);
        }
    }
}
