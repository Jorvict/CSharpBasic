Sale sale1 = new Sale(100, DateTime.Now);
Sale sale2 = new Sale(200, DateTime.Now);
Console.WriteLine( sale1.GetInfo() );
Console.WriteLine( sale2.GetInfo() );

// Un objeto es una representación de una entidad que tiene propiedades y funcionalidades
// Un carro tiene propiedaeds, cantidad de puertas, color, tipo de motor, etc
// Un carro tiene funcionalidades, se prende, frena, corre, etc

// Una clase es el molde que sirve para crear estos objetos, es decir su definición

class Sale
{
    int total;
    DateTime date;

    // Constructor
    public Sale(int total, DateTime date)
    {
        this.total = total;
        this.date = date;
    }



    // public hace referencia a que este método se puede acceder al crear el objeto y desde fuera de la clase
    // private no permite acceso al crear el objeto, solo se podrá usar dentro de la clase
    public void Show()
    {
        Console.WriteLine("Hola soy una venta");
    }

    public string GetInfo()
    {
        return total + " " + date.ToLongDateString();
    }
}