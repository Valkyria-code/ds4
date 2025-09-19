internal class Program
{
    public static void Main(string[] args)
    {
        int radio;
        CalculosMatematicos calculo = new CalculosMatematicos();

        Console.Write("Introduce el radio del círculo: ");
        radio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("El área del círculo con radio {0} es de {1}", radio, calculo.calculoArea(radio));
    }
}

public class CalculosMatematicos
{
    public int Calcular(int a, int b)
    {
        return ((a + b) * (a - b));
    }

    public double calculoArea(int r)
    {
        double radio = r;

        return (Math.PI * Math.Pow(radio, 2));
    }
}