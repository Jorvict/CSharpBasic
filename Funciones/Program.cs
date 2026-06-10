int a = 1;
int b = 2;

int c = a + b;

Show();
Sum(a, b);

int m = Mul(5, 5);
Console.WriteLine(m);

//void indica que la funcion no va a retornar información
static void Show()
{
    Console.WriteLine("Hola, soy un texto que se imprime desde funciones");
}

// Función con parametros
static void Sum(int num1, int num2)
{
    // cw y luego doble tab es un snippet para poner console.writeline
    int num3 = num1 + num2;
    Console.WriteLine(num3);
}

// Funcion que recibe argumentos y retorna información
static int Mul(int num1, int num2)
{
    return (num1 * num2);
}