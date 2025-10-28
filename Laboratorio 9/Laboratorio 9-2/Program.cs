internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el valor del primer lado del triángulo.");
        int lado_uno = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el valor del segundo lado del triángulo.");
        int lado_dos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de la base del triángulo.");
        int lado_base = Convert.ToInt32(Console.ReadLine());

        if (lado_uno + lado_dos > lado_base)
        {
            if (lado_dos == lado_base && lado_dos == lado_uno)
            {
                Console.WriteLine("Los valores ingresados forman un triángulo equilátero.");
            }
            else
            {
                if (lado_dos == lado_base || lado_dos == lado_uno || lado_uno == lado_base)
                {
                    Console.WriteLine("Los valores ingresados forman un triángulo isósceles.");
                }
                else
                {
                    Console.WriteLine("Los valores ingresados forman un triángulo escaleno.");
                }
            }
        }
        else
        {
            Console.WriteLine("Los valores ingresados no forman un triángulo válido.");
        }
    }
}