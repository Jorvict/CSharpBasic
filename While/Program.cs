int i = 0;

while(i < 10)
{
    Console.WriteLine("Iteración de i " + i);
    i++;
}

int j = 0;
while(j < 100)
{
    // En C# si solo tienes una instrucción dentro del IF no es obligatorio poner llaves
    if (j > 10)
        break;


    Console.WriteLine("Iteración de j " + j);
    j++;
}


string[] friends = new string[7]
{
    "Ada",
    "Emily",
    "Daniel",
    "Cristian",
    "Diego",
    "Mario",
    "Jorvict"
};

int index = 0;
while (index < friends.Length)
{
    Console.WriteLine(friends[index]);
    index++;
}


bool run = false;
do
{
    Show();
} while (run);

static void Show()
{
    Console.WriteLine("Entro una vez y ya");
}