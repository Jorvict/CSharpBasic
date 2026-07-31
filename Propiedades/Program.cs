Sale mySale = new Sale(100, DateTime.Now);
mySale.Total = 223;
Console.WriteLine(mySale.Date);
Console.WriteLine(mySale.Total);

class Sale
{
    private int total;
    private DateTime date;

    /*
        Las propiedades protegen acceso.
        El constructor valida el estado inicial.
        Los métodos validan cambios de estado.
        Las reglas del negocio viven en la entidad.
        Un objeto inválido no debería existir.
     */

    // Esto es una propiedad, donde get y/o set es un accesor
    public int Total
    {
        get
        {
            //return total.ToString("#.00");
            return total;
        }
        set
        {
            if(value < 0 )
                value = 0;
            total = value;
        }
    }

    public string Date
    {
        get
        {
            return date.ToLongDateString();
        }
    }

    public Sale(int total, DateTime date)
    {
        //this.total = total;
        Total = total; // usa la propiedad
        this.date = date;
    }

}


/*
public class Sale
{
    public int Total { get; private set; }
    public DateTime Date { get; private set; }

    public Sale(int total, DateTime date)
    {
        if (total <= 0)
            throw new ArgumentException("El total debe ser mayor que cero.");

        if (date > DateTime.Now)
            throw new ArgumentException("La fecha no puede ser futura.");

        Total = total;
        Date = date;
    }

    public void ApplyDiscount(int percentage)
    {
        if (percentage <= 0 || percentage > 100)
            throw new ArgumentException("El porcentaje debe estar entre 1 y 100.");

        var discountAmount = Total * percentage / 100;
        var newTotal = Total - discountAmount;

        if (newTotal <= 0)
            throw new InvalidOperationException("El total no puede quedar en cero o negativo.");

        Total = newTotal;
    }
}
 
*/