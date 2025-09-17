internal class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();
        client.FirstName = "Su nombre";
        client.LastName = "Su apellido";
        client.Age = 15;
        client.Id = 1;

        Console.WriteLine(client.GetFullName());
    }
}

public class Client
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ushort Age { get; set; }

    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }
}