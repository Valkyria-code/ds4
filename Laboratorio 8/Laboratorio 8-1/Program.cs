using Laboratorio_8_1;

internal class Program
{
    private static void Main(string[] args)
    {
        const string CUENTA = "100";

        Cuenta cuenta = new Cuenta(CUENTA);

        CuentaCorriente cuentaCorriente = new CuentaCorriente(CUENTA);

        CuentaAhorro cuentAhorro = new CuentaAhorro(CUENTA);

        cuenta.CalcularIntereses();
        cuentaCorriente.CalcularIntereses();
        cuentAhorro.CalcularIntereses();
    }
}