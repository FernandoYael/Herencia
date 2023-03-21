class Persona
{
    public string Nombre{get; set;}

    public Persona(string nombre)
    {
        Nombre = nombre;
    }
    public virtual void Imprime()
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
        base.Imprime();
        Console.WriteLine($"{this.NumEmpleado}{this.Nombre}");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        List<Persona> personas= new List<Persona>();
        personas.Add[new Persona("Alicia")];
        personas.Add[new Empleado ("Alicia","005")];
        personas.Add[new Empleado ("Alicia","055")];
        foreach(var p in personas)
        p.Imprime();
    }
}