// Static es una palabra que nos permite que algo sea perteneciente al tipo, en este caso la Clase y no al objeto en si
// Es decir, la clase tiene propiedades y métodos, generalmente para acceder a ellos lo hacemos desde el objeto creado a través de una instancia
// Sin embargo al usar static, esta propiedad o método no pertenecerá al objeto en sí mismo sino a la Clase


// Si usamos las llaves al instanciar podremos agregarle las propiedades automaticamente haciendo uso del set
People people1 = new People()
{
    Name = "Jorvict",
    Age = 27
};

People enrique = new People()
{
    Name = "Enrique",
    Age = 28
};

Console.WriteLine(People.Count);

public class People
{
    public static int Count = 0;

    public string Name { get; set; }
    public int Age { get; set; }

    public People()
    {
        Count++;
    }

    public static string GetCount()
    {
        // string interpolation
        return $"Esta clase se ha utilizado {Count} veces";
    }
}

// Cuando usamos static a nivel de Clase, todas sus propiedades y métodos deben ser static
public static class A
{
    public static void Some()
    {
        Console.WriteLine("algo");
    }
}