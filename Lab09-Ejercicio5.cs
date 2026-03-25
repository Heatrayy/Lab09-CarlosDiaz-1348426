using System;

class Program
{
    static void Main(string[] args)
    {
        int numero1;
        int numero2;

        Console.WriteLine("Ejercicio 5 - Intercambio de valores");
        Console.Write("Ingrese el primer numero: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        numero2 = int.Parse(Console.ReadLine());

        MostrarValores("Antes del intercambio", numero1, numero2);

        IntercambiarValores(ref numero1, ref numero2);

        MostrarValores("Despues del intercambio", numero1, numero2);

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }

    static void IntercambiarValores(ref int a, ref int b)
    {
        int aux = a;
        a = b;
        b = aux;
    }

    static void MostrarValores(string titulo, int a, int b)
    {
        Console.WriteLine("\n" + titulo + ": " + a + ", " + b);
    }
}
