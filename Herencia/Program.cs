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

class Empleado:Persona
{
    public string NumEmpleado{get; set;}

    public Empleado(string nombre, string numEmpleado):base(nombre)
    {
        NumEmpleado = numEmpleado;
    }
    public void Imprime()
    {
        Console.WriteLine($"{this.NumEmpleado}{this.Nombre}");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Persona p1= new Persona("Alicia");
        Empleado e1= new Empleado ("Alicia","005")
        Persona em= new Empleado ("Alicia","055")
        p1.Imprime();
        e1.Imprime();
        em.Imprime();
    }
}