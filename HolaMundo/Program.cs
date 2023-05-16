Console.WriteLine("Introduce tu nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Introduce tu apellido:");
string apellido = Console.ReadLine();
Console.WriteLine("Introduce tu edad:");
string edad = Console.ReadLine();

Console.WriteLine("Hola " + nombre + " " + apellido + ", tu edad es " + edad + " años");

string datetime = DateTime.Now.ToString("hh:mm:ss tt");
Console.WriteLine(datetime);