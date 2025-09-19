internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la nota del estudiante");
        float score = float.Parse(Console.ReadLine());

        if (score >= 70)
        {
            Console.WriteLine();
            Console.WriteLine("Su nota es {0}, ha aprobado la materia.", score);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Su nota es {0}, ha reprobado la materia, debe repetirla.", score);
        }
    }
}