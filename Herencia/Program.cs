Doctor doctor1 = new Doctor("Jorvict", 27, "Cardiologo");
Console.WriteLine(doctor1.GetInfo());
Console.WriteLine(doctor1.GetData());

Dev dev1 = new Dev("Jed", 27, "C#");
Console.WriteLine(dev1.GetInfo());
Console.WriteLine(dev1.GetData());

class People
{
    // Cuando el atributo es privado, por convención se le coloca un guión bajo
    private string _name;
    private int _age;

    public People(string name, int age)
    {
        _name = name;
        _age = age;
    }

    // Cuando el método o atributo es publica puedes usarla tanto dentro como fuera de la clase
    // Cuando el método o atributo es protected puedes usarla dentro de la propia clase y dentro de clases hijas
    // Cuando el método o atributo es private solo puedes usarla dentro de la propia clase, no se puede usar por fuera de la clase ni en clases hijas
    public string GetInfo()
    {
        return _name + " " + _age;
    }
}

class Doctor : People
{
    private string _speciality;

    // ´Los parametros de doctor se pasan al constructor del padre usando dos puntos ":" (igual que la herencia), y utilizando base
    public Doctor(string name, int age, string speciality) : base(name, age)
    {
        _speciality = speciality;
    }

    public string GetData()
    {
        return GetInfo() + " " + _speciality;
    }
}

class Dev : People
{
    private string _language;

    public Dev(string name, int age, string language) : base(name, age)
    {
        _language = language;
    }

    public string GetData()
    {
        return GetInfo() + " " + _language;
    }
}