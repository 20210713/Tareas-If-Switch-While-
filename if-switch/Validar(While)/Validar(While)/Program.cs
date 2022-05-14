using System;
using System.Collections.Generic;

namespace Validar_While_
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string nombre, contraseña;

            Console.WriteLine("Nota: No se permiten usuarios menores de edad.");

            do
            {
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Contraseña: ");
                contraseña = Console.ReadLine();
                Console.Write("Edad: ");
                edad = int.Parse(Console.ReadLine());
            } while (edad >= 18);
            Console.WriteLine("EDAD NO VALIDA.");
        }
    }
}
