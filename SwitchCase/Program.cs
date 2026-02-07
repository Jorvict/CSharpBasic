int op = 8;

switch (op)
{
    case 1:
        Console.WriteLine("Seleccionaste el 1");
        break;
    case 2:
        Console.WriteLine("Seleccionaste el 2");
        break;
    //casos anidados
    case 3:
    case 4:
        Console.WriteLine("Seleccionaste la opción 3 o 4");
        break;
    //condiciones con simbolos operadores
    case < 0:
    case > 100:
        Console.WriteLine("Fuera de rango");
        break;
    case > 4 and < 10:
        Console.WriteLine("Seleccionaste una opcion entre 4 y 10");
        break;
    default:
        Console.WriteLine("Invalido");
        break;
}