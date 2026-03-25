using System;

class Program
{
    static void Main(string[] args)
    {
        int cantidadNotas = 5;
        int aprobados = 0;
        int reprobados = 0;
        int sumaNotas = 0;
        Console.WriteLine("Bienvenido al laboratorio 09")
        Console.WriteLine("Ejercicio 4 - Registro de notas");
        Console.WriteLine("-------------------------------");

        for (int i = 1; i <= cantidadNotas; i++)
        {
            Console.Write("Ingrese la nota " + i + ": ");
            int nota = int.Parse(Console.ReadLine());

            bool esAprobado = EvaluarNota(nota);

            if (esAprobado)
                aprobados++;
            else
                reprobados++;

            sumaNotas += nota;
        }

        MostrarResumen(sumaNotas, cantidadNotas, aprobados, reprobados);

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }

    static bool EvaluarNota(int nota)
    {
        if (nota >= 61)
        {
            Console.WriteLine("Aprobado");
            return true;
        }
        else
        {
            Console.WriteLine("Reprobado");
            return false;
        }
    }

    static void MostrarResumen(int sumaNotas, int cantidadNotas, int aprobados, int reprobados)
    {
        double promedio = sumaNotas / (double)cantidadNotas;

        Console.WriteLine("\nResumen de notas");
        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);
    }
}
