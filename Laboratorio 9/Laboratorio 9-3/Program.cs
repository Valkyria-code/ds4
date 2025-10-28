using Laboratorio_9_3;

internal class Program
{
    private static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();

        Console.Write("Ingrese un número mínimo: ");
        int min = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese un número máximo: ");
        int max = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la dimensión del arreglo: ");
        int dimension = Convert.ToInt32(Console.ReadLine());

        int numeroAleatorio = aleatorios.GenerarNumero(min, max);

        Console.WriteLine($"1. Número aleatorio entre {min} y {max}: {numeroAleatorio}");

        int[] arregloConRepetidos = aleatorios.GenerarArreglo(min, max, dimension);

        Console.WriteLine($"\n2. Arreglo de {dimension} con números entre {min} y {max}:");
        Console.WriteLine($"   [{string.Join(", ", arregloConRepetidos)}]");

        // 3. Generar un arreglo de números SIN REPETIR con rangos aleatorios
        int minRandom = aleatorios.GenerarNumero(1, 10);
        int maxRandom = aleatorios.GenerarNumero(20, 50);
        int dimensionRandom = aleatorios.GenerarNumero(5, 15);

        Console.WriteLine("\n3. Arreglo de números NO REPETIDOS:");
        Console.WriteLine($"   Rango aleatorio: [{minRandom}, {maxRandom}]");
        Console.WriteLine($"   Cantidad: {dimensionRandom} números");

        int[] arregloSinRepetir = aleatorios.GenerarArregloSinRepetir(minRandom, maxRandom, dimensionRandom);
        Console.WriteLine($"   Resultado: [{string.Join(", ", arregloSinRepetir)}]");

        Console.ReadKey();
    }
}