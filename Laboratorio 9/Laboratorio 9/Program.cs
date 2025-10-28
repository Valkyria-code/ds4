internal class Program
{
    private static void Main(string[] args)
    {
        int usuario_precio, forma_pago, nums_cuenta;
        string cuenta;

        do 
        {
            Console.Write("Estimado usuario, ingrese el precio del producto: ");
            usuario_precio = Convert.ToInt32(Console.ReadLine());

            if (usuario_precio < 0)
            {
                Console.WriteLine("Error: El precio no puede ser negativo. Por favor, intente de nuevo.");
            }
            else
            {
                Console.WriteLine("Precio aceptado.");
            }

        } while (usuario_precio < 0);

        Console.WriteLine($"El precio ingresado es: {usuario_precio}");

        do
        {
            Console.Write("Elija una forma de pago: Efectivo (1) o Tarjeta (2): ");
            forma_pago = Convert.ToInt32(Console.ReadLine());

            if (forma_pago != 1 && forma_pago != 2)
            {
                Console.WriteLine("Error: Forma de pago inválida. Por favor, intente de nuevo.");
            }
            else
            {
                if (forma_pago == 1)
                {
                    Console.WriteLine("Ha elegido pagar en efectivo.");
                }
                else
                {
                    if (forma_pago == 2)
                    {
                        Console.WriteLine($"Ha elegido pagar con tarjeta.");

                        do
                        {
                            Console.Write("Ingrese el número de cuenta: ");
                            cuenta = Console.ReadLine();
                            nums_cuenta = cuenta.Length;

                            if (nums_cuenta < 16 || nums_cuenta > 16)
                            {
                                Console.WriteLine("Error: Número de cuenta inválido (El número de cuenta debe tener 16 dígitos).");
                            }
                            else
                            {
                                Console.WriteLine("El monto será cobrado a su cuenta");
                            }
                        } while (nums_cuenta < 16 || nums_cuenta > 16);
                    }
                }
            }
        } while (forma_pago != 1 && forma_pago != 2);
    }
}