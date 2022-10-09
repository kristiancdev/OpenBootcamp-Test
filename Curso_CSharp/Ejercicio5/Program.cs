Console.WriteLine("===== Ejercicio1 =====");
/* DATOS CLIENTE */
string nombre = string.Empty;
string email = string.Empty;
int cupon = 0;

Console.WriteLine("Nombre del cliente:");
nombre = Console.ReadLine();
Console.WriteLine("Ingrese su email:");
email = Console.ReadLine();
Console.WriteLine("¿Posee cúpon?, ingrese el valor");
cupon = Int32.Parse(Console.ReadLine());

/* DATOS PRODUCTO */
string producto = "Laptop";
double precio = 1500;

if (cupon != 0)
{
    Console.WriteLine($"El cliente posee un cupon con:{cupon}% de descuento");
    Console.WriteLine($"El valor de la {producto} aplicando el descuento es: ${(precio - (precio * cupon) / 100)}");
}
else
{
    Console.WriteLine($"El cliente no posee un cupon de descuento");
    Console.WriteLine($"No {producto} sin descuento: ${precio}");
}

Console.WriteLine("===== Ejercicio2 =====");

Console.WriteLine("Seleccione el lenguaje de programacion que desea consultar:\na)C#\nb)Java\nc)C++\n");
string opcion = Console.ReadLine();

switch (opcion)
{
    case "a":
        Console.WriteLine("Console.WriteLine(\"Hola Mundo\")");
        break;
    case "b":
        Console.WriteLine("System.out.println(\"Hola Mundo\")");
        break;
    case "c":
        Console.WriteLine("cout << \"Hola mundo!\" << endl;");
        break;
    default:
        Console.WriteLine("No ha seleccionado una opcion de la lista");
        break;
}