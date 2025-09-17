internal class Program
{
    public static void Main(string[] args)
    {
        int baseRec, altura;
        CalculosMatematicos calculo = new CalculosMatematicos();

        Console.Write("Introduce la base del rectángulo: ");
        baseRec = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce la altura del rectángulo: ");
        altura = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("El rectángulo con base {0} y altura {1} tiene un perímetro de {2}", baseRec, altura, calculo.calculoPerimetroRectangulo(baseRec,altura));
    }
}

public class CalculosMatematicos
{
    public int Calcular(int a, int b)
    {
        return ((a + b) * (a - b));
    }

    public double calculoArea(int a)
    {
        double radio = a;

        return (Math.PI * Math.Pow(radio, 2));
    }

    public int calculoPerimetroRectangulo(int a, int b)
    {
        return 2 * (a + b);
    }
}