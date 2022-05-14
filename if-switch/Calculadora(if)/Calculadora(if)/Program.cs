using System;

namespace Calculadora_if_
{
    class Program
    {
            public static void Suma(int a, int b)
            {
                int result = a + b;
                Console.WriteLine($"Suma: {result}");
            }
            public static int Multiplicacion(int a, int b)
            {
                int result = a * b;
                return result;
            }
            public static int Resta(int a, int b)
            {
                int result = a - b;
                return result;
            }
            public static float Division(float a, float b)
            {
                float result = a / b;
                return result;
            }
            static void Main(string[] args){
                char opcion;
                int num1, num2;
                Console.WriteLine("Elija su operacion: [S]uma, [R]esta, [M]ultiplicacion, [D]ivision");
                opcion = char.Parse(Console.ReadLine());
                Console.WriteLine("escriba el primer numero");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("escriba el segundo numero");
                num2 = int.Parse(Console.ReadLine());
                if(opcion == 's' || opcion == 'S')
            {
                Suma(num1, num2);
            }
                else if(opcion == 'r' || opcion == 'R')
            {
                Console.WriteLine($"Resta: {Resta(num1, num2)}");
            }
                else if(opcion == 'm' || opcion == 'M')
            {
                Console.WriteLine($"Multiplicacion: {Multiplicacion(num1, num2)}");
            }
                else if(opcion == 'd' || opcion == 'D')
            {
                Console.WriteLine($"Division: {Division(num1, num2)}");
            }
                else
            {
                Console.WriteLine("Opcion no valida.");
            }
            }
        }
    }

