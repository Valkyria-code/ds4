internal class Program
{
    public static void Main(string[] args)
    {
        int primerNumero, segundoNumero;
        CalculosMatematicos calculo = new CalculosMatematicos();

        Console.Write("Introduce el primer número: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("La operación ({0} + {1}) * ({0} - {1}) da como resultado {2}", primerNumero, segundoNumero, calculo.Calcular(primerNumero,segundoNumero));
    }
}

public class CalculosMatematicos
{
    public int Calcular(int a, int b)
    {
        return ((a + b) * (a - b));
    }
}