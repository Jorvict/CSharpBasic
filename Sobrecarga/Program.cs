Math math = new Math();
Console.WriteLine(math.Sum(1,2));
Console.WriteLine(math.Sum("1", "2") );

int[] numbers = new int[] { 1, 2, 5 };
 Console.WriteLine(math.Sum(numbers));

class Math
{

    public int Sum(int a, int b)
    {
        return a + b;
    }

    // Podemos hacer una sobrecarga de función, lo que consiste en tener 2 o mas funciones con el mismo nombre
    // Pero que ejecuten cosas distintas EN BASE A LOS TIPOS Y CANTIDAD DE DATOS QUE RECIBIMOS, no se va a guiar
    // de lo que retornamos, sino de lo que le pasamos, por ejemplo en la primera función pasamos ints y en la
    // segunda función pasamos strings, a pesar de que ambos retornan ints, lo que no podriamos es por ejemplo
    // poner una tercera función que retorne string pero que reciba los mismos ints que la segunda función ya que ahí
    // no podría diferenciar la sobrecarga porque los parametros y sus tipos de dato serían iguales
    public int Sum(string a, string b)
    {
        return int.Parse(a) + int.Parse(b);
    }

    public int Sum(int[] numbers)
    {
        int result = 0;
        int i = 0;

        while (i < numbers.Length)
        {
            result += numbers[i];
            i++;
        }

        return result;
    }
    
}