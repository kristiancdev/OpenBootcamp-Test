/* Online C# Compiler and Editor */
using System.IO;
using System;

class Program
{
    static void Main()
    {
        string nombre = Console.ReadLine();
        Console.WriteLine($"Hola, {nombre}");

        string hora = DateTime.Now.ToString("HH:mm:ss");
        Console.WriteLine($"Son las: {hora}");
    }
}