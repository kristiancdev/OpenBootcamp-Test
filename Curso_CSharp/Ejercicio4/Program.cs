Console.WriteLine("====== WHILE ======");

Console.WriteLine("Ingrese un número");
int numero = Int32.Parse(Console.ReadLine());
int contador = 1;
while (contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador = contador + 1;
}

Console.WriteLine("====== DO WHILE ======");
int numeroIngresado = 0;
int cantidadPositivos = 0;
int cantidadNegativos = 0;
do
{
    Console.WriteLine("Ingrese un número, 0 para salir");
    numeroIngresado = Int32.Parse(Console.ReadLine());
    if (numeroIngresado > 0)
    {
        cantidadPositivos++;
    }
    if (numeroIngresado < 0)
    {
        cantidadNegativos++;
    }
} while (numeroIngresado != 0);
Console.WriteLine($"Se han ingresado:\n{cantidadPositivos} Positivos\n{cantidadNegativos} Negativos");

Console.WriteLine("====== FOR ======");

Console.WriteLine("Ingrese el Ancho");
int ancho = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el Alto");
int alto = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el numero de repeticiones");
int repeticiones = Int32.Parse(Console.ReadLine());
Console.WriteLine("La figura tiene relleno, opciones:\n1)si\n2)no");
int relleno = Int32.Parse(Console.ReadLine());

bool rellenarFigura = (relleno == 1 ? true : false);
string espacios = "";
string asteriscos = "";

for (int i = 1; i <= ancho - 2; i++)
{
    if(rellenarFigura)
    {
        espacios = espacios + "X";    
    }
    else{
        espacios = espacios + " ";
    }
    
}
for (int i = 1; i <= ancho; i++)
{
    asteriscos = asteriscos + "X";
}

for (int repetir = 1; repetir <= repeticiones; repetir++)
{
    for (int i = 1; i <= alto; i++)
    {
        if (i == 1 || i == (alto))
            Console.WriteLine(asteriscos);
        else
            Console.WriteLine($"X{espacios}X");
    }
    Console.WriteLine("");
}
