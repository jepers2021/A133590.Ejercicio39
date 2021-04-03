using System;
using System.Collections.Generic;

namespace A133590.Ejercicio39
{
    class Program
    {
        static double validarIngreso(string ingreso)
        {
            double numero;
            while (!Double.TryParse(ingreso, out numero))
            {
                Console.Write("Ingreso inválido, intente nuevamente: ");
                ingreso = Console.ReadLine();
            }

            return numero;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 39");
            Console.WriteLine("Programa que recibe una serie de números y luego los presenta en orden inverso.");
            List<double> lista = new List<double>();
            string seguir = "";
            do
            {
                Console.Write("Por favor, ingrese un número: ");
                lista.Add(validarIngreso(Console.ReadLine()));
                Console.Write("¿Desea ingresar otro número? (y/n): ");
                seguir = Console.ReadLine().Trim();
            } while (seguir.Equals("y"));

            Console.WriteLine("Lista invertida:");
            lista.Reverse();
            foreach(double elemento in lista)
            {
                Console.Write($"{elemento} ");
            }
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
