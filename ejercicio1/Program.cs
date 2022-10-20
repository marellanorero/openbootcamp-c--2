// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduce your name");
string nombre = Console.ReadLine();

// Edad
Console.WriteLine("Introduce your age");
int edad = Convert.ToInt32(Console.ReadLine());

// Ciudad
Console.WriteLine("Introduce your city");
string city = Console.ReadLine();

// Presentar mensaje "Hola, NOMBRE. Tienes AÑOS. Vives en CIUDAD
Console.Write("Hello, " + nombre);
Console.Write(". Your age is " + edad);
Console.Write(". You're live in " + city + ".");
