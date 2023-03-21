class Persona
{
    public string Nombre{get; set;}

    public Persona(string nombre)
    {
        Nombre = nombre;
    }
    public void Imprime()
    {
        Console.WriteLine(Nombre);
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        Persona p1= new Persona("Alicia");
        p1.Imprime();
    }
}