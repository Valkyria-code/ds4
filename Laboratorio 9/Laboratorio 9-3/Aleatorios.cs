using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_9_3
{
    internal class Aleatorios
    {
        Random rand = new Random();

        public int GenerarNumero(int min, int max)
        {
            return rand.Next(min, max + 1);
        }

        public int[] GenerarArreglo(int min, int max, int dimension)
        {
            int[] arreglo = new int[dimension];

            for (int i = 0; i < dimension; i++)
            {
                arreglo[i] = GenerarNumero(min, max);
            }

            return arreglo;
        }

        public int[] GenerarArregloSinRepetir(int min, int max, int dimension)
        {
            HashSet<int> numerosUnicos = new HashSet<int>();

            while (numerosUnicos.Count < dimension)
            {
                int numero = GenerarNumero(min, max);
                numerosUnicos.Add(numero);
            }

            return numerosUnicos.ToArray();
        }
    }
}
