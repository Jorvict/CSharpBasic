Sale sale1 = new Sale(100, DateTime.Now);
Sale sale2 = new Sale(200, DateTime.Now);
Console.WriteLine( sale1.GetInfo() );
Console.WriteLine( sale2.GetInfo() );



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