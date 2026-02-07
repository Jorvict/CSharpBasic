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
bool run = true;
for(int i = 0; i < friends.Length && run; i++)
{
    Console.WriteLine(friends[i]);
}