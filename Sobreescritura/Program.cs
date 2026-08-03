
B b = new B();
Console.WriteLine(b.Hi() );

Sale sale = new Sale(10);
sale.Add(2);
sale.Add(3);
Console.WriteLine(sale.GetTotal());

SaleWithTax saleWithTax = new SaleWithTax(10, 1.18m);
saleWithTax.Add(1);
saleWithTax.Add(2);
saleWithTax.Add(3);
saleWithTax.Add(4);
Console.WriteLine(saleWithTax.GetTotal());


public class A
{

    // AL usar la palabra reservada "Virtual" en algún método, podemos nosotros sobreescribir ese método desde
    // alguna clase hija, pero tener muy en cuenta en la clase hija que se sobreescribirá se debe usar override
    public virtual string Hi()
    {
        return "Hola soy A";
    }
}

public class B : A
{
    // No olvidar que la palabra reservada override va justo antes del tipo de dato que retornará el método
    // Un punto a tener en cuenta es que la sobreescritura no solo se limita a "chancar" la función, también
    // puede expandirla, y para ello se utiliza la palabra reservada "base"
    public override string Hi()
    {
        // al usar base.Hi() se está ejecutando el método del padre y adicional se le adiciona mas instrucciones
        return base.Hi() + " Hola soy B";
    }
}

public class Sale
{
    // Buscar buenas practicas para nombrar elementos privados como variables, metodos, clases, tablas, etc segun microsoft
    private decimal[] _amounts;
    private int _n;
    private int _end;

    public Sale(int n)
    {
        _amounts = new decimal[n];
        _n = n;
        _end = 0;
    }

    public void Add(decimal amount)
    {
        if(_end < _n)
        {
            _amounts[_end] = amount;
            _end++;
        }
    }

    public virtual decimal GetTotal()
    {
        decimal result = 0;
        int i = 0;
        while (i < _amounts.Length)
        {
            result += _amounts[i];
            i++;
        }

        return result;
    }
}

public class SaleWithTax : Sale
{
    private decimal _tax;

    public SaleWithTax(int n, decimal tax) : base(n)
    {
        _tax = tax;
    }

    public override decimal GetTotal()
    {
        return base.GetTotal() * _tax;
    }
}