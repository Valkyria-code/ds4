using System.Timers;

internal class Program
{
    public static void Main(string[] args)
    {
        int Ene;
        Random rand = new Random();
        long producto = 1;

        do
        {
            Console.Write("Ingrese un número impar, mayor o igual a 3.\n");
            Ene = Convert.ToInt32(Console.ReadLine());

            if (Ene < 3 || Ene % 2 == 0)
            {
                Console.WriteLine("Error: El número debe ser impar y mayor o igual a 3.");
            }

        } while (Ene < 3 || Ene % 2 == 0);

        int[,] patron = new int[Ene, Ene];

        for (int i = 0; i < Ene; i++)
        {
            for (int j = 0; j < Ene; j++)
            {
                if (j % 2 != 0)
                {
                    patron[i, j] = rand.Next(101, 201);
                    producto *= patron[i, j];
                }
                else
                {
                    patron[i, j] = 0;
                }
            }
        }

        Console.WriteLine("La matriz generada es la siguiente: ");
        for (int i = 0; i < Ene; i++)
        {
            for (int j = 0; j < Ene; j++)
            {
                Console.Write(patron[i, j].ToString().PadLeft(5));
            }
            Console.WriteLine();
        }

        Console.WriteLine("El producto de todos los números aleatorios da como resultado: {0}", producto);
    }
}