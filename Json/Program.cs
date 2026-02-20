using System.Text.Json;

Beer myBeer = new Beer()
{
    Name = "Pikantus",
    Brand = "Erdinger"
};

// string json = "{\"Name\": \"Pikantus\" , \"Brand\": \"Erdinger\"}";

// Se conoce como Serialización de un objeto al convertir un objeto en formato JSON (cadena)
string json = JsonSerializer.Serialize(myBeer);

// Se conoce como Deserializacion convertir un JSON (cadena) en un objeto
// El deserializador funciona con generics, por lo cual hay que pasarle el tipo al cual queremos que nos convierta
Beer beer = JsonSerializer.Deserialize<Beer>(json);

Beer[] beers = new Beer[]
{
    new Beer()
    {
        Name = "Pikantus",
        Brand = "Erdinger"
    },
    new Beer() {
        Name = "Corona",
        Brand = "Modelo"
    }
};



//string json2 = "[" +
//    "{\"Name\": \"Pikantus\", \"Brand\": \"Erdinger\"}, " +
//    "{\"Name\": \"Corona\", \"Brand\": \"Modelo\"}, " +
//    "]";

string json2 = JsonSerializer.Serialize(beers);

// En este caso al ser un arreglo de objetos debemos especificar que es una colección, un arreglo
Beer[] beers2 = JsonSerializer.Deserialize<Beer[]>(json2);

Console.WriteLine(json2);

// Basicamente Serialize es para el enviar el json estructurado a otro sistema o componente
// Y Deserialize es para cuando nos envian un JSON y deseamos descomponerlo en un objeto en nuestro sistema

public class Beer
{
    public string Name { get; set; }
    public string Brand { get; set; }
}