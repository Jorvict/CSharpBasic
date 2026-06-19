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

// El For puede tener varias condicionales siempre que se concatenen con ampersan &&
// For tiene 3 secciones, la primera es para declarar y definir variables/elementos
// La segunda sección es para indicar la condicional que se debe cumplir para que siga iterando
// La tercera sección es un fragmento de codigo que se ejecutara al finalizar la iteración, se usa para incrementar contador
bool run = true;
for(int i = 0; i < friends.Length && run; i++)
{
    Console.WriteLine(friends[i]);
}