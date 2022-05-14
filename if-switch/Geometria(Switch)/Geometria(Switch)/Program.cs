using System;

namespace Geometria_Switch_
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            float a, b, h;

            Console.WriteLine("[C]uadrado, [R]ectangulo, [T]riangulo, Tra[P]ezio, Circu[L]o:");
            opcion = char.Parse(Console.ReadLine());

            switch (char.ToUpper(opcion))
            {
                case 'C':
                    //Cuadrado
                    Console.WriteLine("Escriba el lado del Cuadrado");
                    a = float.Parse(Console.ReadLine());
                    Console.WriteLine($"El area del Cuadrado es: {cuadrado(a)}");
                    break;

                case 'R':
                    //Rectangulo
                    Console.WriteLine("Escriba la base del Rectangulo");
                    a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba la altura del Rectangulo");
                    b = float.Parse(Console.ReadLine());
                    Console.WriteLine($"El area del Rectangulo es: {rectangulo(a, b)}");
                    break;

                case 'T':
                    //Triangulo
                    Console.WriteLine("Escriba la base del Triagulo");
                    a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba la altura del Triangulo");
                    b = float.Parse(Console.ReadLine());
                    Console.WriteLine($"El area del Triangulo es: {triangulo(a, b)}");
                    break;

                case 'P':
                    //Trapezio
                    Console.WriteLine("Escriba la base mayor del Trapezio");
                    a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba la base menor del Trapezio");
                    b = float.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba la altura del Trapecio");
                    h = float.Parse(Console.ReadLine());
                    Console.WriteLine($"El area del Trapecio es: {trapecio(a, b, h)}");
                    break;

                case 'L':
                    //Circulo
                    Console.WriteLine("Escriba el radio del Circulo");
                    a = float.Parse(Console.ReadLine());
                    Console.WriteLine($"El diametro del Circulo es: {circulo(a)}");
                    break;
            }
        }
        static float cuadrado(float a)
        {
            return a * a;
        }

        static float rectangulo(float a, float b)
        {
            return a * b;
        }
        static float triangulo(float a, float b)
        {
            return (a * b) / 2;
        }
        static float circulo(float a)
        {
            return 2 * a;
        }
        static float trapecio(float a, float b, float h)
        {
            return h * ((a + b) / 2);
        }
    }
}
