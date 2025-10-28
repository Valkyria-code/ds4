internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("El siguiente còdigo imprime los nùmeros pares o divisibles entre 3.");

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                Console.WriteLine("El nùmero {0} es un número par divisible entre 3.", i);
            }
            else
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("El nùmero {0} es un número par.", i);
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine("El nùmero {0} es un número divisible entre 3.", i);
                    }
                }
            }
        }
    }
}