//Ejercicio1
Console.WriteLine("Ingrese su nombre");
string? nombre = Console.ReadLine();
Console.WriteLine("Ingrese su apellido");
string? apellido = Console.ReadLine();
Console.WriteLine("Ingrese su edad, por favor ingrese en números");
int? edad = Int32.Parse(Console.ReadLine());
Console.WriteLine("¿Sabe programar?, Opciones de respuesta: Si/No");
string? sabeProgramar = Console.ReadLine();

bool esProgramador = (sabeProgramar == "Si" ? true : false);

Console.WriteLine($"Hola {nombre} {apellido} tienes {edad} años de edad, ¿Sabes programar? {sabeProgramar}");


//Ejercicio2
int puertas = 3;
int ruedas = 4;
string marca = "Chevrolet Vitara";
DateTime ITVVigente = DateTime.Now;
double peso = 1.125;
double largo = 3.642;
string material = "Todoterreno";
string color = "Blanco";

Console.WriteLine("\n================================FICHA TÉCNICA =================================");
Console.WriteLine($"Marca: {marca}\nPuertas: {puertas}\nRudas: {ruedas}\nPeso: {peso}\nLargo: {largo}\nMaterial: {material}\nColor: {color}\nITVVigente: {ITVVigente.ToString()}");


Console.WriteLine("\n================================ OPERADORES =================================");

if (edad >= 18)
{
    Console.WriteLine("Mayor de edad");
}
else
{
    Console.WriteLine("Menor de edad");
}

char caracter = 'a';
bool resultado = Char.IsLetter(caracter);
Console.WriteLine(resultado);

if (edad >= 18 && resultado) Console.WriteLine("Operador AND");
if (edad >= 18 || resultado) Console.WriteLine("Operador OR");
